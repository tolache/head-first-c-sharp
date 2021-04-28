namespace Chapter_7_Hide_and_Seek
{
    class Outside : Location
    {
        public Outside(string name, bool cold) : base(name)
        {
            Cold = cold;
        }
        public bool Cold { get; }
        public override string Description
        {
            get
            {
                string description = base.Description;
                if (Cold)
                {
                    description += " It's very cold here.";
                }
                return description;
            }
        }
    }
}
