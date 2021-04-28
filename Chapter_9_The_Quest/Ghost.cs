using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {
            
        }

        public override void Move(Random random)
        {
            if (HitPoints <= 0) return;
            if (random.Next(3) == 0)
            {
                base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            
            if (NearPlayer())
            {
                game.DamagePlayer(3, random);
            }
        }
    }
}