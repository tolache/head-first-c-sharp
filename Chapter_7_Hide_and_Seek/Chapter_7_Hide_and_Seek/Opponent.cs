using System;

namespace Chapter_7_Hide_and_Seek
{
    class Opponent
    {
        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        private Location myLocation;
        private Random random;

        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHasExterriorDoor)
                {
                    IHasExterriorDoor locationWithDoor = myLocation as IHasExterriorDoor;
                    if (random.Next(2) == 1) myLocation = locationWithDoor.DoorLocation;
                }
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
                hidden = true;
            }
        }

        public bool Check(Location location)
        {
            if (location == myLocation) { return true; }
            else { return false; }
        }
    }
}
