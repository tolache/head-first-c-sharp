using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter_9_Serialized_Data_Binary_IO
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (FileStream output = File.Create("threeClubs.dat"))
            {
                Card threeClubs = new Card(Suits.Clubs, Values.Three);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(output, threeClubs);
            }
            
            using (FileStream output = File.Create("sixHearts.dat"))
            {
                Card sixHearts = new Card(Suits.Hearts, Values.Six);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(output, sixHearts);
            }

            byte[] firstFile = File.ReadAllBytes("threeClubs.dat");
            byte[] secondFile = File.ReadAllBytes("sixHearts.dat");
            Console.WriteLine("File length is {0} bytes.", firstFile.Length);
            for (int i = 0; i < firstFile.Length; i++)
            {
                if (firstFile[i] != secondFile[i])
                {
                    Console.WriteLine("Byte #{0}: {1} vs {2}", i, firstFile[i], secondFile[i]);
                }
            }
            
            Console.WriteLine("Will create a new card now. Press any key to continue...");
            Console.ReadKey();
            
            firstFile[372] = (byte) Suits.Spades;
            firstFile[442] = (byte) Values.King;
            File.Delete("kingSpades.dat");
            File.WriteAllBytes("kingSpades.dat", firstFile);

            using (FileStream input = File.OpenRead("kingSpades.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Card cardFromFile = (Card) binaryFormatter.Deserialize(input);
                Console.WriteLine(cardFromFile.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
