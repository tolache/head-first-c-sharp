using System;

namespace Chapter_13_SuperSoldierSerum
{
    sealed class OrdinaryHuman
    {
        private string name;
        private int age;
        private int weight;

        public OrdinaryHuman(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public string IntroduceSelf()
        {
            string introduction = $"Hi! My name is {name} and I am {age}.";
            if (weight < 99)
                introduction += $" I weigh {weight} kilos.";
            else
                introduction += " I don't like talking about my weight :(";
            return introduction;
        }
        
        public void Work()
        {
            // Make some money.
        }

        public void PayBills()
        {
            // Pay the bills.
        }
    }
}