using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_15_Delegates
{
    delegate void MyIntAndString(int i, string s);
    delegate int CombineTwoInts(int x, int y);

    static class Program
    {
        static void Main(string[] args)
        {
            ConvertIntToString someMethod = new ConvertIntToString(HiThere);
            string message = someMethod(5);
            Console.WriteLine(message);

            MyIntAndString printThem = delegate(int i, string s) { Console.WriteLine($"{i} - {s}"); };
            printThem(123, "four five six");
            
            MyIntAndString contains = delegate(int i, string s)
            {
                if (s.Contains(i.ToString()))
                    Console.WriteLine($"{s} contains {i}");
                else
                    Console.WriteLine($"{s} does not contain {i}");
            };
            contains(123, "01234");
            contains(123, "234");

            Delegate d = contains;
            d.DynamicInvoke(new object[] {111, "000111222"});

            CombineTwoInts adder = (a, b) => { return a + b; };
            CombineTwoInts multiplier = (a, b) => a * b;
            Console.WriteLine(adder(20,30));
            Console.WriteLine(multiplier(20,30));

            var greaterThan3 = new List<int> {1, 2, 3, 4, 5, 6}.Where(x => x > 3);
            foreach (int i in greaterThan3)
            {
                Console.Write($"{i} ");
            }
        }

        public static string HiThere(int i)
        {
            return "Hi there! #" + (i * 100);
        }
    }
}
