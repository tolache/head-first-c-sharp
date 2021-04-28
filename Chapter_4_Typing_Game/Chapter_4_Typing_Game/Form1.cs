﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Typing_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("W A S T E D");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains("W A S T E D"))
            {
                listBox1.Items.Clear();
                stats.Reset();
                correctLabel.Text = "Correct: 0";
                missedLabel.Text = "Missed: 0";
                totalLabel.Text = "Total: 0";
                accuracyLabel.Text = "Accuracy: 0%";
                difficultyProgressBar.Value = 0;
                timer1.Interval = 800;
                timer1.Start();
            }
            else
            {
                if (listBox1.Items.Contains(e.KeyCode))
                {
                    listBox1.Items.Remove(e.KeyCode);
                    listBox1.Refresh();
                    if (timer1.Interval > 400)
                        timer1.Interval -= 10;
                    if (timer1.Interval > 250)
                        timer1.Interval -= 7;
                    if (timer1.Interval > 100)
                        timer1.Interval -= 2;
                    difficultyProgressBar.Value = 800 - timer1.Interval;

                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }

                correctLabel.Text = "Correct: " + stats.Correct;
                missedLabel.Text = "Missed: " + stats.Missed;
                totalLabel.Text = "Total: " + stats.Total;
                accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            }
        }
    }

    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {
            Total++;

            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / (Missed + Correct);
        }

        public void Reset()
        {
            Total = 0;
            Missed = 0;
            Correct = 0;
            Accuracy = 0;
        }
    }
}
