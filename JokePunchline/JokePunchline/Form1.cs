﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokePunchline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblText.Text = "";
            btnSetup.Text = "Setup";
            btnPunchline.Text = "Punchline";
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            lblText.Text = "What's the Object-Oriented way to become wealthy ?";
        }

        private void btnPunchline_Click(object sender, EventArgs e)
        {
            lblText.Text = "Inheritance";
        }
    }
}
