using System.Drawing;

namespace StarryNight.Model
{
    public class Star
    {
        public Point Location { get; set; }

        public Star(Point location)
        {
            Location = location;
        }

        // TODO: Rotating stars
        // Once you get your program working,
        // try adding a Boolean Rotating
        // property to the Star class and use it
        // to make some of your stars slowly spin
        // around.
    }
}