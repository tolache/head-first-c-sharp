namespace Chapter_7_Hide_and_Seek
{
    class Room : Location
    {
        public Room(string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public string Decoration { get; }

        public override string Description
        {
            get
            {
                return base.Description + " I see " + Decoration + ".";
            }
        }
    }
}
