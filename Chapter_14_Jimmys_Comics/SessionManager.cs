using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Chapter_14_Jimmys_Comics
{
    public class SessionManager
    {
        private const string filename = "_sessionState.txt";
        
        public static string CurrentQuery { get; set; }

        public static async Task SaveAsync()
        {
            if (String.IsNullOrEmpty(CurrentQuery))
                CurrentQuery = String.Empty;

            try
            {
                await using StreamWriter writer = new StreamWriter(filename, false);
                await writer.WriteAsync(CurrentQuery);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public static async Task LoadAsync()
        {
            try
            {
                using var reader = new StreamReader(filename);
                CurrentQuery = await reader.ReadToEndAsync();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"{filename} not found. Stacktrace:");
                Console.WriteLine(e.ToString());
            }
        }
    }
}