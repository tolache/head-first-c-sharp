namespace Chapter_8_Retired_Jersey_Numbers
{
    class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player, int yearRetired)
        {
            Player = player;
            YearRetired = yearRetired;
        }
    }
}
