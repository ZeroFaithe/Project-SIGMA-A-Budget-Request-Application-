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
            labelSelectFromPOA.Location = new Point(10, 19);
            labelSelectFromPOA.Name = "labelSelectFromPOA";
            labelSelectFromPOA.Size = new Size(240, 15);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 558);
            panel1.TabIndex = 7;
            // 
            // cmbPOA
            // 
            cmbPOA.FormattingEnabled = true;
            cmbPOA.Location = new Point(284, 15);
            cmbPOA.Name = "cmbPOA";
            cmbPOA.Size = new Size(194, 23);
            cmbPOA.TabIndex = 8;
            // 
            // dgvLiquidationSummary
            // 
            dgvLiquidationSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLiquidationSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLiquidationSummary.Location = new Point(44, 245);
            dgvLiquidationSummary.Name = "dgvLiquidationSummary";
            dgvLiquidationSummary.RowHeadersWidth = 51;
            dgvLiquidationSummary.Size = new Size(666, 158);
            dgvLiquidationSummary.TabIndex = 12;
            // 
            // dgvBudgetSummary
            // 
            dgvBudgetSummary.AllowUserToAddRows = false;
            dgvBudgetSummary.AllowUserToDeleteRows = false;
            dgvBudgetSummary.AllowUserToResizeRows = false;
            dgvBudgetSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudgetSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgetSummary.Location = new Point(44, 80);
            dgvBudgetSummary.Name = "dgvBudgetSummary";
            dgvBudgetSummary.RowHeadersWidth = 51;
            dgvBudgetSummary.Size = new Size(666, 139);
            dgvBudgetSummary.TabIndex = 11;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.BackColor = SystemColors.ControlLight;
            btnSubmitReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSubmitReport.Location = new Point(618, 428);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(92, 44);
            btnSubmitReport.TabIndex = 10;
            btnSubmitReport.Text = "SUBMIT REPORT";
            btnSubmitReport.UseVisualStyleBackColor = false;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // btnUploadReceipts
            // 
            btnUploadReceipts.BackColor = SystemColors.ControlLight;
            btnUploadReceipts.Font = new Font("Arial Rounded MT Bold", 9F);
            btnUploadReceipts.Location = new Point(44, 428);
            btnUploadReceipts.Name = "btnUploadReceipts";
            btnUploadReceipts.Size = new Size(92, 44);
            btnUploadReceipts.TabIndex = 9;
            btnUploadReceipts.Text = "UPLOAD RECEIPTS";
            btnUploadReceipts.UseVisualStyleBackColor = false;
            btnUploadReceipts.Click += btnUploadReceipts_Click;
            // 
            // LiquidationFormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 523);
            Controls.Add(panel1);
            Name = "LiquidationFormStudent";
            StartPosition = FormStartPosition.CenterScreen;
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