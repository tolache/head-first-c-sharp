using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        
        public int HitPoints { get; private set; }

        public bool Dead
        {
            get
            {
                if (HitPoints <= 0) return true;
                return false;
            }
        }

        public Enemy(Game game, Point location, int hitPoints) : base(game, location)
        {
            HitPoints = hitPoints;
        }

        public abstract void Move(Random random);
        
        public void GetHit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
            {
                directionToMove = Direction.Right;
            }
            else if (playerLocation.X < location.X - 10)
            {
                directionToMove = Direction.Left;
            }
            else if (playerLocation.Y > location.Y + 10)
            {
                directionToMove = Direction.Down;
            }
            else
            {
                directionToMove = Direction.Up;
            }

            return directionToMove;
        }
    }
}