using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Clogs, Color = "Brown" });
            shoeCloset.Add(new Shoe() { Style = Style.Wingtips, Color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "White" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "Red" });
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Green" });
        }
    }

    class Shoe
    {
        public Style Style;
        public string Color;
    }

    enum Style
    {
        Sneakers,
        Loafers,
        Sandals,
        Flopflops,
        Wingtips,
        Clogs,
    }
}
