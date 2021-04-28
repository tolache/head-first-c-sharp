﻿﻿using System;

  namespace Chapter_9_Card_Serializer
{
    [Serializable]
    public class Card
    {
        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }
        public string Name
        {
            get
            {
                return Value + " of " + Suit;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "Sixes";
            return value + "s";
        }

    }
}
