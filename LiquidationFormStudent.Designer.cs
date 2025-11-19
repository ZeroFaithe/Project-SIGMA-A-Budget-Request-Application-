namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class LiquidationFormStudent
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
            labelSelectFromPOA = new Label();
            panel1 = new Panel();
            cmbPOA = new ComboBox();
            dgvLiquidationSummary = new DataGridView();
            dgvBudgetSummary = new DataGridView();
            btnSubmitReport = new Button();
            btnUploadReceipts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetSummary).BeginInit();
            SuspendLayout();
            // 
            // labelSelectFromPOA
            // 
            labelSelectFromPOA.AutoSize = true;
            labelSelectFromPOA.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSelectFromPOA.Location = new Point(11, 25);
            labelSelectFromPOA.Name = "labelSelectFromPOA";
            labelSelectFromPOA.Size = new Size(308, 20);
            labelSelectFromPOA.TabIndex = 6;
            labelSelectFromPOA.Text = "SELECT FROM BUDGET REQUESTS:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cmbPOA);
            panel1.Controls.Add(dgvLiquidationSummary);
            panel1.Controls.Add(labelSelectFromPOA);
            panel1.Controls.Add(dgvBudgetSummary);
            panel1.Controls.Add(btnSubmitReport);
            panel1.Controls.Add(btnUploadReceipts);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 744);
            panel1.TabIndex = 7;
            // 
            // cmbPOA
            // 
            cmbPOA.FormattingEnabled = true;
            cmbPOA.Location = new Point(325, 20);
            cmbPOA.Margin = new Padding(3, 4, 3, 4);
            cmbPOA.Name = "cmbPOA";
            cmbPOA.Size = new Size(221, 28);
            cmbPOA.TabIndex = 8;
            // 
            // dgvLiquidationSummary
            // 
            dgvLiquidationSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLiquidationSummary.Location = new Point(50, 327);
            dgvLiquidationSummary.Margin = new Padding(3, 4, 3, 4);
            dgvLiquidationSummary.Name = "dgvLiquidationSummary";
            dgvLiquidationSummary.RowHeadersWidth = 51;
            dgvLiquidationSummary.Size = new Size(761, 210);
            dgvLiquidationSummary.TabIndex = 12;
            // 
            // dgvBudgetSummary
            // 
            dgvBudgetSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgetSummary.Location = new Point(50, 107);
            dgvBudgetSummary.Margin = new Padding(3, 4, 3, 4);
            dgvBudgetSummary.Name = "dgvBudgetSummary";
            dgvBudgetSummary.RowHeadersWidth = 51;
            dgvBudgetSummary.Size = new Size(761, 185);
            dgvBudgetSummary.TabIndex = 11;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.BackColor = SystemColors.ControlLight;
            btnSubmitReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSubmitReport.Location = new Point(706, 571);
            btnSubmitReport.Margin = new Padding(3, 4, 3, 4);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(105, 59);
            btnSubmitReport.TabIndex = 10;
            btnSubmitReport.Text = "SUBMIT REPORT";
            btnSubmitReport.UseVisualStyleBackColor = false;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // btnUploadReceipts
            // 
            btnUploadReceipts.BackColor = SystemColors.ControlLight;
            btnUploadReceipts.Font = new Font("Arial Rounded MT Bold", 9F);
            btnUploadReceipts.Location = new Point(50, 571);
            btnUploadReceipts.Margin = new Padding(3, 4, 3, 4);
            btnUploadReceipts.Name = "btnUploadReceipts";
            btnUploadReceipts.Size = new Size(105, 59);
            btnUploadReceipts.TabIndex = 9;
            btnUploadReceipts.Text = "UPLOAD RECEIPTS";
            btnUploadReceipts.UseVisualStyleBackColor = false;
            btnUploadReceipts.Click += btnUploadReceipts_Click;
            // 
            // LiquidationFormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 697);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LiquidationFormStudent";
            Text = "Liquidation Form";
            Load += LiquidationFormStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelSelectFromPOA;
        private Panel panel1;
        private Button btnSubmitReport;
        private Button btnUploadReceipts;
        private ComboBox cmbPOA;
        private DataGridView dgvLiquidationSummary;
        private DataGridView dgvBudgetSummary;
    }
}