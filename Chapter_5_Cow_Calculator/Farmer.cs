using System;

namespace Cow_Calculator
{
    class Farmer
    {
        public int BagsOfFeed;
        public const int FeedMultiplier = 30;
    
        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
    
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
