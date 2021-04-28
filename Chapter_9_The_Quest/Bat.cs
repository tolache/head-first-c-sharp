using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {
            
        }

        public override void Move(Random random)
        {
            if (HitPoints <= 0) return;
            if (random.Next(2) == 0)
            {
                base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else
            {
                base.location = Move((Direction)random.Next(4), game.Boundaries);
            }
            
            if (NearPlayer())
            {
                game.DamagePlayer(2, random);
            }
        }
    }
}