namespace Chapter_5_Cow_Calculator
{
    class Farmer
    {
        public Farmer(int numberOfCows, int FeedMultiplier)
        {
            this.FeedMultiplier = FeedMultiplier;
            NumberOfCows = numberOfCows;
        }

        public int FeedMultiplier { get; private set; }
        public int BagsOfFeed { get; private set; }

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
