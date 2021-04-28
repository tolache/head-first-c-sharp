using System;

namespace Chapter_7_Program_2
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThing) : base(funnyThingIHave)
        {
            this.numberOfScaryThing = numberOfScaryThing;
        }

        private int numberOfScaryThing;
        public string ScaryThingIHave
        {
            get
            {
                return "I have " + numberOfScaryThing + " spiders";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("You can't have my " + funnyThingIHave);
        }
    }
}
