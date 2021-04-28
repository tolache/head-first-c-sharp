﻿using System.Collections.Generic;

namespace Chapter_8_Go_Fish
{
    class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value) return 1;
            if (x.Value < y.Value) return -1;
            if (x.Suit > y.Suit) return 1;
            if (x.Suit < y.Suit) return -1;
            return 0;
        }
    }
}