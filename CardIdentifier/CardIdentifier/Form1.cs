using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExit.Text = "Exit";
            lblText.Text = "Click a card to see its name";
            lblName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picDimond8_Click(object sender, EventArgs e)
        {
            lblName.Text = "Ten of Dimonds";
        }

        private void picClub2_Click(object sender, EventArgs e)
        {
            lblName.Text = "Duce of Clubs";
        }

        private void picSpadesKing_Click(object sender, EventArgs e)
        {
            lblName.Text = "King of Spades";
        }

        private void picSpadesAce_Click(object sender, EventArgs e)
        {
            lblName.Text = "Ace of Spades";
        }

        private void picJoker_Click(object sender, EventArgs e)
        {
            lblName.Text = "Just a Joker";
        }
    }
}
