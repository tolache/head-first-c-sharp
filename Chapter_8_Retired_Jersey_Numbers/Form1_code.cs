using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter_8_Retired_Jersey_Numbers
{
    public partial class Form1 : Form 
    {
        Dictionary<int, JerseyNumber> retiredNumbers = new Dictionary<int, JerseyNumber>()
        {
            { 3, new JerseyNumber("Babe Ruth", 1948) },
            {4, new JerseyNumber("Lou Gehrig", 1939)},
            {5, new JerseyNumber("Joe DiMaggio", 1952)},
            {7, new JerseyNumber("Mickey Mantle", 1969)},
            {8, new JerseyNumber("Yogi Berra", 1972)},
            {23, new JerseyNumber("Don Mattingly", 1997)},
            {42, new JerseyNumber("Jackie Robinson", 1993)},
            {44, new JerseyNumber("Reggie Jackson", 1993)},
        };
    }
}
