using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter_9_Excuse_Manager
{
    [Serializable]
    public class Excuse
    {
        public Excuse()
        {
            ExcusePath = "";
        }
        
        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }
        
        public Excuse(Random random, string folder)
        {
            string[] files = Directory.GetFiles(folder);
            string filePath = files[random.Next(files.Length)];
            OpenFile(filePath);
        }
        
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public void OpenFile(string filePath)
        {
            using (Stream input = File.OpenRead(filePath))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Excuse excuseFromFile = (Excuse) binaryFormatter.Deserialize(input);
                Description = excuseFromFile.Description;
                Results = excuseFromFile.Results;
                LastUsed = excuseFromFile.LastUsed;
                ExcusePath = filePath;
            }
        }

        public void Save(string filePath)
        {
            using (FileStream output = new FileInfo(filePath).Create())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(output, this);
            }
        }
    }
}