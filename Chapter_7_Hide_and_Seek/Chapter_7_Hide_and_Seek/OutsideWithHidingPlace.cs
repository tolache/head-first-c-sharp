namespace Chapter_7_Hide_and_Seek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool cold, string hidingPlaceName) : base(name, cold)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; }
    }
}