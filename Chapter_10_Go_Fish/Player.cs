using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_10_Go_Fish
{
    public class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private Game game;

        public Player(String name, Random random, Game game)
        {
            this.name = name;
            this.random = random;
            cards = new Deck(new Card[] {});
            this.game = game;
            game.AddProgress(name + " has joined the game.");
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            foreach (Values value in (Values[]) Enum.GetValues(typeof(Values)))
            {
                if (cards.HasBook(value))
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            
            
            return books;
        }

        public Values GetRandomValue()
        {
            Card card = cards.Peek(random.Next(0, cards.Count));
            return card.Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            Deck result = new Deck(new Card[] {});
            game.AddProgress(Name + " has " + result.Count + " " + Card.Plural(value));
            for (int cardNumber = 0; cardNumber < cards.Count; cardNumber++)
            {
                if (cards.ContainsValue(value))
                {
                    result = cards.PullOutValues(value);
                    break;
                }
            }
            
            int count = result.Count;
            if (count > 0)
            {
                string valueString = value.ToString();
                if (count > 1) valueString = Card.Plural(value);
                game.AddProgress(name + " has " + count + " " + valueString + ".");
            }
            
            return result;
        }

        public void AskForCard(IEnumerable<Player> players, int myIndex, Deck stock)
        {
            List<Player> playersList = players.ToList();
            if (playersList[myIndex].cards.Count > 0)
                AskForCard(playersList, myIndex, stock, GetRandomValue());
        }

        public void AskForCard(IEnumerable<Player> players, int myIndex, Deck stock, Values value)
        {
            game.AddProgress(name + " asks if anyone has a " + value + ".");
            List<Player> playersList = players.ToList();
            int numberOfCards = 0;
            foreach (Player player in playersList)
            {
                if (playersList[myIndex] != player)
                {
                    Deck cardsToAdd = player.DoYouHaveAny(value);
                    numberOfCards += cardsToAdd.Count;
                    while (cardsToAdd.Count > 0)
                        cards.Add(cardsToAdd.Deal());
                }
            }

            if (numberOfCards == 0)
            {
                cards.Add(stock.Deal());
                game.AddProgress(name + " went to fish.");
            }
        }
        
        public int CardCount { get { return  cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}