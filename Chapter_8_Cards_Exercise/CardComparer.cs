using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8_Cards_Exercise
{
    class CardComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value) return 1;
            else if (x.Value < y.Value) return -1;
            else if (x.Suit > y.Suit) return 1;
            else if (x.Suit < y.Suit) return -1;
            else return 0;
        }
    }
}
