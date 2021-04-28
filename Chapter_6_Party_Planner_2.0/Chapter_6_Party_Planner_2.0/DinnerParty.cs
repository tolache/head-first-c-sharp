namespace Chapter_6_Party_Planner_2._0
{
    public class DinnerParty : Party
    {
        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption) : base(numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
        }

        public bool HealthyOption { get; set; }

        private const int softDrinksCostPerPerson = 5;
        private const int boozeCostPerPerson = 20;
        private decimal discount;

        public override decimal Cost
        {
            get
            {
                return (base.Cost + CalculateBeveragesCost()) * (1 - discount);
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
