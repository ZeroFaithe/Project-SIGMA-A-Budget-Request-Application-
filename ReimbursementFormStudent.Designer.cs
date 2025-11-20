namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class ReimbursementFormStudent
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
            panel1 = new Panel();
            labelSelectFromPOA = new Label();
            labelReimbursementEntry = new Label();
            btnSubmitReport = new Button();
            cmbPOA = new ComboBox();
            btnUploadReceipts = new Button();
            labelPOA = new Label();
            dgvReimbursementEntry = new DataGridView();
            dgvPOAsummary = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReimbursementEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPOAsummary).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelSelectFromPOA);
            panel1.Controls.Add(labelReimbursementEntry);
            panel1.Controls.Add(btnSubmitReport);
            panel1.Controls.Add(cmbPOA);
            panel1.Controls.Add(btnUploadReceipts);
            panel1.Controls.Add(labelPOA);
            panel1.Controls.Add(dgvReimbursementEntry);
            panel1.Controls.Add(dgvPOAsummary);
            panel1.Location = new Point(32, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 500);
            panel1.TabIndex = 16;
            // 
            // labelSelectFromPOA
            // 
            labelSelectFromPOA.AutoSize = true;
            labelSelectFromPOA.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSelectFromPOA.Location = new Point(64, 29);
            labelSelectFromPOA.Name = "labelSelectFromPOA";
            labelSelectFromPOA.Size = new Size(181, 15);
            labelSelectFromPOA.TabIndex = 7;
            labelSelectFromPOA.Text = "SELECT FROM REQUESTS:";
            // 
            // labelReimbursementEntry
            // 
            labelReimbursementEntry.AutoSize = true;
            labelReimbursementEntry.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReimbursementEntry.Location = new Point(53, 247);
            labelReimbursementEntry.Name = "labelReimbursementEntry";
            labelReimbursementEntry.Size = new Size(171, 15);
            labelReimbursementEntry.TabIndex = 11;
            labelReimbursementEntry.Text = "REIMBURSEMENT ENTRY";
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSubmitReport.Location = new Point(627, 433);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(92, 44);
            btnSubmitReport.TabIndex = 14;
            btnSubmitReport.Text = "SUBMIT REPORT";
            btnSubmitReport.UseVisualStyleBackColor = true;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // cmbPOA
            // 
            cmbPOA.FormattingEnabled = true;
            cmbPOA.Location = new Point(271, 26);
            cmbPOA.Name = "cmbPOA";
            cmbPOA.Size = new Size(182, 23);
            cmbPOA.TabIndex = 8;
            // 
            // btnUploadReceipts
            // 
            btnUploadReceipts.Font = new Font("Arial Rounded MT Bold", 9F);
            btnUploadReceipts.Location = new Point(53, 433);
            btnUploadReceipts.Name = "btnUploadReceipts";
            btnUploadReceipts.Size = new Size(92, 44);
            btnUploadReceipts.TabIndex = 13;
            btnUploadReceipts.Text = "UPLOAD RECEIPTS";
            btnUploadReceipts.UseVisualStyleBackColor = true;
            btnUploadReceipts.Click += btnUploadReceipts_Click;
            // 
            // labelPOA
            // 
            labelPOA.AutoSize = true;
            labelPOA.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPOA.Location = new Point(64, 65);
            labelPOA.Name = "labelPOA";
            labelPOA.Size = new Size(105, 15);
            labelPOA.TabIndex = 9;
            labelPOA.Text = "POA SUMMARY";
            // 
            // dgvReimbursementEntry
            // 
            dgvReimbursementEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReimbursementEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReimbursementEntry.Location = new Point(53, 265);
            dgvReimbursementEntry.Name = "dgvReimbursementEntry";
            dgvReimbursementEntry.RowHeadersWidth = 51;
            dgvReimbursementEntry.Size = new Size(666, 150);
            dgvReimbursementEntry.TabIndex = 12;
            // 
            // dgvPOAsummary
            // 
            dgvPOAsummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPOAsummary.Location = new Point(53, 81);
            dgvPOAsummary.Name = "dgvPOAsummary";
            dgvPOAsummary.RowHeadersWidth = 51;
            dgvPOAsummary.Size = new Size(666, 150);
            dgvPOAsummary.TabIndex = 10;
            // 
            // ReimbursementFormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(816, 523);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReimbursementFormStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReimbursementFormStudent";
            Load += ReimbursementFormStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReimbursementEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPOAsummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelSelectFromPOA;
        private Label labelReimbursementEntry;
        private Button btnSubmitReport;
        private ComboBox cmbPOA;
        private Button btnUploadReceipts;
        private Label labelPOA;
        private DataGridView dgvReimbursementEntry;
        private DataGridView dgvPOAsummary;
    }
}