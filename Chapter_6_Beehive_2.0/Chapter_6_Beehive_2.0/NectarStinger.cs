namespace Chapter_6_Beehive_2._0
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger(double weightMg, string[] jobsICanDo) : base(weightMg, jobsICanDo) { }

        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public int Nectart { get; set; }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int Length)
        {
            return 1;
        }

        public void FindFlower()
        {

        }

        public void GatherNectar()
        {

        }

        public void ReturnToHive()
        {

        }
    }
}
