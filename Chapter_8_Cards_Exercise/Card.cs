using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8_Cards_Exercise
{
    class Card
    {
        public Card (Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public Values Value { get; set; }
        public Suits Suit { get; set; }

        public string Name => Value.ToString() + " of " + Suit.ToString();

        public override string ToString()
        {
            return Name;
        }
    }
}