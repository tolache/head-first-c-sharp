using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Chapter_10_Go_Fish
{
    public class Game : INotifyPropertyChanged
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;

        public Game()
        {
            PlayerName = "Tola";
            Hand = new ObservableCollection<string>();
            ResetGame();
        }
       
        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }

        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }

        public void StartGame()
        {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();
            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Finn", random, this));
            players.Add(new Player("Jake", random, this));
            Deal();
            players[0].SortHand();
            foreach (string cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }

        private void ClearProgress()
        {
            GameProgress = String.Empty;
            OnPropertyChanged("GameProgress");
        }

        public void AddProgress(string progress)
        {
            GameProgress = progress + Environment.NewLine + GameProgress;
            OnPropertyChanged("GameProgress");
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
                foreach (Player player in players)
                    player.TakeCard(stock.Deal());
            
            foreach (Player player in players)
                player.PullOutBooks();
            
            OnPropertyChanged("Books");
        }

        public void PlayOneRound(int selectedPlayerCard)
        {
            Values selectedValue = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[i].AskForCard(players, i, stock, selectedValue);
                else
                    players[i].AskForCard(players, i, stock);
            }

            foreach (Player player in players)
            {
                if (PullOutBooks(player))
                {
                    for (int i = 1; i <= 5 && stock.Count > 0; i++)
                    {
                        player.TakeCard(stock.Deal());
                    }
                }
            }

            players[0].SortHand();
            if (stock.Count == 0)
            {
                AddProgress("The stock is out of cards. Game over!");
                AddProgress(GetWinnerName());
                ResetGame();
                return;
            }

            RefreshHand();
            AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }

        public bool PullOutBooks(Player player)
        {
            foreach (Values value in player.PullOutBooks())
                books.Add(value, player);
        
            OnPropertyChanged("Books");
            return player.CardCount == 0;
        }

        public string DescribeBooks()
        {
            string result = "";
            foreach (KeyValuePair<Values, Player> entry in books)
            {
                result += entry.Value.Name + " has a book of " + Card.Plural(entry.Key) + "." +
                                      Environment.NewLine;
            }

            return result;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = players.ToDictionary(x => x.Name, x => 0);
            foreach (Values value in books.Keys)
                winners[books[value].Name]++;

            int hightestNumberOfBooks = 0;
            foreach (int numberOfBooks in winners.Values)
            {
                if (numberOfBooks > hightestNumberOfBooks)
                    hightestNumberOfBooks = numberOfBooks;
            }

            List<string> winnerNames = new List<string>();
            foreach (KeyValuePair<string, int> entry in winners)
            {
                if (entry.Value == hightestNumberOfBooks)
                    winnerNames.Add(entry.Key);
            }

            string winnerName;
            if (winnerNames.Count == 1)
                winnerName = winnerNames[0] + " wins with " + winners[winnerNames[0]] + " books.";
            else
                winnerName = "The game ends with a tie between " + winnerNames[0] + " and " + winnerNames[1] + ".";

            return winnerName;
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " hands " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card. " + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }

            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }

        private void ResetGame()
        {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Hand.Clear();
        }

        private void RefreshHand()
        {
            Hand.Clear();
            foreach (string cardName in GetPlayerCardNames())
                Hand.Add(cardName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}