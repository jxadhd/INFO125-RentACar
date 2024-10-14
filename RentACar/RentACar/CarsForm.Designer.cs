namespace RentACar
{
    partial class CarsForm
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
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.licensePlateLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.availabilityCheck = new System.Windows.Forms.CheckBox();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.licensePlateText = new System.Windows.Forms.TextBox();
            this.brandText = new System.Windows.Forms.TextBox();
            this.modelText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.carTypeCombo = new System.Windows.Forms.ComboBox();
            this.fuelTypeGroup = new System.Windows.Forms.GroupBox();
            this.fuelElectricRadio = new System.Windows.Forms.RadioButton();
            this.fuelHybridRadio = new System.Windows.Forms.RadioButton();
            this.fuelDieselRadio = new System.Windows.Forms.RadioButton();
            this.fuelPetrolRadio = new System.Windows.Forms.RadioButton();
            this.addCarTypeLabel = new System.Windows.Forms.Label();
            this.addCarTypeText = new System.Windows.Forms.TextBox();
            this.addCarTypeButton = new System.Windows.Forms.Button();
            this.fuelTypeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(87, 45);
            this.formTitleLabel.TabIndex = 0;
            this.formTitleLabel.Text = "Cars";
            // 
            // licensePlateLabel
            // 
            this.licensePlateLabel.AutoSize = true;
            this.licensePlateLabel.Location = new System.Drawing.Point(23, 65);
            this.licensePlateLabel.Name = "licensePlateLabel";
            this.licensePlateLabel.Size = new System.Drawing.Size(84, 15);
            this.licensePlateLabel.TabIndex = 1;
            this.licensePlateLabel.Text = "Rego Number:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(23, 129);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(39, 15);
            this.brandLabel.TabIndex = 3;
            this.brandLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(23, 158);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(44, 15);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(23, 186);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 15);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year:";
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(23, 215);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(34, 15);
            this.carTypeLabel.TabIndex = 6;
            this.carTypeLabel.Text = "Type:";
            // 
            // availabilityCheck
            // 
            this.availabilityCheck.AutoSize = true;
            this.availabilityCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.availabilityCheck.Location = new System.Drawing.Point(23, 95);
            this.availabilityCheck.Name = "availabilityCheck";
            this.availabilityCheck.Size = new System.Drawing.Size(77, 19);
            this.availabilityCheck.TabIndex = 7;
            this.availabilityCheck.Text = "Available:";
            this.availabilityCheck.UseVisualStyleBackColor = true;
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(23, 330);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(262, 23);
            this.showDetailsButton.TabIndex = 9;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(23, 359);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(128, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(159, 359);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // licensePlateText
            // 
            this.licensePlateText.Enabled = false;
            this.licensePlateText.Location = new System.Drawing.Point(112, 62);
            this.licensePlateText.Name = "licensePlateText";
            this.licensePlateText.Size = new System.Drawing.Size(173, 23);
            this.licensePlateText.TabIndex = 12;
            // 
            // brandText
            // 
            this.brandText.Location = new System.Drawing.Point(112, 126);
            this.brandText.Name = "brandText";
            this.brandText.Size = new System.Drawing.Size(173, 23);
            this.brandText.TabIndex = 13;
            // 
            // modelText
            // 
            this.modelText.Location = new System.Drawing.Point(112, 155);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(173, 23);
            this.modelText.TabIndex = 14;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(112, 183);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(173, 23);
            this.yearText.TabIndex = 15;
            // 
            // carTypeCombo
            // 
            this.carTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.carTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.carTypeCombo.FormattingEnabled = true;
            this.carTypeCombo.Items.AddRange(new object[] {
            "Economy",
            "Compact",
            "Standard",
            "Full Size",
            "Mini Van",
            "SUV",
            "Truck",
            "Van"});
            this.carTypeCombo.Location = new System.Drawing.Point(112, 212);
            this.carTypeCombo.Name = "carTypeCombo";
            this.carTypeCombo.Size = new System.Drawing.Size(173, 23);
            this.carTypeCombo.TabIndex = 16;
            // 
            // fuelTypeGroup
            // 
            this.fuelTypeGroup.Controls.Add(this.fuelElectricRadio);
            this.fuelTypeGroup.Controls.Add(this.fuelHybridRadio);
            this.fuelTypeGroup.Controls.Add(this.fuelDieselRadio);
            this.fuelTypeGroup.Controls.Add(this.fuelPetrolRadio);
            this.fuelTypeGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.fuelTypeGroup.Location = new System.Drawing.Point(23, 270);
            this.fuelTypeGroup.Name = "fuelTypeGroup";
            this.fuelTypeGroup.Size = new System.Drawing.Size(262, 54);
            this.fuelTypeGroup.TabIndex = 17;
            this.fuelTypeGroup.TabStop = false;
            this.fuelTypeGroup.Text = "Select Fuel Type";
            // 
            // fuelElectricRadio
            // 
            this.fuelElectricRadio.AutoSize = true;
            this.fuelElectricRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fuelElectricRadio.Location = new System.Drawing.Point(197, 22);
            this.fuelElectricRadio.Name = "fuelElectricRadio";
            this.fuelElectricRadio.Size = new System.Drawing.Size(63, 19);
            this.fuelElectricRadio.TabIndex = 3;
            this.fuelElectricRadio.TabStop = true;
            this.fuelElectricRadio.Text = "Electric";
            this.fuelElectricRadio.UseVisualStyleBackColor = true;
            // 
            // fuelHybridRadio
            // 
            this.fuelHybridRadio.AutoSize = true;
            this.fuelHybridRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fuelHybridRadio.Location = new System.Drawing.Point(130, 22);
            this.fuelHybridRadio.Name = "fuelHybridRadio";
            this.fuelHybridRadio.Size = new System.Drawing.Size(61, 19);
            this.fuelHybridRadio.TabIndex = 2;
            this.fuelHybridRadio.TabStop = true;
            this.fuelHybridRadio.Text = "Hybrid";
            this.fuelHybridRadio.UseVisualStyleBackColor = true;
            // 
            // fuelDieselRadio
            // 
            this.fuelDieselRadio.AutoSize = true;
            this.fuelDieselRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fuelDieselRadio.Location = new System.Drawing.Point(68, 22);
            this.fuelDieselRadio.Name = "fuelDieselRadio";
            this.fuelDieselRadio.Size = new System.Drawing.Size(56, 19);
            this.fuelDieselRadio.TabIndex = 1;
            this.fuelDieselRadio.TabStop = true;
            this.fuelDieselRadio.Text = "Diesel";
            this.fuelDieselRadio.UseVisualStyleBackColor = true;
            // 
            // fuelPetrolRadio
            // 
            this.fuelPetrolRadio.AutoSize = true;
            this.fuelPetrolRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fuelPetrolRadio.Location = new System.Drawing.Point(6, 22);
            this.fuelPetrolRadio.Name = "fuelPetrolRadio";
            this.fuelPetrolRadio.Size = new System.Drawing.Size(56, 19);
            this.fuelPetrolRadio.TabIndex = 0;
            this.fuelPetrolRadio.TabStop = true;
            this.fuelPetrolRadio.Text = "Petrol";
            this.fuelPetrolRadio.UseVisualStyleBackColor = true;
            // 
            // addCarTypeLabel
            // 
            this.addCarTypeLabel.AutoSize = true;
            this.addCarTypeLabel.Location = new System.Drawing.Point(23, 245);
            this.addCarTypeLabel.Name = "addCarTypeLabel";
            this.addCarTypeLabel.Size = new System.Drawing.Size(59, 15);
            this.addCarTypeLabel.TabIndex = 18;
            this.addCarTypeLabel.Text = "Add Type:";
            // 
            // addCarTypeText
            // 
            this.addCarTypeText.Location = new System.Drawing.Point(112, 241);
            this.addCarTypeText.Name = "addCarTypeText";
            this.addCarTypeText.Size = new System.Drawing.Size(128, 23);
            this.addCarTypeText.TabIndex = 19;
            // 
            // addCarTypeButton
            // 
            this.addCarTypeButton.Location = new System.Drawing.Point(246, 241);
            this.addCarTypeButton.Name = "addCarTypeButton";
            this.addCarTypeButton.Size = new System.Drawing.Size(41, 23);
            this.addCarTypeButton.TabIndex = 20;
            this.addCarTypeButton.Text = "Add";
            this.addCarTypeButton.UseVisualStyleBackColor = true;
            this.addCarTypeButton.Click += new System.EventHandler(this.addCarTypeButton_Click);
            // 
            // CarsForm
            // 
            this.AcceptButton = this.showDetailsButton;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(304, 398);
            this.Controls.Add(this.addCarTypeButton);
            this.Controls.Add(this.addCarTypeText);
            this.Controls.Add(this.addCarTypeLabel);
            this.Controls.Add(this.fuelTypeGroup);
            this.Controls.Add(this.carTypeCombo);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.brandText);
            this.Controls.Add(this.licensePlateText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.availabilityCheck);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.licensePlateLabel);
            this.Controls.Add(this.formTitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarsForm";
            this.ShowIcon = false;
            this.Text = "Cars";
            this.fuelTypeGroup.ResumeLayout(false);
            this.fuelTypeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label formTitleLabel;
        private Label licensePlateLabel;
        private Label brandLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label carTypeLabel;
        private CheckBox availabilityCheck;
        private Button showDetailsButton;
        private Button clearButton;
        private Button exitButton;
        private TextBox licensePlateText;
        private TextBox brandText;
        private TextBox modelText;
        private TextBox yearText;
        private ComboBox carTypeCombo;
        private GroupBox fuelTypeGroup;
        private RadioButton fuelElectricRadio;
        private RadioButton fuelHybridRadio;
        private RadioButton fuelDieselRadio;
        private RadioButton fuelPetrolRadio;
        private Label addCarTypeLabel;
        private TextBox addCarTypeText;
        private Button addCarTypeButton;
    }
}