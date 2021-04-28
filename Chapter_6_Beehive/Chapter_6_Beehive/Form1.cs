﻿using System.Windows.Forms;

namespace Chapter_6_Beehive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            workerBeejob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collection", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collection", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }

        private Queen queen;

        private void assignJob_Click(object sender, System.EventArgs e)
        {
            if (queen.AssignWork(workerBeejob.Text, (int)shifts.Value))
            {
                MessageBox.Show("'The job " + workerBeejob.Text + " will be done in " + shifts.Value + " shifts', the Queen Bee says...");
            }
            else
            {
                MessageBox.Show("'No workers are available to do this job', the Queen Bee says...");
            }
        }

        private void nextShift_Click(object sender, System.EventArgs e)
        {
            report.Text = queen.WorkNextShift();
        }
    }
}
