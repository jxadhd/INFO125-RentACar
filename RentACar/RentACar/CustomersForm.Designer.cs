namespace RentACar
{
    partial class CustomersForm
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
            this.customerTitleLabel = new System.Windows.Forms.Label();
            this.driversLicenseLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.driversLicenseText = new System.Windows.Forms.TextBox();
            this.postcodeText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerTitleLabel
            // 
            this.customerTitleLabel.AutoSize = true;
            this.customerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerTitleLabel.Location = new System.Drawing.Point(88, 90);
            this.customerTitleLabel.Name = "customerTitleLabel";
            this.customerTitleLabel.Size = new System.Drawing.Size(174, 46);
            this.customerTitleLabel.TabIndex = 0;
            this.customerTitleLabel.Text = "Customer";
            // 
            // driversLicenseLabel
            // 
            this.driversLicenseLabel.AutoSize = true;
            this.driversLicenseLabel.Location = new System.Drawing.Point(88, 142);
            this.driversLicenseLabel.Name = "driversLicenseLabel";
            this.driversLicenseLabel.Size = new System.Drawing.Size(118, 15);
            this.driversLicenseLabel.TabIndex = 1;
            this.driversLicenseLabel.Text = "Driver\'s Licence/ ID#:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(88, 258);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(59, 15);
            this.zipCodeLabel.TabIndex = 2;
            this.zipCodeLabel.Text = "Postcode:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(88, 229);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 15);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(88, 200);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 15);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(88, 171);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // driversLicenseText
            // 
            this.driversLicenseText.Location = new System.Drawing.Point(213, 139);
            this.driversLicenseText.Name = "driversLicenseText";
            this.driversLicenseText.Size = new System.Drawing.Size(494, 23);
            this.driversLicenseText.TabIndex = 6;
            // 
            // postcodeText
            // 
            this.postcodeText.Location = new System.Drawing.Point(213, 255);
            this.postcodeText.Name = "postcodeText";
            this.postcodeText.Size = new System.Drawing.Size(91, 23);
            this.postcodeText.TabIndex = 7;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(213, 226);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(494, 23);
            this.cityText.TabIndex = 8;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(213, 197);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(494, 23);
            this.addressText.TabIndex = 9;
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(213, 168);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(494, 23);
            this.fullNameText.TabIndex = 10;
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(88, 284);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(292, 23);
            this.showDetailsButton.TabIndex = 11;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(88, 313);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(237, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.postcodeText);
            this.Controls.Add(this.driversLicenseText);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.driversLicenseLabel);
            this.Controls.Add(this.customerTitleLabel);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label customerTitleLabel;
        private Label driversLicenseLabel;
        private Label zipCodeLabel;
        private Label cityLabel;
        private Label addressLabel;
        private Label fullNameLabel;
        private TextBox driversLicenseText;
        private TextBox postcodeText;
        private TextBox cityText;
        private TextBox addressText;
        private TextBox fullNameText;
        private Button showDetailsButton;
        private Button clearButton;
        private Button exitButton;
    }
}