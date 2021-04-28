using System;
using System.IO;

namespace Chapter_9_StreamRead_to_Bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream output = File.Create(@"C:\Temp\bytes.txt"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                byte[] byteArray = new byte[134];
                byte b = 120;
                for (byte i = 0; i < 134; i++)
                {
                    byteArray[i] = b;
                    b++;
                }
                writer.Write(byteArray);
            }

            using (StreamReader reader = new StreamReader(@"C:\Temp\bytes.txt"))
            using (StreamWriter writer = new StreamWriter(@"C:\Temp\hex.txt", false))
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
