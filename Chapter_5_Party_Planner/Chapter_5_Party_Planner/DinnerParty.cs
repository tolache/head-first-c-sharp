using System;

namespace Chapter_5_Party_Planner
{
    public class DinnerParty
    {
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private const int foodCostPerPerson = 25;

        private const int softDrinksCostPerPerson = 5;
        private const int boozeCostPerPerson = 20;
        private decimal discount;

        private const int fancyDecorationsCostPerPerson = 15;
        private const decimal normalDecorationCostPerPerson = 7.5M;
        private const int fancyDecoratingFee = 50;
        private const int normalDecoratingFee = 30;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public decimal Cost
        {
            get
            {
                return (foodCostPerPerson * NumberOfPeople + CalculateBeveragesCost() + CalculateDecorationsCost()) * (1 - discount);
            }
        }

        private decimal CalculateDecorationsCost()
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

        private decimal CalculateBeveragesCost()
        {
            if (HealthyOption)
            {
                discount = 0.05M; // 0.05 is 5% discount
                return softDrinksCostPerPerson * NumberOfPeople;
            }
            else
            {
                discount = 0;
                return boozeCostPerPerson * NumberOfPeople;
            }
        }
    }
}
