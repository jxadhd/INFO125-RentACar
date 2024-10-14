namespace RentACar
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderTitleLabel = new System.Windows.Forms.Label();
            this.numberOfDaysLabel = new System.Windows.Forms.Label();
            this.ratePerDayLabel = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.numberOfDaysText = new System.Windows.Forms.TextBox();
            this.ratePerDayText = new System.Windows.Forms.TextBox();
            this.taxAmountText = new System.Windows.Forms.TextBox();
            this.orderTotalText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountAmountText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // orderTitleLabel
            // 
            this.orderTitleLabel.AutoSize = true;
            this.orderTitleLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderTitleLabel.Location = new System.Drawing.Point(12, 18);
            this.orderTitleLabel.Name = "orderTitleLabel";
            this.orderTitleLabel.Size = new System.Drawing.Size(113, 46);
            this.orderTitleLabel.TabIndex = 0;
            this.orderTitleLabel.Text = "Order";
            // 
            // numberOfDaysLabel
            // 
            this.numberOfDaysLabel.AutoSize = true;
            this.numberOfDaysLabel.Location = new System.Drawing.Point(23, 70);
            this.numberOfDaysLabel.Name = "numberOfDaysLabel";
            this.numberOfDaysLabel.Size = new System.Drawing.Size(96, 15);
            this.numberOfDaysLabel.TabIndex = 1;
            this.numberOfDaysLabel.Text = "Number of Days:";
            // 
            // ratePerDayLabel
            // 
            this.ratePerDayLabel.AutoSize = true;
            this.ratePerDayLabel.Location = new System.Drawing.Point(23, 99);
            this.ratePerDayLabel.Name = "ratePerDayLabel";
            this.ratePerDayLabel.Size = new System.Drawing.Size(62, 15);
            this.ratePerDayLabel.TabIndex = 2;
            this.ratePerDayLabel.Text = "Daily Rate:";
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.AutoSize = true;
            this.taxAmountLabel.Location = new System.Drawing.Point(23, 199);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(74, 15);
            this.taxAmountLabel.TabIndex = 3;
            this.taxAmountLabel.Text = "Tax Amount:";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(23, 257);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(68, 15);
            this.orderTotalLabel.TabIndex = 4;
            this.orderTotalLabel.Text = "Order Total:";
            // 
            // numberOfDaysText
            // 
            this.numberOfDaysText.Location = new System.Drawing.Point(125, 67);
            this.numberOfDaysText.Name = "numberOfDaysText";
            this.numberOfDaysText.Size = new System.Drawing.Size(120, 23);
            this.numberOfDaysText.TabIndex = 0;
            // 
            // ratePerDayText
            // 
            this.ratePerDayText.Location = new System.Drawing.Point(125, 96);
            this.ratePerDayText.Name = "ratePerDayText";
            this.ratePerDayText.Size = new System.Drawing.Size(120, 23);
            this.ratePerDayText.TabIndex = 1;
            // 
            // taxAmountText
            // 
            this.taxAmountText.Location = new System.Drawing.Point(125, 191);
            this.taxAmountText.Name = "taxAmountText";
            this.taxAmountText.ReadOnly = true;
            this.taxAmountText.Size = new System.Drawing.Size(120, 23);
            this.taxAmountText.TabIndex = 7;
            // 
            // orderTotalText
            // 
            this.orderTotalText.Location = new System.Drawing.Point(125, 249);
            this.orderTotalText.Name = "orderTotalText";
            this.orderTotalText.ReadOnly = true;
            this.orderTotalText.Size = new System.Drawing.Size(120, 23);
            this.orderTotalText.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(23, 286);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(222, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(22, 315);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(131, 315);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(23, 228);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(57, 15);
            this.discountAmountLabel.TabIndex = 12;
            this.discountAmountLabel.Text = "Discount:";
            // 
            // discountAmountText
            // 
            this.discountAmountText.Location = new System.Drawing.Point(125, 220);
            this.discountAmountText.Name = "discountAmountText";
            this.discountAmountText.ReadOnly = true;
            this.discountAmountText.Size = new System.Drawing.Size(120, 23);
            this.discountAmountText.TabIndex = 8;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 350);
            this.Controls.Add(this.discountAmountText);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.orderTotalText);
            this.Controls.Add(this.taxAmountText);
            this.Controls.Add(this.ratePerDayText);
            this.Controls.Add(this.numberOfDaysText);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.taxAmountLabel);
            this.Controls.Add(this.ratePerDayLabel);
            this.Controls.Add(this.numberOfDaysLabel);
            this.Controls.Add(this.orderTitleLabel);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label orderTitleLabel;
        private Label numberOfDaysLabel;
        private Label ratePerDayLabel;
        private Label taxAmountLabel;
        private Label orderTotalLabel;
        private TextBox numberOfDaysText;
        private TextBox ratePerDayText;
        private TextBox taxAmountText;
        private TextBox orderTotalText;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Label discountAmountLabel;
        private TextBox discountAmountText;
    }
}