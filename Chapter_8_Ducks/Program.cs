using System;
using System.Collections.Generic;

namespace Chapter_8_Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            DuckSizeComparer sizeComparer = new DuckSizeComparer();
            DuckKindComparer kindComparer = new DuckKindComparer();
            DuckComparer comparer = new DuckComparer();

            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            IEnumerator<Duck> enumerator = ducks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Duck duck = enumerator.Current;
                Console.WriteLine(duck);
            }
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null) disposable.Dispose();

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
            Console.WriteLine("End of ducks!");
        }
    }
}