using System;

namespace Chapter_13_SuperSoldierSerum
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman steve = new OrdinaryHuman("Steve",40,95);
            Console.WriteLine(steve.BreakWalls(89.2));
        }
    }
}
