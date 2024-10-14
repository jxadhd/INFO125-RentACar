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
    public partial class SalesDataForm : Form
    {
        public SalesDataForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void clearall()
        {
            lbxSalesList.Items.Clear();
            txtAverageSales.Clear();
            lbxBelowAverage.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string FindDay(int index)
        {
            string day = "";

            switch (index)
            {
                case 0:
                    day = "Monday";
                    break;
                case 1:
                    day = "Tuesday";
                    break;
                case 2:
                    day = "Wednesday";
                    break;
                case 3:
                    day = "Thursday";
                    break;
                case 4:
                    day = "Friday";
                    break;
                case 5:
                    day = "Saturday";
                    break;
                case 6:
                    day = "Sunday";
                    break;
            }
            return day;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            clearall();
            CalcAndShow();
        }

        private void CalcAndShow()
        {
            double[] totalSales = new double[7];

            double overallSales = 0;
            double overallAverage = 0;
            int days = 0;

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using StreamReader inputFile = new StreamReader(openFile.FileName);
                    string? line = inputFile.ReadLine();
                    int index = 0;

                    while (line != null)
                    {
                        double sales = double.Parse(line.Substring(4));
                        string day = line.Substring(0, 3);
                        switch (day)
                        {
                            case "MON":
                                totalSales[0] += sales;
                                break;
                            case "TUE":
                                totalSales[1] += sales;
                                break;
                            case "WED":
                                totalSales[2] += sales;
                                break;
                            case "THU":
                                totalSales[3] += sales;
                                break;
                            case "FRI":
                                totalSales[4] += sales;
                                break;
                            case "SAT":
                                totalSales[5] += sales;
                                break;
                            case "SUN":
                                totalSales[6] += sales;
                                break;
                        }
                        days++;
                        index++;
                        line = inputFile.ReadLine();
                    }

                    overallSales = totalSales.Sum();
                    overallAverage = overallSales / days;

                    for (int i = 0; i < totalSales.Length; i++)
                    {
                        string day = FindDay(i);
                        double dayAvg = totalSales[i] / 24;
                        lbxSalesList.Items.Add(day + ": " + totalSales[i].ToString("C"));

                        if (dayAvg < overallAverage)
                        {
                            lbxBelowAverage.Items.Add(day + ": " + dayAvg.ToString("C"));
                        }
                    }
                    lbxSalesList.Items.Add("Total Sales: " + overallSales.ToString("C"));
                    txtAverageSales.Text = overallAverage.ToString("C");
                   // inputFile.Close();
                }
                else
                {
                    MessageBox.Show("Please upload a file!");
                }
            }
            catch
            {
                MessageBox.Show("A critical error occurred :(", "Error");
            }
        }
    }
}
