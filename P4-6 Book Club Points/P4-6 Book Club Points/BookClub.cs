using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_6_Book_Club_Points
{
    public partial class BookClub : Form
    {
        public BookClub()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBooks.Text = "";
            txtPoints.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int numberBooks;
            int tpoints=0;

            try
            {
                numberBooks = int.Parse(txtBooks.Text);
                if (numberBooks >= 0)
                {
                    if (numberBooks == 0)
                    {
                        tpoints = 0;
                    }

                    if (numberBooks == 1)
                    {
                        tpoints = 5;
                    }

                    if (numberBooks == 2)
                    {
                        tpoints = 15;
                    }

                    if (numberBooks == 3)
                    {
                        tpoints = 30;
                    }

                    if (numberBooks >= 4)
                    {
                        tpoints = 60;
                    }
                    txtPoints.Text = tpoints.ToString();
                }
                else
                {
                    MessageBox.Show("Enter a Posotive Number");
                    txtBooks.Text = "";
                    txtBooks.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a proper Value", ex.Message);
                txtBooks.Text = "";
                txtBooks.Focus();
            }         
        }

        private void BookClub_Load(object sender, EventArgs e)
        {

        }
    }
}
