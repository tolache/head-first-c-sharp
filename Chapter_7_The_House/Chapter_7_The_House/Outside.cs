using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_The_House
{
    class Outside : Location
    {
        public Outside(string name, bool cold) : base(name)
        {
            Cold = cold;
        }
        public bool Cold { get; }
        public override string Description
        {
            get
            {
                string description = base.Description;
                if (Cold)
                {
                    description += " It's very cold here.";
                }
                return description;
            }
        }
    }
}
