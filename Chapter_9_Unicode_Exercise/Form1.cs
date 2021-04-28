using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9_Unicode_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Temp\eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes(@"C:\Temp\Eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0} ", b);
            }
            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Temp\eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes(@"C:\Temp\Eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Temp\eureka.txt", "שלום", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes(@"C:\Temp\Eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine();
        }

        
    }
}