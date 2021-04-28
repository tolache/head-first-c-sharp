using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_The_House
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
