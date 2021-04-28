using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_6_Program_2
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
        {
            MessageBox.Show("This is the subclass: " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}
