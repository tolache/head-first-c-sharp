using System;


namespace Chapter_8_Ducks
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck otherDuck)
        {
            if (this.Size > otherDuck.Size)
                return 1;
            else if (this.Size < otherDuck.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return "A " + (Size + 1) + " inch " + Kind;
        }
    }
}