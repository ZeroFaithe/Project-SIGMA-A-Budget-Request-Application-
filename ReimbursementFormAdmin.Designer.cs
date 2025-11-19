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
            cmbPOA.Location = new Point(618, 104);
            cmbPOA.Margin = new Padding(3, 4, 3, 4);
            cmbPOA.Name = "cmbPOA";
            cmbPOA.Size = new Size(223, 28);
            cmbPOA.TabIndex = 0;
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFile.Location = new Point(108, 155);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(45, 20);
            labelFile.TabIndex = 22;
            labelFile.Text = "FILE";
            // 
            // labelDateSubmitted
            // 
            labelDateSubmitted.AutoSize = true;
            labelDateSubmitted.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDateSubmitted.Location = new Point(369, 155);
            labelDateSubmitted.Name = "labelDateSubmitted";
            labelDateSubmitted.Size = new Size(161, 20);
            labelDateSubmitted.TabIndex = 23;
            labelDateSubmitted.Text = "DATE SUBMITTED";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(737, 154);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(78, 20);
            labelStatus.TabIndex = 24;
            labelStatus.Text = "STATUS";
            // 
            // dgvReimbursements
            // 
            dgvReimbursements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReimbursements.Location = new Point(53, 195);
            dgvReimbursements.Margin = new Padding(3, 4, 3, 4);
            dgvReimbursements.Name = "dgvReimbursements";
            dgvReimbursements.RowHeadersWidth = 51;
            dgvReimbursements.Size = new Size(789, 200);
            dgvReimbursements.TabIndex = 25;
            // 
            // labelRemarks
            // 
            labelRemarks.AutoSize = true;
            labelRemarks.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRemarks.Location = new Point(53, 459);
            labelRemarks.Name = "labelRemarks";
            labelRemarks.Size = new Size(333, 20);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 775);
            panel1.TabIndex = 15;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(53, 502);
            txtRemarks.Margin = new Padding(3, 4, 3, 4);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(471, 136);
            txtRemarks.TabIndex = 33;
            // 
            // btnDeclineReport
            // 
            btnDeclineReport.BackColor = SystemColors.ControlLight;
            btnDeclineReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnDeclineReport.Location = new Point(568, 580);
            btnDeclineReport.Margin = new Padding(3, 4, 3, 4);
            btnDeclineReport.Name = "btnDeclineReport";
            btnDeclineReport.Size = new Size(105, 59);
            btnDeclineReport.TabIndex = 32;
            btnDeclineReport.Text = "DECLINE REPORT";
            btnDeclineReport.UseVisualStyleBackColor = false;
            // 
            // btnApproveReport
            // 
            btnApproveReport.BackColor = SystemColors.ControlLight;
            btnApproveReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnApproveReport.Location = new Point(568, 502);
            btnApproveReport.Margin = new Padding(3, 4, 3, 4);
            btnApproveReport.Name = "btnApproveReport";
            btnApproveReport.Size = new Size(105, 59);
            btnApproveReport.TabIndex = 31;
            btnApproveReport.Text = "APPROVE REPORT";
            btnApproveReport.UseVisualStyleBackColor = false;
            // 
            // btnSaveReport
            // 
            btnSaveReport.BackColor = SystemColors.ControlLight;
            btnSaveReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSaveReport.Location = new Point(737, 502);
            btnSaveReport.Margin = new Padding(3, 4, 3, 4);
            btnSaveReport.Name = "btnSaveReport";
            btnSaveReport.Size = new Size(105, 59);
            btnSaveReport.TabIndex = 30;
            btnSaveReport.Text = "SAVE REPORT AS";
            btnSaveReport.UseVisualStyleBackColor = false;
            // 
            // ReimbursementFormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 778);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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