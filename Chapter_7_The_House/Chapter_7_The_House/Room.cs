using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_The_House
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
