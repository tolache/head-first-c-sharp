using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzleANoiseAnnoysAnOyster
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string poem = "";

            while (x < 4)
            {
                poem += "a";
                if (x < 1)
                {
                    poem += " ";
                }
                poem += "n";
                if (x > 1)
                {
                    poem += " oyster";
                    x += 2;
                }
                if (x == 1)
                {
                    poem += "noys ";
                }
                if (x < 1)
                {
                    poem += "oise ";
                }
                x += 1;
            }


            Console.WriteLine(poem);
            Console.ReadKey();
        }
        /*                
         *                x > 0           
         *                        x += 2; 
         *                x > 1   x -= 2; 
         * poem += "an";  x > 3   x -= 1; poem += "annoys";
         *                                poem += "noise";
         */
    }
}
