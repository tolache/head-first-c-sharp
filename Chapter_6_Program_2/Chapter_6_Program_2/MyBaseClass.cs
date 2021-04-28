using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_6_Program_2
{
    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("This is the base class: " + baseClassNeedsThis);
        }
    }
}
