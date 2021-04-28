namespace Chapter_6_Beehive_2._0
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = 0.25;

        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
