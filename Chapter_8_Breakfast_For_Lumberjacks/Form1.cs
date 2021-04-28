using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8_Breakfast_For_Lumberjacks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RedrawForm();
        }

        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        private void RedrawForm()
        {
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks. ";
            }

            line. Items.Clear();
            foreach (var lumberjack in breakfastLine)
            {
                int position = line.Items.Count + 1;
                line.Items.Add(position + ". " + lumberjack.Name);
            }
            name.Text = "";
        }
        
        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            RedrawForm();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Crispy;
            else if (soggy.Checked)
                food = Flapjack.Soggy;
            else if (browned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);

            RedrawForm();
        }
        
        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Peek().EatFlapjacks();
            breakfastLine.Dequeue();
            RedrawForm();
        }
        
        private void howMany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                addFlapjacks_Click(sender, e);
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                addLumberjack_Click(sender, e);
        }
    }
}