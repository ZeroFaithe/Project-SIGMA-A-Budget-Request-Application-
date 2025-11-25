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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            labelSelectFromPOA = new Label();
            panel1 = new Panel();
            dgvLiquidationHistory = new DataGridView();
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
            dgvBudgetBasis = new DataGridView();
            btnSubmitReport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationHistory).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetBasis).BeginInit();
            SuspendLayout();
            // 
            // labelSelectFromPOA
            // 
            labelSelectFromPOA.AutoSize = true;
            labelSelectFromPOA.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectFromPOA.Location = new Point(11, 289);
            labelSelectFromPOA.Name = "labelSelectFromPOA";
            labelSelectFromPOA.Size = new Size(208, 19);
            labelSelectFromPOA.TabIndex = 6;
            labelSelectFromPOA.Text = "SELECT BUDGET REQUEST:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvLiquidationHistory);
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
            panel1.Controls.Add(labelSelectFromPOA);
            panel1.Controls.Add(dgvBudgetBasis);
            panel1.Controls.Add(btnSubmitReport);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 744);
            panel1.TabIndex = 7;
            // 
            // dgvLiquidationHistory
            // 
            dgvLiquidationHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLiquidationHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLiquidationHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLiquidationHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLiquidationHistory.EnableHeadersVisualStyles = false;
            dgvLiquidationHistory.Location = new Point(11, 77);
            dgvLiquidationHistory.Margin = new Padding(2);
            dgvLiquidationHistory.Name = "dgvLiquidationHistory";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLiquidationHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLiquidationHistory.RowHeadersWidth = 21;
            dgvLiquidationHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLiquidationHistory.Size = new Size(545, 185);
            dgvLiquidationHistory.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rdoReimbursement);
            panel2.Controls.Add(rdoLiquidation);
            panel2.Location = new Point(594, 274);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 52);
            panel2.TabIndex = 24;
            // 
            // rdoReimbursement
            // 
            rdoReimbursement.AutoSize = true;
            rdoReimbursement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoReimbursement.Location = new Point(146, 15);
            rdoReimbursement.Margin = new Padding(2);
            rdoReimbursement.Name = "rdoReimbursement";
            rdoReimbursement.Size = new Size(157, 23);
            rdoReimbursement.TabIndex = 1;
            rdoReimbursement.TabStop = true;
            rdoReimbursement.Text = "Reimbursement";
            rdoReimbursement.UseVisualStyleBackColor = true;
            // 
            // rdoLiquidation
            // 
            rdoLiquidation.AutoSize = true;
            rdoLiquidation.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoLiquidation.Location = new Point(15, 15);
            rdoLiquidation.Margin = new Padding(2);
            rdoLiquidation.Name = "rdoLiquidation";
            rdoLiquidation.Size = new Size(117, 23);
            rdoLiquidation.TabIndex = 0;
            rdoLiquidation.TabStop = true;
            rdoLiquidation.Text = "Liquidation";
            rdoLiquidation.UseVisualStyleBackColor = true;
            // 
            // btnRemoveReceipt
            // 
            btnRemoveReceipt.BackColor = Color.LightCoral;
            btnRemoveReceipt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveReceipt.Location = new Point(190, 559);
            btnRemoveReceipt.Margin = new Padding(3, 4, 3, 4);
            btnRemoveReceipt.Name = "btnRemoveReceipt";
            btnRemoveReceipt.Size = new Size(160, 44);
            btnRemoveReceipt.TabIndex = 23;
            btnRemoveReceipt.Text = "REMOVE RECEIPT";
            btnRemoveReceipt.UseVisualStyleBackColor = false;
            btnRemoveReceipt.Click += btnRemoveReceipt_Click;
            // 
            // btnAddReceipt
            // 
            btnAddReceipt.BackColor = Color.LightCoral;
            btnAddReceipt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddReceipt.Location = new Point(11, 559);
            btnAddReceipt.Margin = new Padding(3, 4, 3, 4);
            btnAddReceipt.Name = "btnAddReceipt";
            btnAddReceipt.Size = new Size(160, 44);
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
            btnFilterRejected.Location = new Point(322, 43);
            btnFilterRejected.Margin = new Padding(0);
            btnFilterRejected.Name = "btnFilterRejected";
            btnFilterRejected.Size = new Size(104, 34);
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
            btnFilterToRevise.Location = new Point(218, 43);
            btnFilterToRevise.Margin = new Padding(0);
            btnFilterToRevise.Name = "btnFilterToRevise";
            btnFilterToRevise.Size = new Size(104, 34);
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
            btnFilterPending.Location = new Point(115, 43);
            btnFilterPending.Margin = new Padding(0);
            btnFilterPending.Name = "btnFilterPending";
            btnFilterPending.Size = new Size(104, 34);
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
            btnFilterApproved.Location = new Point(11, 43);
            btnFilterApproved.Margin = new Padding(0);
            btnFilterApproved.Name = "btnFilterApproved";
            btnFilterApproved.Size = new Size(104, 34);
            btnFilterApproved.TabIndex = 18;
            btnFilterApproved.Text = "APPROVED";
            btnFilterApproved.UseVisualStyleBackColor = false;
            btnFilterApproved.Click += btnFilterApproved_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 344);
            label3.Name = "label3";
            label3.Size = new Size(162, 19);
            label3.TabIndex = 17;
            label3.Text = "REPORT SUMMARY:";
            // 
            // dgvSummary
            // 
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSummary.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSummary.EnableHeadersVisualStyles = false;
            dgvSummary.Location = new Point(11, 366);
            dgvSummary.Margin = new Padding(3, 4, 3, 4);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.ReadOnly = true;
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.Size = new Size(889, 185);
            dgvSummary.TabIndex = 16;
            dgvSummary.CellContentClick += dgvSummary_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            label2.Location = new Point(572, 53);
            label2.Name = "label2";
            label2.Size = new Size(314, 17);
            label2.TabIndex = 15;
            label2.Text = "APPROVED BUDGET BREAKDOWN (REFERENCE)";
            // 
            // cmbApprovedBudgets
            // 
            cmbApprovedBudgets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbApprovedBudgets.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbApprovedBudgets.FormattingEnabled = true;
            cmbApprovedBudgets.Location = new Point(214, 289);
            cmbApprovedBudgets.Margin = new Padding(3, 4, 3, 4);
            cmbApprovedBudgets.Name = "cmbApprovedBudgets";
            cmbApprovedBudgets.Size = new Size(362, 28);
            cmbApprovedBudgets.TabIndex = 8;
            cmbApprovedBudgets.SelectedIndexChanged += cmbApprovedBudgets_SelectedIndexChanged;
            // 
            // dgvBudgetBasis
            // 
            dgvBudgetBasis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudgetBasis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBudgetBasis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgetBasis.DefaultCellStyle = dataGridViewCellStyle5;
            dgvBudgetBasis.EnableHeadersVisualStyles = false;
            dgvBudgetBasis.Location = new Point(572, 77);
            dgvBudgetBasis.Margin = new Padding(3, 4, 3, 4);
            dgvBudgetBasis.Name = "dgvBudgetBasis";
            dgvBudgetBasis.ReadOnly = true;
            dgvBudgetBasis.RowHeadersWidth = 51;
            dgvBudgetBasis.Size = new Size(328, 185);
            dgvBudgetBasis.TabIndex = 11;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.BackColor = Color.PaleGreen;
            btnSubmitReport.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitReport.Location = new Point(750, 618);
            btnSubmitReport.Margin = new Padding(3, 4, 3, 4);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(160, 59);
            btnSubmitReport.TabIndex = 10;
            btnSubmitReport.Text = "SUBMIT REPORT";
            btnSubmitReport.UseVisualStyleBackColor = false;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // LiquidationFormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 697);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LiquidationFormStudent";
            Text = "Liquidation Form";
            Load += LiquidationFormStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationHistory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetBasis).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelSelectFromPOA;
        private Panel panel1;
        private Button btnSubmitReport;
        private ComboBox cmbApprovedBudgets;
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
        private DataGridView dgvLiquidationHistory;
    }
}