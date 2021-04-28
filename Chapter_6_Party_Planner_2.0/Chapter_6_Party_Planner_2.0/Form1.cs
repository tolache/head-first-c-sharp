using System;
using System.Windows.Forms;

namespace Chapter_6_Party_Planner_2._0
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, fancyCheckBox.Checked, healthyCheckBox.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeTextBox.Text);
            DisplayBirthdayPartyCost();
        }

        // Dinner Party methods
        private void DisplayDinnerPartyCost()
        {
            costLabel.Text = dinnerParty.Cost.ToString("C");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyCheckBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyCheckBox.Checked;
            DisplayDinnerPartyCost();
        }

        // Birthday Party methods
        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            costBirthday.Text = birthdayParty.Cost.ToString("C");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeTextBox_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeTextBox.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
