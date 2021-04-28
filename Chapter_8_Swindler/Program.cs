using System;
using System.IO;

namespace Chapter_8_Swindler
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter writer = new StreamWriter(folder + @"\secretPlan.txt");
            writer.WriteLine("How I'll defeat Captain Lame");
            writer.WriteLine("Another genius secret plan by The Swindler");
            writer.Write("I'll create an army of clones and ");
            writer.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            for (int number = 0; number <= 6; number++)
            {
                writer.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall")
                {
                    location = "downtown";
                }
                else
                {
                    location = "the mall";
                }
            }
            writer.Close();
            
            StreamReader reader = new StreamReader(folder + @"\secretPlan.txt");
            writer = new StreamWriter(folder + @"\emailToCaptainLame.txt");
            
            writer.WriteLine("To: CaptainLame@objectville.net");
            writer.WriteLine("From: Commissioner@objectviile.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We've discovered then Swindler's plan:");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();
        }
    }
}