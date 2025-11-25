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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel1.Location = new Point(37, 26);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 667);
            panel1.TabIndex = 16;
            // 
            // labelSelectFromPOA
            // 
            labelSelectFromPOA.AutoSize = true;
            labelSelectFromPOA.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSelectFromPOA.Location = new Point(73, 39);
            labelSelectFromPOA.Name = "labelSelectFromPOA";
            labelSelectFromPOA.Size = new Size(231, 20);
            labelSelectFromPOA.TabIndex = 7;
            labelSelectFromPOA.Text = "SELECT FROM REQUESTS:";
            // 
            // labelReimbursementEntry
            // 
            labelReimbursementEntry.AutoSize = true;
            labelReimbursementEntry.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReimbursementEntry.Location = new Point(61, 329);
            labelReimbursementEntry.Name = "labelReimbursementEntry";
            labelReimbursementEntry.Size = new Size(221, 20);
            labelReimbursementEntry.TabIndex = 11;
            labelReimbursementEntry.Text = "REIMBURSEMENT ENTRY";
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSubmitReport.Location = new Point(717, 577);
            btnSubmitReport.Margin = new Padding(3, 4, 3, 4);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(105, 59);
            btnSubmitReport.TabIndex = 14;
            btnSubmitReport.Text = "SUBMIT REPORT";
            btnSubmitReport.UseVisualStyleBackColor = true;
            // 
            // cmbPOA
            // 
            cmbPOA.FormattingEnabled = true;
            cmbPOA.Location = new Point(310, 35);
            cmbPOA.Margin = new Padding(3, 4, 3, 4);
            cmbPOA.Name = "cmbPOA";
            cmbPOA.Size = new Size(207, 28);
            cmbPOA.TabIndex = 8;
            // 
            // btnUploadReceipts
            // 
            btnUploadReceipts.Font = new Font("Arial Rounded MT Bold", 9F);
            btnUploadReceipts.Location = new Point(61, 577);
            btnUploadReceipts.Margin = new Padding(3, 4, 3, 4);
            btnUploadReceipts.Name = "btnUploadReceipts";
            btnUploadReceipts.Size = new Size(105, 59);
            btnUploadReceipts.TabIndex = 13;
            btnUploadReceipts.Text = "UPLOAD RECEIPTS";
            btnUploadReceipts.UseVisualStyleBackColor = true;
            // 
            // labelPOA
            // 
            labelPOA.AutoSize = true;
            labelPOA.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPOA.Location = new Point(73, 87);
            labelPOA.Name = "labelPOA";
            labelPOA.Size = new Size(136, 20);
            labelPOA.TabIndex = 9;
            labelPOA.Text = "POA SUMMARY";
            // 
            // dgvReimbursementEntry
            // 
            dgvReimbursementEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReimbursementEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReimbursementEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReimbursementEntry.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReimbursementEntry.EnableHeadersVisualStyles = false;
            dgvReimbursementEntry.Location = new Point(61, 353);
            dgvReimbursementEntry.Margin = new Padding(3, 4, 3, 4);
            dgvReimbursementEntry.Name = "dgvReimbursementEntry";
            dgvReimbursementEntry.RowHeadersWidth = 51;
            dgvReimbursementEntry.Size = new Size(761, 200);
            dgvReimbursementEntry.TabIndex = 12;
            // 
            // dgvPOAsummary
            // 
            dgvPOAsummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPOAsummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPOAsummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPOAsummary.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPOAsummary.EnableHeadersVisualStyles = false;
            dgvPOAsummary.Location = new Point(61, 108);
            dgvPOAsummary.Margin = new Padding(3, 4, 3, 4);
            dgvPOAsummary.Name = "dgvPOAsummary";
            dgvPOAsummary.RowHeadersWidth = 51;
            dgvPOAsummary.Size = new Size(761, 200);
            dgvPOAsummary.TabIndex = 10;
            // 
            // ReimbursementFormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 697);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReimbursementFormStudent";
            Text = "ReimbursementFormStudent";
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