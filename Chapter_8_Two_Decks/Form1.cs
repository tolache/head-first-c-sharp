using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter_8_Two_Decks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        Random random = new Random();
        List<Card> cards;
        Deck deck1;
        Deck deck2;
        
        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                cards = new List<Card>();
                int count = random.Next(1, 11);
                for (int i = 0; i < count; i++)
                    cards.Add(new Card((Suits)random.Next(0,4), (Values)random.Next(1,14)));
                deck1 = new Deck(cards);
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
        }

        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                listBox1.Items.Clear();
                foreach (string cardname in deck1.GetCardNames())
                {
                    listBox1.Items.Add(cardname);
                }
                label1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string cardname in deck2.GetCardNames())
                {
                    listBox2.Items.Add(cardname);
                }
                label2.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }
        
        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            int indexToMove = listBox1.SelectedIndex;
            Card movedCard = deck1.Deal(indexToMove);
            deck2.Add(movedCard);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < 0) return;
            int indexToMove = listBox2.SelectedIndex;
            Card movedCard = deck2.Deal(indexToMove);
            deck1.Add(movedCard);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }
        
        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }
        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }
    }
}