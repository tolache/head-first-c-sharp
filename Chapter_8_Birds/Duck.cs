using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Birds
{
    class Duck : Bird, IComparable<Duck>
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

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }
}
