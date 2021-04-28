using System;

namespace Chapter_8_Cards_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesMatch = Card.CardMatches(cardToCheck, Suits.Hearts);
            Console.WriteLine(doesMatch);
            doesMatch = Card.CardMatches(cardToCheck, Values.Three);
            Console.WriteLine(doesMatch);
            
            Console.ReadKey();
        }
    }
}