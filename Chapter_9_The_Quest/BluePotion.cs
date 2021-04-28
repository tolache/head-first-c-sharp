using System;
using System.Drawing;

namespace Chapter_9_The_Quest
{
    class BluePotion : Weapon, IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }
        
        public override string Name => "Blue Potion";

        public override void Use(Direction direction, Random random)
        {
            game.HealPlayer(5, random);
            Used = true;
        }

        public bool Used { get; private set; }
    }
}