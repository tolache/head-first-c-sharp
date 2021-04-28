using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {
            
        }

        public override void Move(Random random)
        {
            if (HitPoints <= 0) return;
            if (random.Next(3) != 0)
            {
                base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            
            if (NearPlayer())
            {
                game.DamagePlayer(4, random);
            }
        }
    }
}