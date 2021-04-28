using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location) : base(game, location)
        {
            
        }
        
        public override string Name => "Bow";

        public override void Use(Direction direction, Random random)
        {
            DamageEnemy(direction, 30, 1, random);
        }
    }
}