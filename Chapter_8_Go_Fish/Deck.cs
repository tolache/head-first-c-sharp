using System;
using System.Collections.Generic;

namespace Chapter_8_Go_Fish
{
    public class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        
        public int Count
        {
            get { return cards.Count; }
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public void Shuffle()
        {
            List<Card> shuffledCards = new List<Card>();
            while (cards.Count > 0)
            {
                int cardToMove = random.Next(cards.Count);
                shuffledCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = shuffledCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] cardNames = new string[cards.Count];
            foreach (Card card in cards)
            {
                cardNames[cards.IndexOf(card)] = card.Name;
            }
            return cardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparerBySuit());
        }

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
            {
                if (card.Value == value) return true;
            }

            return false;
        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] {});
            for (int i = cards.Count - 1; i >= 0; i--)
            {
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            }

            return deckToReturn;
        }

        public bool HasBook(Values value)
        {
            int numberOfCards = 0;
            foreach (Card card in cards)
            {
                if (card.Value == value)
                    numberOfCards++;
            }

            if (numberOfCards == 4)
                return true;
            return false;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparerByValue());
        }
    }
}