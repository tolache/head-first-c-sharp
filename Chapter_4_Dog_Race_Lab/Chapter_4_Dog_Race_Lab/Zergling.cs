using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Dog_Race_Lab
{
    public class Zergling
    {
        public int startingPosition; // Where my PictureBox starts
        public int racetrackLength; // How long the racetrack is
        public PictureBox myPictureBox = null; // My PictureBox object
        public int location = 0; // My location on the racetrack
        public Random randomizer; // An instance of Random
        public bool finished = false;

        public bool Run()
        {
            if (!finished)
            {
                location += randomizer.Next(1, 4);
                myPictureBox.Left = startingPosition + location;
                if (myPictureBox.Left >= racetrackLength - myPictureBox.Width)
                {
                    finished = true;
                }
                return finished;
            }
            else
            {
                return finished;
            }
        }

        public void TakeStartingPosition()
        {
            finished = false;
            location = 0;
            myPictureBox.Left = startingPosition;
        }
    }
}
