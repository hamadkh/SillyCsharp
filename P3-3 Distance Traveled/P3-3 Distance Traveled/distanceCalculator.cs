using System;
using System.Windows.Forms;

namespace P3_3_Distance_Traveled
{
    public partial class distanceCalculator : Form
    {
        public distanceCalculator()
        {
            InitializeComponent();
        }

        private void distanceCalculator_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnCal;
            this.CancelButton = this.btnExit;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double speed, hours,distance;

            try
            {
                speed = double.Parse(txtMiles.Text);
                hours = double.Parse(txtHours.Text);


                distance = distanceCalc(speed, hours);

                txtTotal.Text = distance.ToString("0.0");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a proper value", ex.Message);
                if (!double.TryParse(txtHours.Text, out hours))
                {
                    txtHours.Select();
                    return;
                }
                
                 else if (!double.TryParse(txtMiles.Text, out speed))
                    {
                        txtMiles.Select();
                        return;
                    }
                
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtMiles.Text = "";
            txtTotal.Text = "";
        }

        double distanceCalc(double speed, double hours)
        {
            return speed * hours;
        }
    }
}
