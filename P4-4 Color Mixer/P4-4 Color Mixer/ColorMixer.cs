using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_4_Color_Mixer
{
    public partial class ColorMixer : Form
    {
        public ColorMixer()
        {
            InitializeComponent();
        }

        private void ColorMixer_Load(object sender, EventArgs e)
        {

        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            if (radioBlueLeft.Checked == true && radioBlueRight.Checked == true)
            {
                this.BackColor = Color.Blue;
            }

            if (radioRedLeft.Checked == true && radioRedRight.Checked == true)
            {
                this.BackColor = Color.Red;
            }

            if (radioYellowLeft.Checked == true && radioYellowRight.Checked == true)
            {
                this.BackColor = Color.Yellow;
            }

            if (radioRedLeft.Checked == true && radioBlueRight.Checked == true)
            {
                this.BackColor = Color.Purple;
            }

            if (radioRedLeft.Checked == true && radioYellowRight.Checked == true)
            {
                this.BackColor = Color.Orange;
            }

            if (radioBlueLeft.Checked == true && radioYellowRight.Checked == true)
            {
                this.BackColor = Color.Green;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            radioBlueLeft.Checked = false;
            radioBlueRight.Checked = false;
            radioRedLeft.Checked = false;
            radioYellowLeft.Checked = false;
            radioYellowRight.Checked = false;
            radioRedRight.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
