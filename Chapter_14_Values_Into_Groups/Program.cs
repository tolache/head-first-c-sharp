using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_14_Values_Into_Groups
{
    internal static class Program
    {
        private enum PriceRange
        {
            Cheap, Midrange, Expensive
        }

        private static void Main()
        {
            Dictionary<int, decimal> values = GetPrices();

            var priceGroups =
                from pair in values
                group pair.Key by EvaluatePrice(pair.Value)
                into priceGroup
                orderby priceGroup.Key descending
                select priceGroup;

            foreach (var group in priceGroups)
            {
                Console.WriteLine($"Found {group.Count()} {group.Key} comics. Issues:");
                int lastIssueNumber = group.Last();
                foreach (var issueNumber in group)
                {
                    if (issueNumber != lastIssueNumber)
                    {
                        Console.Write($"{issueNumber}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{issueNumber}.");
                    }
                }
            }
        }

        private static PriceRange EvaluatePrice(decimal price)
        {
            if (price < 100M) return PriceRange.Cheap;
            if (price < 1000M) return PriceRange.Midrange;
            return PriceRange.Expensive;
        }
        
        private static Dictionary<int, decimal> GetPrices() {
            Random random = new Random();
            var result = new Dictionary<int, decimal>{};
            for (int i = 1; i <= 100; i++)
            {
                int centsPrice = random.Next(1, 100501);
                decimal price = centsPrice / 100M;
                result.Add(i, price);
            }
            return result;
        }
    }
}