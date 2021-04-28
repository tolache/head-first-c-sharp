using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chapter_8_Go_Fish
{
    public class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnform)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnform;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnform));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnform));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                    player.TakeCard(stock.Deal());
            }

            foreach (Player player in players)
                player.PullOutBooks();
        }

        public bool PlayOneRound(int selectedPlayerCard)
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
                textBoxOnForm.Text += "The stock is out of cards. Game over!";
                return true;
            }

            return false;
        }

        public bool PullOutBooks(Player player)
        {
            foreach (Values value in player.PullOutBooks())
            {
                books.Add(value, player);
            }
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
            {
                winners[books[value].Name]++;
            }

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
            {
                winnerName = winnerNames[0] + " with " + winners[winnerNames[0]] + " books." + Environment.NewLine;
            }
            else
            {
                winnerName = "A tie between " + winnerNames[0] + " and " + winnerNames[1] + "." + Environment.NewLine;
            }

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
    }
}