using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Dog_Race_Lab
{
    public class Goga
    {
        public string name;
        public Bet myBet;
        public int cash;
        public RadioButton myRadioButton;
        public Label myLabel;

        public void UpdateLabels()
        {
            myRadioButton.Text = name + " has " + cash + " bucks";
            myLabel.Text = myBet.GetDescription();
        }

        public void ClearBet()
        {
            myBet = new Bet()
            {
                amount = 0,
                zerglingNumber = 0,
                bettor = this
            };
            UpdateLabels();
        }

        public bool PlaceBet(int betAmount, int zerglingToWin)
        {
            if (cash >= betAmount)
            {
                myBet.amount = betAmount;
                myBet.zerglingNumber = zerglingToWin;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int raceWinner)
        {
            cash += myBet.PayOut(raceWinner);
            ClearBet();
            UpdateLabels();
        }
    }
}
