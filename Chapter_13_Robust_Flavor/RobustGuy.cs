using System;

namespace DefaultNamespace
{
    public class RobustGuy
    {
        public DateTime? BirthDay { get; private set; }
        public int? Height { get; private set; }

        public RobustGuy(string birthday, string height)
        {
            DateTime tempDate;
            if (DateTime.TryParse(birthday, out tempDate))
                BirthDay = tempDate;
            else
                BirthDay = null;

            int tempInt;
            if (int.TryParse(height, out tempInt))
                Height = tempInt;
            else
                Height = null;
        }

        public override string ToString()
        {
            string description;
            if (BirthDay.HasValue)
                description = "I was born on " + BirthDay.Value.ToLongDateString();
            else
                description = "I don't know my birthday";
            if (Height.HasValue)
                description += " and I'm " + Height + " centimeters tall.";
            else
                description += "I don't know my height :(";
            return description;
        }
    }
}