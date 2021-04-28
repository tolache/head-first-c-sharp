using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_The_House
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
