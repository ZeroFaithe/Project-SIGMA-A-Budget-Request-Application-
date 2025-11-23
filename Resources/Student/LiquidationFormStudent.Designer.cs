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
            panel2 = new Panel();
            rdoReimbursement = new RadioButton();
            rdoLiquidation = new RadioButton();
            btnRemoveReceipt = new Button();
            btnAddReceipt = new Button();
            btnFilterRejected = new Button();
            btnFilterToRevise = new Button();
            btnFilterPending = new Button();
            btnFilterApproved = new Button();
            label3 = new Label();
            dgvSummary = new DataGridView();
            label2 = new Label();
            cmbApprovedBudgets = new ComboBox();
            dgvLiquidationHistory = new DataGridView();
            dgvBudgetBasis = new DataGridView();
            btnSubmitReport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetBasis).BeginInit();
            SuspendLayout();
            // 
            // labelSelectFromPOA
            // 
            labelSelectFromPOA.AutoSize = true;
            labelSelectFromPOA.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectFromPOA.Location = new Point(14, 361);
            labelSelectFromPOA.Margin = new Padding(4, 0, 4, 0);
            labelSelectFromPOA.Name = "labelSelectFromPOA";
            labelSelectFromPOA.Size = new Size(245, 23);
            labelSelectFromPOA.TabIndex = 6;
            labelSelectFromPOA.Text = "SELECT BUDGET REQUEST:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRemoveReceipt);
            panel1.Controls.Add(btnAddReceipt);
            panel1.Controls.Add(btnFilterRejected);
            panel1.Controls.Add(btnFilterToRevise);
            panel1.Controls.Add(btnFilterPending);
            panel1.Controls.Add(btnFilterApproved);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dgvSummary);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbApprovedBudgets);
            panel1.Controls.Add(dgvLiquidationHistory);
            panel1.Controls.Add(labelSelectFromPOA);
            panel1.Controls.Add(dgvBudgetBasis);
            panel1.Controls.Add(btnSubmitReport);
            panel1.Location = new Point(4, 2);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 930);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rdoReimbursement);
            panel2.Controls.Add(rdoLiquidation);
            panel2.Location = new Point(742, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 65);
            panel2.TabIndex = 24;
            // 
            // rdoReimbursement
            // 
            rdoReimbursement.AutoSize = true;
            rdoReimbursement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoReimbursement.Location = new Point(182, 19);
            rdoReimbursement.Name = "rdoReimbursement";
            rdoReimbursement.Size = new Size(187, 27);
            rdoReimbursement.TabIndex = 1;
            rdoReimbursement.TabStop = true;
            rdoReimbursement.Text = "Reimbursement";
            rdoReimbursement.UseVisualStyleBackColor = true;
            // 
            // rdoLiquidation
            // 
            rdoLiquidation.AutoSize = true;
            rdoLiquidation.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoLiquidation.Location = new Point(19, 19);
            rdoLiquidation.Name = "rdoLiquidation";
            rdoLiquidation.Size = new Size(141, 27);
            rdoLiquidation.TabIndex = 0;
            rdoLiquidation.TabStop = true;
            rdoLiquidation.Text = "Liquidation";
            rdoLiquidation.UseVisualStyleBackColor = true;
            // 
            // btnRemoveReceipt
            // 
            btnRemoveReceipt.BackColor = Color.LightCoral;
            btnRemoveReceipt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveReceipt.Location = new Point(238, 699);
            btnRemoveReceipt.Margin = new Padding(4, 5, 4, 5);
            btnRemoveReceipt.Name = "btnRemoveReceipt";
            btnRemoveReceipt.Size = new Size(200, 55);
            btnRemoveReceipt.TabIndex = 23;
            btnRemoveReceipt.Text = "REMOVE RECEIPT";
            btnRemoveReceipt.UseVisualStyleBackColor = false;
            btnRemoveReceipt.Click += btnRemoveReceipt_Click;
            // 
            // btnAddReceipt
            // 
            btnAddReceipt.BackColor = Color.LightCoral;
            btnAddReceipt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddReceipt.Location = new Point(14, 699);
            btnAddReceipt.Margin = new Padding(4, 5, 4, 5);
            btnAddReceipt.Name = "btnAddReceipt";
            btnAddReceipt.Size = new Size(200, 55);
            btnAddReceipt.TabIndex = 22;
            btnAddReceipt.Text = "ADD RECEIPT";
            btnAddReceipt.UseVisualStyleBackColor = false;
            btnAddReceipt.Click += btnAddReceipt_Click;
            // 
            // btnFilterRejected
            // 
            btnFilterRejected.BackColor = Color.LightCoral;
            btnFilterRejected.FlatAppearance.BorderSize = 0;
            btnFilterRejected.FlatStyle = FlatStyle.Flat;
            btnFilterRejected.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterRejected.Location = new Point(403, 54);
            btnFilterRejected.Margin = new Padding(0);
            btnFilterRejected.Name = "btnFilterRejected";
            btnFilterRejected.Size = new Size(130, 42);
            btnFilterRejected.TabIndex = 21;
            btnFilterRejected.Text = "REJECTED";
            btnFilterRejected.UseVisualStyleBackColor = false;
            btnFilterRejected.Click += btnFilterRejected_Click;
            // 
            // btnFilterToRevise
            // 
            btnFilterToRevise.BackColor = Color.LightSkyBlue;
            btnFilterToRevise.FlatAppearance.BorderSize = 0;
            btnFilterToRevise.FlatStyle = FlatStyle.Flat;
            btnFilterToRevise.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterToRevise.Location = new Point(273, 54);
            btnFilterToRevise.Margin = new Padding(0);
            btnFilterToRevise.Name = "btnFilterToRevise";
            btnFilterToRevise.Size = new Size(130, 42);
            btnFilterToRevise.TabIndex = 20;
            btnFilterToRevise.Text = "TO REVISE";
            btnFilterToRevise.UseVisualStyleBackColor = false;
            btnFilterToRevise.Click += btnFilterToRevise_Click;
            // 
            // btnFilterPending
            // 
            btnFilterPending.BackColor = Color.NavajoWhite;
            btnFilterPending.FlatAppearance.BorderSize = 0;
            btnFilterPending.FlatStyle = FlatStyle.Flat;
            btnFilterPending.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterPending.Location = new Point(144, 54);
            btnFilterPending.Margin = new Padding(0);
            btnFilterPending.Name = "btnFilterPending";
            btnFilterPending.Size = new Size(130, 42);
            btnFilterPending.TabIndex = 19;
            btnFilterPending.Text = "PENDING";
            btnFilterPending.UseVisualStyleBackColor = false;
            btnFilterPending.Click += btnFilterPending_Click;
            // 
            // btnFilterApproved
            // 
            btnFilterApproved.BackColor = Color.PaleGreen;
            btnFilterApproved.FlatAppearance.BorderSize = 0;
            btnFilterApproved.FlatStyle = FlatStyle.Flat;
            btnFilterApproved.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterApproved.Location = new Point(14, 54);
            btnFilterApproved.Margin = new Padding(0);
            btnFilterApproved.Name = "btnFilterApproved";
            btnFilterApproved.Size = new Size(130, 42);
            btnFilterApproved.TabIndex = 18;
            btnFilterApproved.Text = "APPROVED";
            btnFilterApproved.UseVisualStyleBackColor = false;
            btnFilterApproved.Click += btnFilterApproved_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 430);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 23);
            label3.TabIndex = 17;
            label3.Text = "REPORT SUMMARY:";
            // 
            // dgvSummary
            // 
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(14, 458);
            dgvSummary.Margin = new Padding(4, 5, 4, 5);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.ReadOnly = true;
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.Size = new Size(1111, 231);
            dgvSummary.TabIndex = 16;
            dgvSummary.CellContentClick += dgvSummary_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            label2.Location = new Point(715, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(353, 19);
            label2.TabIndex = 15;
            label2.Text = "APPROVED BUDGET BREAKDOWN (REFERENCE)";
            // 
            // cmbApprovedBudgets
            // 
            cmbApprovedBudgets.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbApprovedBudgets.FormattingEnabled = true;
            cmbApprovedBudgets.Location = new Point(267, 361);
            cmbApprovedBudgets.Margin = new Padding(4, 5, 4, 5);
            cmbApprovedBudgets.Name = "cmbApprovedBudgets";
            cmbApprovedBudgets.Size = new Size(452, 29);
            cmbApprovedBudgets.TabIndex = 8;
            cmbApprovedBudgets.SelectedIndexChanged += cmbApprovedBudgets_SelectedIndexChanged;
            // 
            // dgvLiquidationHistory
            // 
            dgvLiquidationHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLiquidationHistory.Location = new Point(14, 96);
            dgvLiquidationHistory.Margin = new Padding(4, 5, 4, 5);
            dgvLiquidationHistory.Name = "dgvLiquidationHistory";
            dgvLiquidationHistory.RowHeadersWidth = 51;
            dgvLiquidationHistory.Size = new Size(666, 231);
            dgvLiquidationHistory.TabIndex = 12;
            // 
            // dgvBudgetBasis
            // 
            dgvBudgetBasis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgetBasis.Location = new Point(715, 96);
            dgvBudgetBasis.Margin = new Padding(4, 5, 4, 5);
            dgvBudgetBasis.Name = "dgvBudgetBasis";
            dgvBudgetBasis.ReadOnly = true;
            dgvBudgetBasis.RowHeadersWidth = 51;
            dgvBudgetBasis.Size = new Size(410, 231);
            dgvBudgetBasis.TabIndex = 11;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.BackColor = Color.PaleGreen;
            btnSubmitReport.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitReport.Location = new Point(937, 772);
            btnSubmitReport.Margin = new Padding(4, 5, 4, 5);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(200, 74);
            btnSubmitReport.TabIndex = 10;
            btnSubmitReport.Text = "SUBMIT REPORT";
            btnSubmitReport.UseVisualStyleBackColor = false;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // LiquidationFormStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 871);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LiquidationFormStudent";
            Text = "Liquidation Form";
            Load += LiquidationFormStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetBasis).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelSelectFromPOA;
        private Panel panel1;
        private Button btnSubmitReport;
        private ComboBox cmbApprovedBudgets;
        private DataGridView dgvLiquidationHistory;
        private DataGridView dgvBudgetBasis;
        private Label label2;
        private DataGridView dgvSummary;
        private Label label3;
        private Button btnFilterRejected;
        private Button btnFilterToRevise;
        private Button btnFilterPending;
        private Button btnFilterApproved;
        private Button btnAddReceipt;
        private Panel panel2;
        private RadioButton rdoReimbursement;
        private RadioButton rdoLiquidation;
        private Button btnRemoveReceipt;
    }
}