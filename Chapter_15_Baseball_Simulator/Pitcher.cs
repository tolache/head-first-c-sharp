using System;
using System.Collections.ObjectModel;

namespace Chapter_15_Baseball_Simulator
{
    public class Pitcher
    {
        private int pitchNumber = 0;
        
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
            PitcherSays = new ObservableCollection<string>();
        }
        
        public ObservableCollection<string> PitcherSays { get; }

        private void ball_BallInPlay(object? sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                pitchNumber++;
                if (ballEventArgs.Distance < 95 && ballEventArgs.Trajectory < 60)
                {
                    CatchBall();
                }
                else
                {
                    CoverFirstBase();
                }
            }
        }

        private void CatchBall()
        {
            PitcherSays.Add($"Pitch #{pitchNumber}: I've caught the ball.");
        }

        private void CoverFirstBase()
        {
            PitcherSays.Add($"Pitch #{pitchNumber}: I've covered first base.");
        }
    }
}