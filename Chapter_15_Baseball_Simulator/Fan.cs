using System;
using System.Collections.ObjectModel;

namespace Chapter_15_Baseball_Simulator
{
    public class Fan
    {
        private int pitchNumber = 0;
        
        public Fan(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
            FanSays = new ObservableCollection<string>();
        }
        
        public ObservableCollection<string> FanSays { get; }

        private void ball_BallInPlay(object? sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                pitchNumber++;
                if (ballEventArgs.Distance > 400 && ballEventArgs.Trajectory > 30)
                {
                    CatchBall();
                }
                else
                {
                    Yell();
                }
            }
        }

        private void Yell()
        {
            FanSays.Add($"Pitch #{pitchNumber}: Woo-hoo! Yeah!");
        }

        private void CatchBall()
        {
            FanSays.Add($"Pitch #{pitchNumber}: Home run! I'm going for the ball!");
        }
    }
}