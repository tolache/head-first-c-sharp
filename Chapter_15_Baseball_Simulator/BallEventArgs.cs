using System;

namespace Chapter_15_Baseball_Simulator
{
    public class BallEventArgs : EventArgs
    {
        public int Trajectory { get; }
        public int Distance { get; }

        public BallEventArgs(int trajectory, int distance)
        {
            Trajectory = trajectory;
            Distance = distance;
        }
    }
}