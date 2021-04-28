using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_8_Birds
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }
        public override string ToString()
        {
            return "A penguin named " + base.Name;
        }
    }
}
