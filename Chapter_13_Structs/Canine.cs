using System;

namespace Chapter_13_Structs
{
    public class Canine
    {
        public string Name;
        public string Breed;

        public Canine(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("My name is {0} and I'm {1}.", Name, Breed);
        }
    }
}