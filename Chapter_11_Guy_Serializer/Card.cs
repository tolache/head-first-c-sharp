using System;
using System.Runtime.Serialization;

namespace Chapter_11_Guy_Serializer
{
    [DataContract(Namespace = "Chapter_11_Guy_Serializer")]
    public class Card
    {
        [DataMember]
        public Suits Suit { get; set; }
        
        [DataMember]
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        
        private static Random _random = new Random();

        public static Card RandomCard()
        {
            return new Card((Suits)_random.Next(4), (Values)_random.Next(1, 14));
        }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}