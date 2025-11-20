namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class ReimbursementFormAdmin
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
            cmbPOA = new ComboBox();
            labelFile = new Label();
            labelDateSubmitted = new Label();
            labelStatus = new Label();
            dgvReimbursements = new DataGridView();
            labelRemarks = new Label();
            panel1 = new Panel();
            txtRemarks = new TextBox();
            btnDeclineReport = new Button();
            btnApproveReport = new Button();
            btnSaveReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReimbursements).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPOA
            // 
            cmbPOA.FormattingEnabled = true;
            cmbPOA.Location = new Point(541, 78);
            cmbPOA.Name = "cmbPOA";
            cmbPOA.Size = new Size(196, 23);
            cmbPOA.TabIndex = 0;
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFile.Location = new Point(94, 116);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(36, 15);
            labelFile.TabIndex = 22;
            labelFile.Text = "FILE";
            // 
            // labelDateSubmitted
            // 
            labelDateSubmitted.AutoSize = true;
            labelDateSubmitted.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDateSubmitted.Location = new Point(323, 116);
            labelDateSubmitted.Name = "labelDateSubmitted";
            labelDateSubmitted.Size = new Size(124, 15);
            labelDateSubmitted.TabIndex = 23;
            labelDateSubmitted.Text = "DATE SUBMITTED";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(645, 116);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(60, 15);
            labelStatus.TabIndex = 24;
            labelStatus.Text = "STATUS";
            // 
            // dgvReimbursements
            // 
            dgvReimbursements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReimbursements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReimbursements.Location = new Point(46, 146);
            dgvReimbursements.Name = "dgvReimbursements";
            dgvReimbursements.RowHeadersWidth = 51;
            dgvReimbursements.Size = new Size(690, 150);
            dgvReimbursements.TabIndex = 25;
            // 
            // labelRemarks
            // 
            labelRemarks.AutoSize = true;
            labelRemarks.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRemarks.Location = new Point(46, 344);
            labelRemarks.Name = "labelRemarks";
            labelRemarks.Size = new Size(260, 15);
            labelRemarks.TabIndex = 30;
            labelRemarks.Text = "REMARKS/COMMENTS/ SUGGESTIONS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtRemarks);
            panel1.Controls.Add(labelRemarks);
            panel1.Controls.Add(btnDeclineReport);
            panel1.Controls.Add(btnApproveReport);
            panel1.Controls.Add(btnSaveReport);
            panel1.Controls.Add(cmbPOA);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(labelDateSubmitted);
            panel1.Controls.Add(dgvReimbursements);
            panel1.Controls.Add(labelFile);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 581);
            panel1.TabIndex = 15;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(46, 376);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(413, 103);
            txtRemarks.TabIndex = 33;
            // 
            // btnDeclineReport
            // 
            btnDeclineReport.BackColor = SystemColors.ControlLight;
            btnDeclineReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnDeclineReport.Location = new Point(497, 435);
            btnDeclineReport.Name = "btnDeclineReport";
            btnDeclineReport.Size = new Size(92, 44);
            btnDeclineReport.TabIndex = 32;
            btnDeclineReport.Text = "DECLINE REPORT";
            btnDeclineReport.UseVisualStyleBackColor = false;
            // 
            // btnApproveReport
            // 
            btnApproveReport.BackColor = SystemColors.ControlLight;
            btnApproveReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnApproveReport.Location = new Point(497, 376);
            btnApproveReport.Name = "btnApproveReport";
            btnApproveReport.Size = new Size(92, 44);
            btnApproveReport.TabIndex = 31;
            btnApproveReport.Text = "APPROVE REPORT";
            btnApproveReport.UseVisualStyleBackColor = false;
            // 
            // btnSaveReport
            // 
            btnSaveReport.BackColor = SystemColors.ControlLight;
            btnSaveReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSaveReport.Location = new Point(645, 376);
            btnSaveReport.Name = "btnSaveReport";
            btnSaveReport.Size = new Size(92, 44);
            btnSaveReport.TabIndex = 30;
            btnSaveReport.Text = "SAVE REPORT AS";
            btnSaveReport.UseVisualStyleBackColor = false;
            // 
            // ReimbursementFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 584);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReimbursementFormAdmin";
            Text = "Reimbursement Form";
            ((System.ComponentModel.ISupportInitialize)dgvReimbursements).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelRemarks;
        private DataGridView dgvReimbursements;
        private Label labelStatus;
        private Label labelDateSubmitted;
        private Label labelFile;
        private ComboBox cmbPOA;
        private Panel panel1;
        private TextBox txtRemarks;
        private Button btnDeclineReport;
        private Button btnApproveReport;
        private Button btnSaveReport;
    }
}