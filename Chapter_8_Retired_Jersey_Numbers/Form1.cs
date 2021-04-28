using System;
using System.Windows.Forms;

namespace Chapter_8_Retired_Jersey_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (int key in retiredNumbers.Keys) comboBox1.Items.Add(key);
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNumber = retiredNumbers[(int)comboBox1.SelectedItem];
            nameLabel.Text = jerseyNumber.Player;
            yearLabel.Text = jerseyNumber.YearRetired.ToString();
        }
    }
}
