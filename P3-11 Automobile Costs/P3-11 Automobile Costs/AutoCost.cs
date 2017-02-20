using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_11_Automobile_Costs
{
    public partial class AutoCost : Form
    {
        public AutoCost()
        {
            InitializeComponent();
        }

        private void AutoCost_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnCalc;
            this.CancelButton = this.btnExit;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAnnualTotal.Text = "";
            txtGas.Text = "";
            txtInsurance.Text = "";
            txtLoan.Text = "";
            txtMaintenance.Text = "";
            txtMonthlyTotal.Text = "";
            txtOil.Text = "";
            txtTires.Text = "";

            txtLoan.Select(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double Cost(double loan, double insurance, double gas, double oil, double tires, double maintenance)
        {

            return loan + insurance + gas + oil + tires + maintenance;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double loan, insurance,gas, oil, tires, maintenance, monthlyTotal, annualTotal;

            try
            {
                loan = double.Parse(txtLoan.Text);
                insurance = double.Parse(txtInsurance.Text);
                gas = double.Parse(txtGas.Text);
                oil = double.Parse(txtOil.Text);
                tires = double.Parse(txtTires.Text);
                maintenance = double.Parse(txtMaintenance.Text);

                monthlyTotal = Cost(loan, insurance, gas, oil, tires, maintenance);
                annualTotal = 12*Cost(loan, insurance, gas, oil, tires, maintenance);

                txtMonthlyTotal.Text = monthlyTotal.ToString("#.##");
                txtAnnualTotal.Text = annualTotal.ToString("#.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a proper value", ex.Message);
                if (!double.TryParse(txtGas.Text, out gas))
                {
                    txtGas.Select();
                    return;
                }

                if (!double.TryParse(txtInsurance.Text, out insurance))
                {
                    txtInsurance.Select();
                    return;
                }

                if (!double.TryParse(txtLoan.Text, out loan))
                {
                    txtLoan.Select();
                    return;
                }

                if (!double.TryParse(txtMaintenance.Text, out maintenance))
                {
                    txtMaintenance.Select();
                    return;
                }

                if (!double.TryParse(txtOil.Text, out oil))
                {
                    txtOil.Select();
                    return;
                }

                if (!double.TryParse(txtTires.Text, out tires))
                {
                    txtTires.Select();
                    return;
                }
            }
        }
    }
}
