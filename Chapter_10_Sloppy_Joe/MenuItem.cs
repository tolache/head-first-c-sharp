using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_10_Sloppy_Joe
{
    public class MenuItem
    {

        public MenuItem(string meat, string condiment, string bread)
        {
            Meat = meat;
            Condiment = condiment;
            Bread = bread;
        }

        public string Meat { get; private set; }
        public string Condiment { get; private set; }
        public string Bread { get; private set; }

        public override string ToString()
        {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
}
