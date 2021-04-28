using System;
using System.Windows.Forms;

namespace Chapter_7_Hide_and_Seek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            currentLocation = myRoom;
        }

        Opponent opponent;

        Location currentLocation;

        OutsideWithHidingPlace street;
        OutsideWithDoor yard;
        OutsideWithDoor balcony;
        Room innaRoom;
        Room bathRoom;
        Room toilet;
        Room kitchen;
        Room parentsRoom;
        RoomWithDoor hallway;
        RoomWithDoor myRoom;
        RoomWithDoor outerHallway;
        RoomWithDoor lowerHallway;
        Room stairCase;
        OutsideWithHidingPlace parking;

        void CreateObjects()
        {
            street = new OutsideWithHidingPlace("the street", true, "in Hachik's store");
            yard = new OutsideWithDoor("the yard", true, "a building with a heavy door");
            hallway = new RoomWithDoor("the hallway", "Mom's wallet", "in the closet", "a grey plywood door");
            parentsRoom = new Room("parents' room", "Dad's stash and a penknife");
            myRoom = new RoomWithDoor("my room", "a computer", "under the bed", "a screen door");
            balcony = new OutsideWithDoor("the balcony", false, "a screen door");
            innaRoom = new Room("Inna's room", "Inna");
            bathRoom = new Room("the bathroom", "towels and a hairspray can");
            toilet = new Room("the toilet Room", "some rock art");
            kitchen = new Room("the kitchen", "a sugar bowl");
            outerHallway = new RoomWithDoor("the outer hallway on 11th floor", "apartment front doors and elevators", "in the trash chute room", "a wooden slat door №183");
            stairCase = new Room("the staircase", "iron banister");
            lowerHallway = new RoomWithDoor("the lower hallway", "steel mailboxes and elevators", "under the staircase", "a painted steel door");
            parking = new OutsideWithHidingPlace("the parking lot", true, "behind the transformer box");

            street.Exits = new Location[] { yard, parking };
            yard.Exits = new Location[] { street, parking };
            hallway.Exits = new Location[] { parentsRoom, myRoom, innaRoom, bathRoom, toilet, kitchen, outerHallway };
            parentsRoom.Exits = new Location[] { hallway };
            myRoom.Exits = new Location[] { hallway };
            balcony.Exits = new Location[] { street };
            innaRoom.Exits = new Location[] { hallway };
            bathRoom.Exits = new Location[] { hallway };
            toilet.Exits = new Location[] { hallway };
            kitchen.Exits = new Location[] { hallway };
            outerHallway.Exits = new Location[] { lowerHallway, stairCase };
            stairCase.Exits = new Location[] { lowerHallway };
            lowerHallway.Exits = new Location[] { outerHallway, stairCase };
            parking.Exits = new Location[] { yard, street };

            myRoom.DoorLocation = balcony;
            balcony.DoorLocation = myRoom;
            hallway.DoorLocation = outerHallway;
            outerHallway.DoorLocation = hallway;
            yard.DoorLocation = lowerHallway;
            lowerHallway.DoorLocation = yard;
        }

        void MoveToNewLocation(Location destination)
        {
            currentLocation = destination;

            exits.Items.Clear();
            foreach (Location exit in currentLocation.Exits) exits.Items.Add(exit.Name);
            if (exits.Items.Count > 0) exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            if (currentLocation is IHasExterriorDoor) goThroughDoor.Visible = true;
            else goThroughDoor.Visible = false;

            if (currentLocation is IHidingPlace)
            {
                check.Visible = true;
                IHidingPlace locWithHidingPlace = currentLocation as IHidingPlace;
                check.Text = "Check " + locWithHidingPlace.HidingPlaceName;
            }
            else check.Visible = false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExterriorDoor locationWithDoor = currentLocation as IHasExterriorDoor;
            MoveToNewLocation(locationWithDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (opponent == null) MessageBox.Show("Opponent hasn't hidden yet!", "Error");
            else if (opponent.Check(currentLocation))
            {
                MessageBox.Show("I've found the opponent", "Victory!");
                resetGame();
            }
            else description.Text += "\n\nThe opponent isn't here.";
        }

        private void resetGame()
        {
            opponent = null;
            hide.Visible = true;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            opponent = new Opponent(currentLocation);
            hide.Visible = false;
            for (int count = 1; count < 10; count++)
            {
                description.Text += count + "\r\n";
                Application.DoEvents();
                opponent.Move();
                System.Threading.Thread.Sleep(200);
            }
            description.Text += " Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(750);

            MoveToNewLocation(currentLocation);
            goHere.Visible = true;
            exits.Visible = true;
        }
    }
}