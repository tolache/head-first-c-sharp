namespace Chapter_15_Baseball_Simulator
{
    public delegate void BatCallback(BallEventArgs e);
    
    public class Bat
    {
        private BatCallback hitBallCallback;

        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCallback = new BatCallback(callbackDelegate);
        }

        public void HitTheBall(BallEventArgs e)
        {
            hitBallCallback?.Invoke(e);
        }
    }
}