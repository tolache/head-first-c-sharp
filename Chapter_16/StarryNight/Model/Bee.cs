using System.Drawing;

namespace StarryNight.Model
{
    public class Bee
    {
        public Point Location { get; set; }
        public Size Size { get; }
        public Rectangle Position => new Rectangle(Location, Size);
        public double Width => Position.Width;
        public double Height => Position.Height;

        public Bee(Point location, Size size)
        {
            Location = location;
            Size = size;
        }
    }
}