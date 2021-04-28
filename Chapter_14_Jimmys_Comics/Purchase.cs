using System.Collections.Generic;

namespace Chapter_14_Jimmys_Comics
{
    public class Purchase
    {
        public int Issue { get; set; }
        public decimal Price { get; set; }

        public static IEnumerable<Purchase> FindPurchases()
        {
            return new List<Purchase>()
            {
                new Purchase() { Issue = 68, Price = 225M },
                new Purchase() { Issue = 19, Price = 375M },
                new Purchase() { Issue = 6, Price = 3600M },
                new Purchase() { Issue = 57, Price = 13215M },
                new Purchase() { Issue = 36, Price = 660M },
            };
        }
        
        public static PriceRange EvaluatePrice(decimal price)
        {
            if (price < 100) return PriceRange.Cheap;
            if (price < 1000) return PriceRange.Midrange;
            return PriceRange.Expensive;
        }
    }
}