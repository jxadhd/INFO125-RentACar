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
    public partial class CarsForm : Form
    {
        string ERRTITLE = "Error";
        public CarsForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Call the clear function
            clearAll();
        }

        private void clearAll()
        {
            // Reset values
            licensePlateText.Clear();
            availabilityCheck.Checked = false;
            brandText.Clear();
            modelText.Clear();
            yearText.Clear();
            fuelDieselRadio.Checked = false;
            fuelPetrolRadio.Checked = false;
            fuelElectricRadio.Checked = false;
            fuelHybridRadio.Checked = false;
            carTypeCombo.SelectedIndex = -1;
            addCarTypeText.Clear();

            // Reset cursor
            licensePlateText.Focus();
        }

        private bool ValidateControls()
        {
            // Input validation for fuelType
            if (!fuelPetrolRadio.Checked && !fuelDieselRadio.Checked && !fuelHybridRadio.Checked && !fuelElectricRadio.Checked)
            {
                return false;
            }

            // Input validation for all fields except fuelType
            else if (licensePlateText.Text == "" || brandText.Text == "" || modelText.Text == "" || yearText.Text == "" || carTypeCombo.Text == "")
            {
                return false;
            }
            return true;
        }

        private string GetSelectedFuelType()
        {
            // Initialise a seperate string to hold fuelTypeGroup value
            string fuelType = "";
            if (fuelPetrolRadio.Checked)
            {
                fuelType = "Petrol";
            }
            else if (fuelDieselRadio.Checked)
            {
                fuelType = "Diesel";
            }
            else if (fuelHybridRadio.Checked)
            {
                fuelType = "Hybrid";
            }
            else if (fuelElectricRadio.Checked)
            {
                fuelType = "Electric";
            }

            return fuelType;
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            // Initialise error message arguments
            string errorMsg = "One or more fields are empty!\n" +
                "Please make sure all fields have a value and try again.";

            if (ValidateControls())
            {
                // Get fuel type
                string fuelType = GetSelectedFuelType();

                // Opens a new window with car details shown
                string carDetails = "";
                carDetails += "Registration: " + licensePlateText.Text + Environment.NewLine;
                carDetails += "Available: " + availabilityCheck.Checked + Environment.NewLine;
                carDetails += "Make: " + brandText.Text + Environment.NewLine;
                carDetails += "Model: " + modelText.Text + Environment.NewLine;
                carDetails += "Year: " + yearText.Text + Environment.NewLine;
                carDetails += "Type: " + carTypeCombo.Text + Environment.NewLine;
                carDetails += "Fuel Type: " + fuelType + Environment.NewLine;

                MessageBox.Show(carDetails, "Car Details");
                clearAll();
            }
            else
            {
                MessageBox.Show(errorMsg, ERRTITLE);
            }
        }

        private void addCarTypeButton_Click(object sender, EventArgs e)
        {
            // Takes the user input and adds it to collection of vehicle types
            string newCarType = addCarTypeText.Text;
            for (int i = 0; i < carTypeCombo.Items.Count; i++)
            {
                if (carTypeCombo.Items[i].ToString() == newCarType)
                {
                    MessageBox.Show("This type of car already exists!", "Error");
                    addCarTypeText.Clear();
                    return;
                }
            }
            carTypeCombo.Items.Add(newCarType);
            MessageBox.Show($"Car type {newCarType} added succesfully!", "Success");
            addCarTypeText.Clear();
        }
    }
}
