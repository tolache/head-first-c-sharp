using System;

namespace Chapter_7_Program_2
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        protected string funnyThingIHave;
        public string FunnyThingIHave
        { get
            {
                return "Hi kids! I have " + funnyThingIHave;
            }
        }

        public void Honk()
        {
            Console.WriteLine(FunnyThingIHave);
        }
    }
}
