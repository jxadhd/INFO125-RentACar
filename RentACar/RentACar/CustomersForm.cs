using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the window
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form
            // Value reset
            driversLicenseText.Text = "";
            fullNameText.Text = "";
            addressText.Text = "";
            cityText.Text = "";
            postcodeText.Text = "";

            // Reset cursor
            driversLicenseText.Focus();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            // Open a new window displaying customer's details
            string customerDetails = "";


            customerDetails += "ID (DL) #: " + driversLicenseText.Text + Environment.NewLine;
            customerDetails += "Full Name: " + fullNameText.Text + Environment.NewLine;
            customerDetails += "Address: " + addressText.Text + Environment.NewLine;
            customerDetails += "City: " + cityText.Text + Environment.NewLine;
            customerDetails += "Postcode: " + postcodeText.Text + Environment.NewLine;

            // Show the content in a MessageBox
            MessageBox.Show(customerDetails, "Customer Details");
        }
    }
}
