using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_5_Party_Planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyCheckBox.Checked, fancyCheckBox.Checked);
            DisplayPartyCost();
        }

        private void DisplayPartyCost()
        {
            costLabel.Text = dinnerParty.Cost.ToString("C");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayPartyCost();
        }

        private void fancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyCheckBox.Checked;
            DisplayPartyCost();
        }

        private void healthyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyCheckBox.Checked;
            DisplayPartyCost();
        }
    }
}
