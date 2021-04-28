using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_7_The_House
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToNewLocation(myRoom);
        }

        Location currentLocation;

        Outside street;
        OutsideWithDoor yard;
        OutsideWithDoor balcony;
        Room innaRoom;
        Room bathRoom;
        Room toilet;
        Room kitchen;
        Room parentsRoom;
        RoomWithDoor hallway;
        RoomWithDoor myRoom;

        void CreateObjects()
        {
            street = new Outside("the street", true);
            yard = new OutsideWithDoor("the yard", true, "a building with a heavy door");
            hallway = new RoomWithDoor("the hallway", "Mom's wallet", "a grey plywood door");
            parentsRoom = new Room("parents' room", "Dad's stash and a penknife");
            myRoom = new RoomWithDoor("my room", "a computer", "a screen door");
            balcony = new OutsideWithDoor("the balcony", false, "a screen door");
            innaRoom = new Room("Inna's room", "Inna");
            bathRoom = new Room("the bathroom", "towels and a hairspray can");
            toilet = new Room("the toilet Room", "some rock art");
            kitchen = new Room("the kitchen", "a sugar bowl");

            street.Exits = new Location[] { yard };
            yard.Exits = new Location[] { street };
            hallway.Exits = new Location[] { parentsRoom, myRoom, innaRoom, bathRoom, toilet, kitchen };
            parentsRoom.Exits = new Location[] { hallway };
            myRoom.Exits = new Location[] { hallway };
            balcony.Exits = new Location[] {  };
            innaRoom.Exits = new Location[] { hallway };
            bathRoom.Exits = new Location[] { hallway };
            toilet.Exits = new Location[] { hallway };
            kitchen.Exits = new Location[] { hallway };

            myRoom.DoorLocation = balcony;
            balcony.DoorLocation = myRoom;
            hallway.DoorLocation = yard;
            yard.DoorLocation = hallway;
        }

        void MoveToNewLocation(Location destination)
        {
            currentLocation = destination;

            exits.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
            {
                exits.Items.Add(exit.Name);
            }
            if (exits.Items.Count > 0)
                exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            if (currentLocation is IHasExterriorDoor)
            {
                goThroughDoor.Visible = true;
            }
            else
            {
                goThroughDoor.Visible = false;
            }
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
    }
}
