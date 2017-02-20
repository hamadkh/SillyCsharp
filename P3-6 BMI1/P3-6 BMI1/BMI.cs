using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_6_BMI
{
    public partial class BMI : Form
    {
        private const int converFactor = 703;

        public BMI()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            txtBMI.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtWeight.Select();
        }

        private double BMIcalc(double height, double weight)
        {
            return converFactor* (weight/ (height*height));
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double weight, height, BMI;

            try
            {
                weight = double.Parse(txtWeight.Text);
                height = double.Parse(txtHeight.Text);
                BMI = BMIcalc(height, weight);
                txtBMI.Text = BMI.ToString("0.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a proper value", ex.Message);
                if (!double.TryParse(txtHeight.Text, out height))
                {
                    txtHeight.Select();
                    return;
                }

                else if (!double.TryParse(txtWeight.Text, out weight))
                {
                    txtWeight.Select();
                    return;
                }
            }
        }

        private void BMI_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnCalc;
            this.CancelButton = this.btnExit;
        }
    }
}
