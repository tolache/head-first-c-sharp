using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Dog_Race_Lab
{
    public partial class Form1 : Form
    {
        public static Zergling[] zerglingArray = new Zergling[4];
        Goga[] gogaArray = new Goga[3];
        Random myRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            zerglingArray[0] = new Zergling()
            {
                myPictureBox = zergling1PictureBox,
                startingPosition = zergling1PictureBox.Left,
                racetrackLength = raceTrackPictureBox.Width - zergling1PictureBox.Width - 73,
                randomizer = myRandomizer
            };
            zerglingArray[1] = new Zergling()
            {
                myPictureBox = zergling2PictureBox,
                startingPosition = zergling2PictureBox.Left,
                racetrackLength = raceTrackPictureBox.Width - zergling2PictureBox.Width - 73,
                randomizer = myRandomizer
            };
            zerglingArray[2] = new Zergling()
            {
                myPictureBox = zergling3PictureBox,
                startingPosition = zergling3PictureBox.Left,
                racetrackLength = raceTrackPictureBox.Width - zergling3PictureBox.Width - 73,
                randomizer = myRandomizer
            };
            zerglingArray[3] = new Zergling()
            {
                myPictureBox = zergling4PictureBox,
                startingPosition = zergling4PictureBox.Left,
                racetrackLength = raceTrackPictureBox.Width - zergling4PictureBox.Width - 73,
                randomizer = myRandomizer
            };

            gogaArray[0] = new Goga()
            {
                name = "Tola",
                cash = 50,
                myRadioButton = tolaRadioButton,
                myLabel = tolaBetLabel
            };
            gogaArray[1] = new Goga()
            {
                name = "Seva",
                cash = 75,
                myRadioButton = sevaRadioButton,
                myLabel = sevaBetLabel
            };
            gogaArray[2] = new Goga()
            {
                name = "Alexey",
                cash = 45,
                myRadioButton = alexeyRadioButton,
                myLabel = alexeyBetLabel
            };

            foreach (Goga goga in gogaArray)
            {
                goga.ClearBet();
            }

            minimumBetLabel.Text = "Minimum bet: " + betNumericUpDown.Minimum + " bucks";
            nameLabel.Text = gogaArray[0].name;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            if (tolaRadioButton.Checked == true)
            {
                if (gogaArray[0].PlaceBet((int)betNumericUpDown.Value, ((int)zerglingNumericUpDown.Value) - 1))
                {
                    gogaArray[0].UpdateLabels();
                }
                else
                {
                    MessageBox.Show(gogaArray[0].name + " doesn't have " + betNumericUpDown.Value + " bucks :(", "Couldn't place a bet");
                }
            }
            else if (sevaRadioButton.Checked == true)
            {
                if (gogaArray[1].PlaceBet((int)betNumericUpDown.Value, ((int)zerglingNumericUpDown.Value) - 1))
                {
                    gogaArray[1].UpdateLabels();
                }
                else
                {
                    MessageBox.Show(gogaArray[1].name + " doesn't have " + betNumericUpDown.Value + " bucks :(", "Couldn't place a bet");
                }
            }
            else if (alexeyRadioButton.Checked == true)
            {
                if (gogaArray[2].PlaceBet((int)betNumericUpDown.Value, ((int)zerglingNumericUpDown.Value) - 1))
                {
                    gogaArray[2].UpdateLabels();
                }
                else
                {
                    MessageBox.Show(gogaArray[2].name + " doesn't have " + betNumericUpDown.Value + " bucks :(", "Couldn't place a bet");
                }
            }
            else
            {
                MessageBox.Show("Bettor is not selected.", "Couldn't place a bet");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (zerglingArray[i].Run())
                {
                    timer1.Stop();
                    bettingParlorGroupBox.Enabled = true;

                    MessageBox.Show("Zergling #" + (i + 1) + " won the race!", "We have a winner");

                    foreach (Goga goga in gogaArray)
                    {
                        goga.Collect(goga.myBet.zerglingNumber);
                        goga.ClearBet();
                    }

                    foreach (Zergling zergling in zerglingArray)
                    {
                        zergling.TakeStartingPosition();
                    }
                }
            }
        }

        private void tolaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = gogaArray[0].name;
        }

        private void sevaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = gogaArray[1].name;
        }

        private void alexeyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = gogaArray[2].name;
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            bettingParlorGroupBox.Enabled = false;
        }
    }
}
