using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter_13_Finalizers
{
    [Serializable]
    public class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }
        
        public void Dispose()
        {
            string filename = @"C:\Temp\Clone.dat";
            string dirname = @"C:\Temp";
            if (File.Exists(filename) == false)
            {
                Directory.CreateDirectory(dirname);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }
            MessageBox.Show("I've been disposed", "Clone #" + Id + " says...");
        }

        ~Clone()
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Aaargh! You got me!", "Clone #" + Id + " says...");
            }
        }
    }
}