namespace Chapter_7_Hide_and_Seek
{
    interface IHasExterriorDoor
    {
        string DoorDescription
        {
            get;
        }
        Location DoorLocation
        {
            get;
            set;
        }
    }
}
