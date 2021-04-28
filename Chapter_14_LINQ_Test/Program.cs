using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_14_LINQ_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {0,12,44,36,92,54,13,8};

            var result = from v in values
                where v < 37
                orderby v descending 
                select v;

            foreach (var i in result)
            {
                Console.WriteLine(i);   
            }
            
            Console.WriteLine("SportCollection contents:");
            SportCollection sportCollection = new SportCollection();
            foreach (Sport sport in sportCollection)
                Console.WriteLine(sport);
            
            Console.WriteLine(sportCollection[3]);
            
            IEnumerable<string> names = NameEnumerator(); // Put a breakpoint here
            foreach (string name in names)
                Console.WriteLine(name);
        }

        static IEnumerable<string> NameEnumerator() {
            yield return "Bob"; // The method exits after this statement ...
            yield return "Harry"; // ... and resumes here the next time through
            yield return "Joe";
            yield return "Frank";
        }
    }
}