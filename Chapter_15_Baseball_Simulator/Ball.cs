using System;

namespace Chapter_15_Baseball_Simulator
{
    public class Ball
    {
        public event EventHandler<BallEventArgs> BallInPlay;

        protected void OnBallInPlay(BallEventArgs e)
        {
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            ballInPlay?.Invoke(this, e);
        }

        public Bat GetNewBat()
        {
            return new Bat(OnBallInPlay);
        }                                  
    }
}