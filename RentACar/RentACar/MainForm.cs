namespace RentACar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            // Opens customer form
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            // Opens employee form
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.ShowDialog();
        }

        private void orderRentalButton_Click(object sender, EventArgs e)
        {
            // Opens order form
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void carsButton_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.ShowDialog();
        }

        private void btnSalesData_Click(object sender, EventArgs e)
        {
            SalesDataForm salesDataForm = new SalesDataForm();
            salesDataForm.Show();
        }
    }
}