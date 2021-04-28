namespace Chapter_13_MyExtensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            string message = "Clones are wreaking havoc at the factory. Help!";
            bool messageIsDistressCall = message.IsDistressCall();
        }
    }
}