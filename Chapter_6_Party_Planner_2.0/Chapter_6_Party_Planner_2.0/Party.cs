namespace Chapter_6_Party_Planner_2._0
{
    public class Party
    {
        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        protected const int foodCostPerPerson = 25;
        protected const int fancyDecorationsCostPerPerson = 15;
        protected const decimal normalDecorationCostPerPerson = 7.5M;
        protected const int fancyDecoratingFee = 50;
        protected const int normalDecoratingFee = 30;

        public virtual decimal Cost
        {
            get
            {
                if (NumberOfPeople <= 12)
                {
                    return CalculateDecorationsCost() + foodCostPerPerson * NumberOfPeople;
                }
                else
                {
                    return CalculateDecorationsCost() + foodCostPerPerson * NumberOfPeople + 100M;
                }

            }
        }

        protected decimal CalculateDecorationsCost()
        {
            if (FancyDecorations)
            {
                return fancyDecorationsCostPerPerson * NumberOfPeople + fancyDecoratingFee;
            }
            else
            {
                return normalDecorationCostPerPerson * NumberOfPeople + normalDecoratingFee;
            }
        }
    }
}