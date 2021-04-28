using System;

namespace StarryNight.Model
{
    public class BeeMovedEventArgs : EventArgs
    {
        public Bee BeeThatMoved { get; }
        public double X { get; }
        public double Y { get; }

        public BeeMovedEventArgs(Bee beeThatMoved, double x, double y)
        {
            BeeThatMoved = beeThatMoved;
            X = x;
            Y = y;
        }
    }
}