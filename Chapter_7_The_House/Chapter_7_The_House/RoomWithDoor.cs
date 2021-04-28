using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_The_House
{
    class RoomWithDoor : Room, IHasExterriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
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
