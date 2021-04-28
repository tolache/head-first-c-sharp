namespace Chapter_7_Hide_and_Seek
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; }
    }
}
