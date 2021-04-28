using System;
using System.Collections.Generic;

namespace Chapter_14_LINQ_Test
{
    enum Sport
    {
        Football, Baseball,
        Basketball, Hockey,
        Boxing, Rugby, Fencing,
    }
    
    class SportCollection : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator() {
            return new ManualSportEnumerator();
        }
        
        public Sport this[int index]
        {
            get { return (Sport)index; }
        }
        
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
        
        class ManualSportEnumerator : IEnumerator<Sport> {
            int current = -1;
            public Sport Current { get { return (Sport)current; } }
            public void Dispose() { return; } // Nothing to dispose
            object System.Collections.IEnumerator.Current { get { return Current; } }
            public bool MoveNext() {
                int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;
                if ((int)current >= maxEnumValue)
                    return false;
                current++;
                return true;
            }
            public void Reset() { current = 0; }
        }
    }
}