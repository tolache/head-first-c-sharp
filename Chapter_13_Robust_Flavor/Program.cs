using System;
using DefaultNamespace;

namespace Chapter_13_Robust_Flavor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter birthday: ");
            string birthday = Console.ReadLine();
            Console.Write("Enter height: ");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy);
            Console.ReadKey();
        }
    }
}
