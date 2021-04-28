namespace Chapter_8_Cards_2
{
    class Card
    {
        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }

        public static bool CardMatches(Card cardToChek, Suits suit)
        {
            if (cardToChek.Suit == suit)
            {
                return true;
            }

            return false;
        }
        
        public static bool CardMatches(Card cardToChek, Values value)
        {
            if (cardToChek.Value == value)
            {
                return true;
            }

            return false;
        }
    }
}
