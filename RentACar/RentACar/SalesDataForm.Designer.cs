namespace RentACar
{
    partial class SalesDataForm
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
            this.gbxResults = new System.Windows.Forms.GroupBox();
            this.lblBelowAverage = new System.Windows.Forms.Label();
            this.lbxBelowAverage = new System.Windows.Forms.ListBox();
            this.lblAverageSales = new System.Windows.Forms.Label();
            this.txtAverageSales = new System.Windows.Forms.TextBox();
            this.lbxSalesList = new System.Windows.Forms.ListBox();
            this.lblSalesData = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.gbxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResults
            // 
            this.gbxResults.Controls.Add(this.lblBelowAverage);
            this.gbxResults.Controls.Add(this.lbxBelowAverage);
            this.gbxResults.Controls.Add(this.lblAverageSales);
            this.gbxResults.Controls.Add(this.txtAverageSales);
            this.gbxResults.Controls.Add(this.lbxSalesList);
            this.gbxResults.Location = new System.Drawing.Point(12, 57);
            this.gbxResults.Name = "gbxResults";
            this.gbxResults.Size = new System.Drawing.Size(285, 416);
            this.gbxResults.TabIndex = 0;
            this.gbxResults.TabStop = false;
            this.gbxResults.Text = "Sales Totals for the month given";
            // 
            // lblBelowAverage
            // 
            this.lblBelowAverage.AutoSize = true;
            this.lblBelowAverage.Location = new System.Drawing.Point(6, 226);
            this.lblBelowAverage.Name = "lblBelowAverage";
            this.lblBelowAverage.Size = new System.Drawing.Size(116, 15);
            this.lblBelowAverage.TabIndex = 4;
            this.lblBelowAverage.Text = "Days Below Average:";
            // 
            // lbxBelowAverage
            // 
            this.lbxBelowAverage.FormattingEnabled = true;
            this.lbxBelowAverage.ItemHeight = 15;
            this.lbxBelowAverage.Location = new System.Drawing.Point(134, 226);
            this.lbxBelowAverage.Name = "lbxBelowAverage";
            this.lbxBelowAverage.Size = new System.Drawing.Size(145, 184);
            this.lbxBelowAverage.TabIndex = 3;
            // 
            // lblAverageSales
            // 
            this.lblAverageSales.AutoSize = true;
            this.lblAverageSales.Location = new System.Drawing.Point(6, 200);
            this.lblAverageSales.Name = "lblAverageSales";
            this.lblAverageSales.Size = new System.Drawing.Size(82, 15);
            this.lblAverageSales.TabIndex = 2;
            this.lblAverageSales.Text = "Average Sales:";
            // 
            // txtAverageSales
            // 
            this.txtAverageSales.Enabled = false;
            this.txtAverageSales.Location = new System.Drawing.Point(134, 197);
            this.txtAverageSales.Name = "txtAverageSales";
            this.txtAverageSales.Size = new System.Drawing.Size(145, 23);
            this.txtAverageSales.TabIndex = 1;
            // 
            // lbxSalesList
            // 
            this.lbxSalesList.FormattingEnabled = true;
            this.lbxSalesList.ItemHeight = 15;
            this.lbxSalesList.Location = new System.Drawing.Point(6, 22);
            this.lbxSalesList.Name = "lbxSalesList";
            this.lbxSalesList.Size = new System.Drawing.Size(273, 169);
            this.lbxSalesList.TabIndex = 0;
            // 
            // lblSalesData
            // 
            this.lblSalesData.AutoSize = true;
            this.lblSalesData.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalesData.Location = new System.Drawing.Point(12, 9);
            this.lblSalesData.Name = "lblSalesData";
            this.lblSalesData.Size = new System.Drawing.Size(181, 45);
            this.lblSalesData.TabIndex = 0;
            this.lblSalesData.Text = "Sales Data";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(303, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 75);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(303, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 75);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 75);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // SalesDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 481);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSalesData);
            this.Controls.Add(this.gbxResults);
            this.Name = "SalesDataForm";
            this.Text = "Sales Data";
            this.gbxResults.ResumeLayout(false);
            this.gbxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbxResults;
        private Label lblSalesData;
        private TextBox txtAverageSales;
        private ListBox lbxSalesList;
        private Label lblBelowAverage;
        private ListBox lbxBelowAverage;
        private Label lblAverageSales;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private OpenFileDialog openFile;
    }
}