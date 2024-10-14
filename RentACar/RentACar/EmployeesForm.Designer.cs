namespace RentACar
{
    partial class EmployeesForm
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
            this.employeesTitleLabel = new System.Windows.Forms.Label();
            this.employeesIDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.employeeIDText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.showDetailsText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.writeDetailsButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeesTitleLabel
            // 
            this.employeesTitleLabel.AutoSize = true;
            this.employeesTitleLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeesTitleLabel.Location = new System.Drawing.Point(264, 11);
            this.employeesTitleLabel.Name = "employeesTitleLabel";
            this.employeesTitleLabel.Size = new System.Drawing.Size(289, 46);
            this.employeesTitleLabel.TabIndex = 0;
            this.employeesTitleLabel.Text = "Employee Search";
            // 
            // employeesIDLabel
            // 
            this.employeesIDLabel.AutoSize = true;
            this.employeesIDLabel.Location = new System.Drawing.Point(151, 63);
            this.employeesIDLabel.Name = "employeesIDLabel";
            this.employeesIDLabel.Size = new System.Drawing.Size(76, 15);
            this.employeesIDLabel.TabIndex = 1;
            this.employeesIDLabel.Text = "Employee ID:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(151, 147);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(151, 119);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(414, 92);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(151, 92);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name:";
            // 
            // employeeIDText
            // 
            this.employeeIDText.Location = new System.Drawing.Point(233, 60);
            this.employeeIDText.Name = "employeeIDText";
            this.employeeIDText.Size = new System.Drawing.Size(437, 23);
            this.employeeIDText.TabIndex = 6;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(233, 89);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(175, 23);
            this.firstNameText.TabIndex = 7;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(486, 89);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(184, 23);
            this.lastNameText.TabIndex = 8;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(233, 144);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(437, 23);
            this.titleText.TabIndex = 9;
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(233, 116);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.ReadOnly = true;
            this.fullNameText.Size = new System.Drawing.Size(437, 23);
            this.fullNameText.TabIndex = 10;
            // 
            // showDetailsText
            // 
            this.showDetailsText.AcceptsReturn = true;
            this.showDetailsText.Location = new System.Drawing.Point(151, 259);
            this.showDetailsText.Multiline = true;
            this.showDetailsText.Name = "showDetailsText";
            this.showDetailsText.ReadOnly = true;
            this.showDetailsText.Size = new System.Drawing.Size(519, 179);
            this.showDetailsText.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(442, 202);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 51);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(559, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 51);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(151, 202);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(120, 51);
            this.showDetailsButton.TabIndex = 14;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // writeDetailsButton
            // 
            this.writeDetailsButton.Location = new System.Drawing.Point(277, 202);
            this.writeDetailsButton.Name = "writeDetailsButton";
            this.writeDetailsButton.Size = new System.Drawing.Size(120, 51);
            this.writeDetailsButton.TabIndex = 15;
            this.writeDetailsButton.Text = "Save As";
            this.writeDetailsButton.UseVisualStyleBackColor = true;
            this.writeDetailsButton.Click += new System.EventHandler(this.writeDetailsButton_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(233, 173);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(437, 23);
            this.txtPassword.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(151, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password:";
            // 
            // EmployeesForm
            // 
            this.AcceptButton = this.showDetailsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.writeDetailsButton);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDetailsText);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.employeeIDText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.employeesIDLabel);
            this.Controls.Add(this.employeesTitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesForm";
            this.ShowInTaskbar = false;
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label employeesTitleLabel;
        private Label employeesIDLabel;
        private Label titleLabel;
        private Label fullNameLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox employeeIDText;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox titleText;
        private TextBox fullNameText;
        private TextBox showDetailsText;
        private Button clearButton;
        private Button exitButton;
        private Button showDetailsButton;
        private Button writeDetailsButton;
        private SaveFileDialog saveFile;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}