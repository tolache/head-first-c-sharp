using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephants
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public class Elephant
        {
            public string Name;
            public int EarSize;

            public void WhoAmI()
            {
                MessageBox.Show("My ears are " + EarSize + " inches tall.", Name + " says...");
            }

            public void TellMe(string message, Elephant whoSaidIt)
            {
                MessageBox.Show(whoSaidIt.Name + " says: " + message);
            }

            public void SpeakTo(Elephant whoTalkTo, string message)
            {
                whoTalkTo.TellMe(message, this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void lloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void lucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void transcendSoulsButton_Click(object sender, EventArgs e)
        {
            Elephant soulPlaceholder;
            soulPlaceholder = lloyd;
            lloyd = lucinda;
            lucinda = soulPlaceholder;
            MessageBox.Show("Souls are transcended.");
        }

        private void fuckupButton_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "Hello.");
            lloyd.TellMe("Hi!", lucinda);
            lloyd = lucinda;
            lloyd.EarSize = 1488;
            lloyd.WhoAmI();
        }
    }
}
