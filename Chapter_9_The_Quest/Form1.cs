using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chapter_9_The_Quest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;
        private Random random = new Random();
        private string lastUsedWeapon;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(74, 55, 452 - playerDungeonIcon.Width, 190 - playerDungeonIcon.Height));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            playerDungeonIcon.Location = game.PlayerLocation;
            playerDungeonIcon.BringToFront();
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batDungeonIcon.Visible = true;
                    batDungeonIcon.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghost)
                {
                    ghostDungeonIcon.Visible = true;
                    ghostDungeonIcon.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghoul)
                {
                    ghoulDungeonIcon.Visible = true;
                    ghoulDungeonIcon.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (!showBat)
            {
                batDungeonIcon.Visible = false;
                batHitPoints.Text = "";
            }

            if (!showGhost)
            {
                ghostDungeonIcon.Visible = false;
                ghostHitPoints.Text = "";
            }

            if (!showGhoul)
            {
                ghoulDungeonIcon.Visible = false;
                ghoulHitPoints.Text = "";
            }

            swordDungeonIcon.Visible = false;
            bowDungeonIcon.Visible = false;
            maceDungeonIcon.Visible = false;
            bluePotionDungeonIcon.Visible = false;
            redPotionDungeonIcon.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = swordDungeonIcon;
                    break;
                case "Bow":
                    weaponControl = bowDungeonIcon;
                    break;
                case "Mace":
                    weaponControl = maceDungeonIcon;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotionDungeonIcon;
                    break;
                case "Red Potion":
                    weaponControl = redPotionDungeonIcon;
                    break;
            }

            weaponControl.Visible = true;

            swordInventoryIcon.Visible = false;
            bowInventoryIcon.Visible = false;
            maceInventoryIcon.Visible = false;
            bluePotionInventoryIcon.Visible = false;
            redPotionInventoryIcon.Visible = false;

            foreach (string weaponName in game.PlayerWeapons)
            {
                switch (weaponName)
                {
                    case "Sword":
                        swordInventoryIcon.Visible = true;
                        break;
                    case "Bow":
                        bowInventoryIcon.Visible = true;
                        break;
                    case "Mace":
                        maceInventoryIcon.Visible = true;
                        break;
                    case "Blue Potion":
                        bluePotionInventoryIcon.Visible = true;
                        break;
                    case "Red Potion":
                        redPotionInventoryIcon.Visible = true;
                        break;
                }
            }

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died.", "Game Over");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level", "Congratulations!");
                game.NewLevel(random);
                if (game.Level < 8)
                {
                    this.Text = $"The Quest: Level {game.Level}";
                    UpdateCharacters();
                }
            }
        }

        private void swordInventoryIcon_Click(object sender, EventArgs e)
        {
            if (!game.CheckInventory("Sword")) return;
            lastUsedWeapon = "Sword";
            game.Equip("Sword");
            swordInventoryIcon.BorderStyle = BorderStyle.FixedSingle;
            bowInventoryIcon.BorderStyle = BorderStyle.None;
            maceInventoryIcon.BorderStyle = BorderStyle.None;
            bluePotionInventoryIcon.BorderStyle = BorderStyle.None;
            redPotionInventoryIcon.BorderStyle = BorderStyle.None;
            attackButtons.Visible = true;
            attackUp.Visible = true;
            attackDown.Visible = true;
            attackLeft.Visible = true;
            attackRight.Visible = true;
            drink.Visible = false;

        }

        private void bowInventoryIcon_Click(object sender, EventArgs e)
        {
            if (!game.CheckInventory("Bow")) return;
            lastUsedWeapon = "Bow";
            game.Equip("Bow");
            swordInventoryIcon.BorderStyle = BorderStyle.None;
            bowInventoryIcon.BorderStyle = BorderStyle.FixedSingle;
            maceInventoryIcon.BorderStyle = BorderStyle.None;
            bluePotionInventoryIcon.BorderStyle = BorderStyle.None;
            redPotionInventoryIcon.BorderStyle = BorderStyle.None;
            attackButtons.Visible = true;
            attackUp.Visible = true;
            attackDown.Visible = true;
            attackLeft.Visible = true;
            attackRight.Visible = true;
            drink.Visible = false;
        }

        private void maceInventoryIcon_Click(object sender, EventArgs e)
        {
            if (!game.CheckInventory("Mace")) return;
            lastUsedWeapon = "Mace";
            game.Equip("Mace");
            swordInventoryIcon.BorderStyle = BorderStyle.None;
            bowInventoryIcon.BorderStyle = BorderStyle.None;
            maceInventoryIcon.BorderStyle = BorderStyle.FixedSingle;
            bluePotionInventoryIcon.BorderStyle = BorderStyle.None;
            redPotionInventoryIcon.BorderStyle = BorderStyle.None;
            attackButtons.Visible = true;
            attackUp.Visible = true;
            attackDown.Visible = true;
            attackLeft.Visible = true;
            attackRight.Visible = true;
            drink.Visible = false;
        }

        private void bluePotionInventoryIcon_Click(object sender, EventArgs e)
        {
            if (!game.CheckInventory("Blue Potion")) return;
            game.Equip("Blue Potion");
            swordInventoryIcon.BorderStyle = BorderStyle.None;
            bowInventoryIcon.BorderStyle = BorderStyle.None;
            maceInventoryIcon.BorderStyle = BorderStyle.None;
            bluePotionInventoryIcon.BorderStyle = BorderStyle.FixedSingle;
            redPotionInventoryIcon.BorderStyle = BorderStyle.None;
            attackButtons.Visible = true;
            attackUp.Visible = false;
            attackDown.Visible = false;
            attackLeft.Visible = false;
            attackRight.Visible = false;
            drink.Visible = true;
        }

        private void redPotionInventoryIcon_Click(object sender, EventArgs e)
        {
            if (!game.CheckInventory("Red Potion")) return;
            game.Equip("Red Potion");
            swordInventoryIcon.BorderStyle = BorderStyle.None;
            bowInventoryIcon.BorderStyle = BorderStyle.None;
            maceInventoryIcon.BorderStyle = BorderStyle.None;
            bluePotionInventoryIcon.BorderStyle = BorderStyle.None;
            redPotionInventoryIcon.BorderStyle = BorderStyle.FixedSingle;
            attackButtons.Visible = true;
            attackUp.Visible = false;
            attackDown.Visible = false;
            attackLeft.Visible = false;
            attackRight.Visible = false;
            drink.Visible = true;
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void drink_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            switch (lastUsedWeapon)
            {
                case "Sword":
                    swordInventoryIcon_Click(sender, e);
                    break;
                case "Bow":
                    bowInventoryIcon_Click(sender, e);
                    break;
                case "Mace":
                    maceInventoryIcon_Click(sender, e);
                    break;
                default:
                    swordInventoryIcon_Click(sender, e);
                    break;
            }
            UpdateCharacters();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    moveUp_Click(sender, e);
                    break;
                case Keys.A:
                    moveLeft_Click(sender, e);
                    break;
                case Keys.S:
                    moveDown_Click(sender, e);
                    break;
                case Keys.D:
                    moveRight_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    attackUp_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    attackLeft_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    attackDown_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    attackRight_Click(sender, e);
                    break;
            }
        }
    }
}
