using System.Collections.ObjectModel;

namespace Chapter_15_Baseball_Simulator
{
    public class BaseballSimulator
    {
        private Ball ball = new Ball();
        private Pitcher pitcher;
        private Fan fan;

        public BaseballSimulator()
        {
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        public ObservableCollection<string> PitcherSays => pitcher.PitcherSays;
        public ObservableCollection<string> FanSays => fan.FanSays;
        public int Trajectory { get; set; }
        public int Distance { get; set; }

        public void PlayBall()
        {
            Bat bat = ball.GetNewBat();
            BallEventArgs ballEventArgs = new BallEventArgs(Trajectory, Distance);
            bat.HitTheBall(ballEventArgs);
        }
    }
}