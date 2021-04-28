using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }
        
        public override string Name => "Red Potion";

        public override void Use(Direction direction, Random random)
        {
            game.HealPlayer(10, random);
            Used = true;
        }

        public bool Used { get; private set; }
    }
}