using System;
using System.IO;
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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            // Reset values
            employeeIDText.Text = "";
            firstNameText.Text = "";
            lastNameText.Text = "";
            fullNameLabel.Text = "";
            titleText.Text = "";
            showDetailsText.Text = "";

            // Reset cursor
            employeeIDText.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the window
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UpdateFullName()
        {
            // Updates name when changed
            fullNameText.Text = firstNameText.Text + " " + lastNameText.Text;
        }

        private void firstNameText_TextChanged(object sender, EventArgs e) => UpdateFullName();
        private void lastNameText_TextChanged(object sender, EventArgs e) => UpdateFullName();

        public string showDetailsString()
        {
            // Define and assemble the string for showDetails
            string employeeDetails = "";
            employeeDetails += "Employee ID: " + employeeIDText.Text + Environment.NewLine;
            employeeDetails += "Full name: " + fullNameText.Text + Environment.NewLine;
            employeeDetails += "Title: " + titleText.Text + Environment.NewLine;
            employeeDetails += "Password: " + txtPassword.Text;
            return employeeDetails;
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            // Password input validation
            string pass = txtPassword.Text;
            if (PasswordIsValid(pass))
            {
                // Show the content in the showDetailsText TextBox
                showDetailsText.Text = showDetailsString();
            }
        }

        private void writeDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(saveFile.FileName);
                    outputFile.Write(showDetailsText.Text);

                    outputFile.Close();
                    MessageBox.Show($"The file was saved succesfully to {saveFile.FileName}, good job!", "Success!");
                }
                else
                {
                    MessageBox.Show("The save operation was cancelled", "Error");
                }
            }
            catch
            {
                MessageBox.Show("An exception occurred. Your work has not been saved", "Error");
            }
        }

        private int NumberUppercase(string caps)
            // Returns number of uppercase characters in passed string
            // Primarily for txtPassword
        {
            int count = 0;
            foreach(char digit in caps)
            {
                if (char.IsUpper(digit))
                {
                    count++;
                }
            }
            return count;
        }

        private int NumberLowercase(string text)
        // Returns number of lowercase characters in passed string
        // Primarily for txtPassword
        {
            int count = 0;
            foreach(char digit in text)
            {
                if (Char.IsLower(digit))
                {
                    count++;
                }
            }
            return count;
        }

        private int NumberNums(string text)
        // Returns number of digits in passed string
        // Primarily for txtPassword
        {
            int count = 0;
            foreach(char num in text)
            {
                if (char.IsDigit(num))
                {
                    count++;
                }
            }
            return count;
        }

        private bool ContainsAlphabetString(string text)
        // Checks text for banned string
        {
            if (text.Contains("abc", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else return false;
        }

        private bool PasswordIsValid(string pass)
        {
            string strContentError = "You must have at least one number, one uppercase and one lowercase letter in your password! in your password!";
            if (pass.Length >= 8)
            {
                if (NumberUppercase(pass) > 0)
                {
                    if (NumberLowercase(pass) > 0)
                    {
                        if (NumberNums(pass) > 0)
                        {
                            if (!ContainsAlphabetString(pass))
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Your password cannot contain the sequence 'abc'!", "Error");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(strContentError, "Error");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(strContentError, "Error");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(strContentError, "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Your password must be at least 8 characters long!");
                return false;
            }
        }

        private void SaveAs(object text)
        {
            // Save text to file method
            StreamWriter outputFile;

            outputFile = File.CreateText(saveFile.FileName);

            outputFile.WriteLine(text);

            outputFile.Close();

            MessageBox.Show($"The data was saved to your file successfully!", "Good job!");
        }
    }
}
