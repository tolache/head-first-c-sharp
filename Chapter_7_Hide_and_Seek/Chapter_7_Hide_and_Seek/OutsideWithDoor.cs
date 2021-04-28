namespace Chapter_7_Hide_and_Seek
{
    class OutsideWithDoor : Outside, IHasExterriorDoor
    {
        public OutsideWithDoor(string name, bool cold, string doorDescripion) : base(name, cold)
        {
            DoorDescription = doorDescripion;
        }

        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }

        public override string Description
        {
            get
            {
                string description = base.Description;
                return description += " There is " + DoorDescription + ".";
            }
        }
    }
}
