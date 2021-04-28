using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {
            
        }

        public override string Name => "Sword";

        public override void Use(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 10, 3, random))
            {
                if (!DamageEnemy(Clockwise(direction), 10, 3, random))
                {
                    DamageEnemy(CounterClockwise(direction), 10, 3, random);
                }
            }
        }
    }
}