using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_8_BMI_Enhancement
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            lblResult.Text = "";
            txtWeight.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double weight, height, BMI;

            try
            {
                weight = double.Parse(txtWeight.Text);
                height = double.Parse(txtHeight.Text);

                if ((weight >= 40 && weight <= 500) && (height >= 20 && height <= 108))
                {
                    BMI = BMICalc(weight, height);
                    if (BMI >= 18.5 && BMI <= 25)
                    {
                        lblResult.Text = BMI.ToString("0.00" + Environment.NewLine + "Your BMI is Optimal");
                    }

                    if (BMI < 18.5)
                    {
                        lblResult.Text = BMI.ToString("0.00" + Environment.NewLine + "Underweight");
                    }

                    if (BMI > 25)
                    {
                        lblResult.Text = BMI.ToString("0.00" + Environment.NewLine + "Overweight");

                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct Weight/Height range");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Enter a correct Value",ex.Message);
            }
           
        }

        private double BMICalc(double w, double h)
        {
            return w * 703 / (h*h);
        }
    }
}
