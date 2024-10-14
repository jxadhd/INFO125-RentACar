namespace RentACar
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderRentalButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.carsButton = new System.Windows.Forms.Button();
            this.btnSalesData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderRentalButton
            // 
            this.orderRentalButton.Location = new System.Drawing.Point(117, 108);
            this.orderRentalButton.Name = "orderRentalButton";
            this.orderRentalButton.Size = new System.Drawing.Size(286, 49);
            this.orderRentalButton.TabIndex = 0;
            this.orderRentalButton.Text = "Order Rental";
            this.orderRentalButton.UseVisualStyleBackColor = true;
            this.orderRentalButton.Click += new System.EventHandler(this.orderRentalButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(117, 163);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(286, 49);
            this.employeesButton.TabIndex = 2;
            this.employeesButton.Text = "Employees";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Location = new System.Drawing.Point(409, 163);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(286, 49);
            this.customersButton.TabIndex = 3;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(409, 218);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(286, 49);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // carsButton
            // 
            this.carsButton.Location = new System.Drawing.Point(409, 108);
            this.carsButton.Name = "carsButton";
            this.carsButton.Size = new System.Drawing.Size(286, 49);
            this.carsButton.TabIndex = 1;
            this.carsButton.Text = "Cars";
            this.carsButton.UseVisualStyleBackColor = true;
            this.carsButton.Click += new System.EventHandler(this.carsButton_Click);
            // 
            // btnSalesData
            // 
            this.btnSalesData.Location = new System.Drawing.Point(117, 218);
            this.btnSalesData.Name = "btnSalesData";
            this.btnSalesData.Size = new System.Drawing.Size(286, 49);
            this.btnSalesData.TabIndex = 5;
            this.btnSalesData.Text = "Sales Data";
            this.btnSalesData.UseVisualStyleBackColor = true;
            this.btnSalesData.Click += new System.EventHandler(this.btnSalesData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalesData);
            this.Controls.Add(this.carsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.orderRentalButton);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Rent A Car";
            this.ResumeLayout(false);

        }

        #endregion

        private Button orderRentalButton;
        private Button employeesButton;
        private Button customersButton;
        private Button exitButton;
        private Button carsButton;
        private Button btnSalesData;
    }
}