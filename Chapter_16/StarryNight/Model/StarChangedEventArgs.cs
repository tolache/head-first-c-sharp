using System;

namespace StarryNight.Model
{
    public class StarChangedEventArgs : EventArgs
    {
        public Star StarThatChanged { get; }
        public bool Removed { get; }

        public StarChangedEventArgs(Star starThatChanged, bool removed)
        {
            StarThatChanged = starThatChanged;
            Removed = removed;
        }
    }
}