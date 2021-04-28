using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Chapter_9_Card_Serializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random random = new Random();

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }

            return myDeck;
        }

        private void DealCards(Deck deckToDeal, string title)
        {
            Console.Write(title);
            label1.Text += title + Environment.NewLine;
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
                label1.Text += nextCard.Name + Environment.NewLine;
            }
            Console.WriteLine("--------------------");
            label1.Text += "--------------------" + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);
            using (Stream output = File.Create(@"C:\Temp\Deck1.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(output, deckToWrite);
            }
            DealCards(deckToWrite, "What I just wrote to the file:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead(@"C:\Temp\Deck1.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Deck deckFromFile = (Deck) binaryFormatter.Deserialize(input);
                DealCards(deckFromFile, "What i read from the file:");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create(@"C:\Temp\Deck2.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    binaryFormatter.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, "Deck #" + i + " written:");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead(@"C:\Temp\Deck2.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToRead = (Deck) binaryFormatter.Deserialize(input);
                    DealCards(deckToRead, "Deck #" + i + " read:");
                }
            }
        }

        private void hexDump_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"C:\Temp\kingSpades.dat"))
            using (StreamWriter writer = new StreamWriter(@"C:\Temp\outputFile.dat", false))
            {
                int position = 0;

                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += charactersRead;

                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = String.Format("{0:x2}", (byte) buffer[i]);
                            writer.Write(hex + " ");
                        }
                        else
                        {
                            writer.Write(" ");
                        }
                        if (i == 7) { writer.Write("-- ");}

                        if (buffer[i] < 32 || buffer[i] > 250)
                        {
                            buffer[i] = '.';
                        }
                    }
                    string bufferContents = new string(buffer);
                    writer.WriteLine(" " + bufferContents.Substring(0, charactersRead));
                }
            }

            using (StreamReader reader = new StreamReader(@"C:\Temp\testfile.dat"))
            using (StreamWriter writer = new StreamWriter(@"C:\Temp\outputFile2.dat", false))
            {
                int position = 0;

                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += charactersRead;

                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = String.Format("{0:x2}", (byte) buffer[i]);
                            writer.Write(hex + " ");
                        }
                        else
                        {
                            writer.Write(" ");
                        }
                        if (i == 7) { writer.Write("-- ");}

                        if (buffer[i] < 32 || buffer[i] > 250)
                        {
                            buffer[i] = '.';
                        }
                    }
                    string bufferContents = new string(buffer);
                    writer.WriteLine(" " + bufferContents.Substring(0, charactersRead));
                }
            }
        }
    }
}
