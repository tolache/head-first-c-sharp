using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Dog_Race_Lab
{
    public class Bet
    {
        public int amount;
        public int zerglingNumber;
        public Goga bettor;

        public string GetDescription()
        {
            if (amount > 0)
            {
                return bettor.name + " bets " + amount + " on zergling #" + (zerglingNumber + 1);
            }
            else
            {
                return bettor.name + " hasn't placed a bet";
            }
        }

        public int PayOut(int raceWinner)
        {
            if (Form1.zerglingArray[raceWinner].finished == true)
            {
                return amount;
            }
            else
            {
                return -amount;
            }
        }
    }
}
