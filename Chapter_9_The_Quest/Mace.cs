using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location)
        {
        
        }

        public override string Name => "Mace";

        public override void Use(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 20, 6, random))
            {
                direction = CounterClockwise(direction);
                for (int i = 0; i < 3; i++)
                {
                    if (DamageEnemy(direction, 20, 6, random))
                    {
                        break;
                    }
                    direction = CounterClockwise(direction);
                }
            }
        }
    }
}