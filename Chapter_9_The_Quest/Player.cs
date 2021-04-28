using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Chapter_9_The_Quest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        private List<Weapon> inventory = new List<Weapon>();

       public int HitPoints { get; private set; }
       
        public IEnumerable<string> WeaponNames
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }

                return names;
            }
        }
        
        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }

        public void GetHit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void Heal(int health, Random random)
        {
            HitPoints += random.Next(1, health + 1);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 15))
                {
                    PickUpWeapon();
                }
            }
        }

        private void PickUpWeapon()
        {
            game.WeaponInRoom.Loot();
            inventory.Add(game.WeaponInRoom);
            if (equippedWeapon == null)
            {
                Equip(game.WeaponInRoom.Name);
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon == null) return;
            else
            {
                equippedWeapon.Use(direction, random);
                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    Equip(WeaponNames.Last());
                }
            }
        }
    }
}