using System;
using System.Collections.Generic;

namespace Chapter_8_Cards_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            CardComparer comparer = new CardComparer();
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Values)random.Next(13), (Suits)random.Next(4)));
            }

            PrintCards(cards);
            cards.Sort(comparer);
            Console.WriteLine("\nSame cards, sorted:");
            PrintCards(cards);
            Console.ReadKey();
        }

        static void PrintCards(List<Card> cards)
        {
            foreach (Card c in cards)
            {
                Console.WriteLine(c.Name);
            }
            Console.WriteLine("End of cards!\n");
        }
    }
}