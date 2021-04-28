using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }

        public void Loot()
        {
            PickedUp = true;
        }
        
        public abstract string Name { get; }
        public abstract void Use(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point weaponLocation = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(weaponLocation, enemy.Location, distance))
                    {
                        enemy.GetHit(damage, random);
                        return true;
                    }
                }

                weaponLocation = Move(weaponLocation, direction, game.Boundaries);
            }

            return false;
        }
        
        private bool Nearby(Point weaponLocation, Point enemyLocation, int distance)
        {
            location = weaponLocation;
            return  base.Nearby(enemyLocation, distance);
        }
        
        private Point Move(Point weaponLocation, Direction direction, Rectangle boundaries)
        {
            location = weaponLocation;
            return Move(direction, boundaries);
        }

        protected Direction Clockwise(Direction originalDirection)
        {
            return (Direction)MathMod((int)originalDirection + 1, 4);
        }
        
        protected Direction CounterClockwise(Direction originalDirection)
        {
            return (Direction)MathMod((int)originalDirection - 1, 4);
        }
        
        private int MathMod(int argument, int modulo)
        {
            return (Math.Abs(argument * modulo) + argument) % modulo;
        }
    }
}