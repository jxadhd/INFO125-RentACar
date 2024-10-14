namespace RentACar
{
    public partial class OrderForm : Form
    {
        // GST %
        const float TAX_PERCENTAGE = 0.15f;
        const float DISCOUNT_PERCENTAGE_1 = 0.025f;
        const float DISCOUNT_PERCENTAGE_2 = 0.05f;
        const float DISCOUNT_PERCENTAGE_3 = 0.075f;

        public OrderForm()
        {
            InitializeComponent();
        }

        private float calculateDiscount(float numberOfDays, float subtotal)
        {
            // Initialise float discountAmount
            float discountAmount = 0;

            // Iterate to decide on DISCOUNT_PERCENTAGE
            if (numberOfDays >= 4)
            {
                if (numberOfDays > 14)
                {
                    // Calculates discount where numberOfDays > 14
                    discountAmount = subtotal * DISCOUNT_PERCENTAGE_2;
                }
                else if (numberOfDays > 7)
                {
                    // Calculates discount where numberOfDays < 14 and > 7
                    discountAmount = subtotal * DISCOUNT_PERCENTAGE_3;
                }
                else
                {
                    // Calculate discount where numberOfDays <= 7
                    discountAmount = subtotal * DISCOUNT_PERCENTAGE_1;
                }
            }
            else
            {
                discountAmount = 0;
            }
            return discountAmount;
        }

        private bool PriceInputValid()
        {
            if (float.TryParse(numberOfDaysText.Text, out float numberOfDays) && float.TryParse(ratePerDayText.Text, out float ratePerDay))
            {
                if (numberOfDays > 0 && ratePerDay > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Initialise necessary variables
            float numberOfDays = 0;
            float ratePerDay = 0;

            // Validate input
            if (!PriceInputValid())
            {
                MessageBox.Show("Invalid number of days or rate entered");
                ClearAll();
                return;
            }
            
            // Reset these variables to their validated value
            numberOfDays = int.Parse(numberOfDaysText.Text);
            ratePerDay = int.Parse(ratePerDayText.Text);

            // Calculate initial subtotal
            float subtotal = numberOfDays * ratePerDay;

            // Calculate discount
            float discountAmount = calculateDiscount(numberOfDays, subtotal);

            // Display discount
            if (discountAmount > 0)
            {
                discountAmountText.Text = discountAmount.ToString("C");
            }
            else
            {
                discountAmountText.Text = "N/A";
            }

            // Update "Tax Amount"
            float taxAmount = (subtotal - discountAmount) * TAX_PERCENTAGE;
            taxAmountText.Text = taxAmount.ToString("C");

            // Update "Order Total"
            float orderTotal = subtotal - discountAmount + taxAmount;
            orderTotalText.Text = orderTotal.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void ClearAll()
        {
            // Clear all I/O fields
            numberOfDaysText.Text = "";
            ratePerDayText.Text = "";
            taxAmountText.Text = "";
            discountAmountText.Text = "";
            orderTotalText.Text = "";

            // Reset the cursor
            numberOfDaysText.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}