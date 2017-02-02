using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblText.Text = "English Translation:";
            lblTranslation.Text = "";
            btnSinister.Text = "sinister";
            btnDexter.Text = "dexter";
            btnMedium.Text = "medium";
        }

        private void btnSinister_Click(object sender, EventArgs e)
        {
            reset();
            lblTranslation.Text = "sinister";
            btnSinister.BackColor = Color.Orange;
        }

        private void btnDexter_Click(object sender, EventArgs e)
        {
            reset();
            lblTranslation.Text = "right";
            btnDexter.BackColor = Color.Orange;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            reset();
            lblTranslation.Text = "medium";
            btnMedium.BackColor = Color.Orange;
        }

        private void reset()
        {
            btnSinister.BackColor = default(Color);
            btnDexter.BackColor = default(Color);
            btnMedium.BackColor = default(Color);
            lblTranslation.Text = "";
        }
    }
}
