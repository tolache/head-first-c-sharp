using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTravelled;
        double reimburseRate = .39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)startingMileageNumeric.Value;
            endingMileage = (int)endingMileageNumeric.Value;
            
            if (startingMileage < endingMileage)
            {
                milesTravelled = endingMileage - startingMileage;
                amountOwed = milesTravelled * reimburseRate;
                resultLabel.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage","Cannot Calculate Mileage :(");
            }
        }

        private void displayMilesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTravelled + " miles", "Miles Travelled");
        }
    }
}
