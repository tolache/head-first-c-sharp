namespace Chapter_7_Hide_and_Seek
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExterriorDoor
    {
        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription) : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
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
