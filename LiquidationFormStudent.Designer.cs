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
            btnDashboard = new Button();
            btnMainPage = new Button();
            btnBudgetRequests = new Button();
            btnReimbursementRequests = new Button();
            btnFundTracking = new Button();
            labelSelectFromPOA = new Label();
            panel1 = new Panel();
            dgvLiquidationSummary = new DataGridView();
            dgvBudgetSummary = new DataGridView();
            btnSubmitReport = new Button();
            btnUploadReceipts = new Button();
            cmbPOA = new ComboBox();
            pbLogo = new PictureBox();
            pbProfile = new PictureBox();
            labelStudent = new Label();
            pbSettings = new PictureBox();
            labelLiquidationReport = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSettings).BeginInit();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnDashboard.Location = new Point(12, 94);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(139, 39);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.FlatAppearance.BorderSize = 0;
            btnMainPage.FlatStyle = FlatStyle.Flat;
            btnMainPage.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnMainPage.Location = new Point(12, 145);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(139, 39);
            btnMainPage.TabIndex = 1;
            btnMainPage.Text = "MAIN PAGE";
            btnMainPage.TextAlign = ContentAlignment.MiddleLeft;
            btnMainPage.UseVisualStyleBackColor = true;
            // 
            // btnBudgetRequests
            // 
            btnBudgetRequests.FlatAppearance.BorderSize = 0;
            btnBudgetRequests.FlatStyle = FlatStyle.Flat;
            btnBudgetRequests.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnBudgetRequests.Location = new Point(12, 198);
            btnBudgetRequests.Name = "btnBudgetRequests";
            btnBudgetRequests.Size = new Size(139, 39);
            btnBudgetRequests.TabIndex = 2;
            btnBudgetRequests.Text = "BUDGET REQUESTS";
            btnBudgetRequests.TextAlign = ContentAlignment.MiddleLeft;
            btnBudgetRequests.UseVisualStyleBackColor = true;
            // 
            // btnReimbursementRequests
            // 
            btnReimbursementRequests.FlatAppearance.BorderSize = 0;
            btnReimbursementRequests.FlatStyle = FlatStyle.Flat;
            btnReimbursementRequests.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnReimbursementRequests.Location = new Point(12, 248);
            btnReimbursementRequests.Name = "btnReimbursementRequests";
            btnReimbursementRequests.Size = new Size(139, 39);
            btnReimbursementRequests.TabIndex = 3;
            btnReimbursementRequests.Text = "REIMBURESMENT REQUESTS";
            btnReimbursementRequests.TextAlign = ContentAlignment.MiddleLeft;
            btnReimbursementRequests.UseVisualStyleBackColor = true;
            // 
            // btnFundTracking
            // 
            btnFundTracking.FlatAppearance.BorderSize = 0;
            btnFundTracking.FlatStyle = FlatStyle.Flat;
            btnFundTracking.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnFundTracking.Location = new Point(12, 298);
            btnFundTracking.Name = "btnFundTracking";
            btnFundTracking.Size = new Size(139, 39);
            btnFundTracking.TabIndex = 4;
            btnFundTracking.Text = "FUND TRACKING";
            btnFundTracking.TextAlign = ContentAlignment.MiddleLeft;
            btnFundTracking.UseVisualStyleBackColor = true;
            // 
            // labelSelectFromPOA
            // 
            labelSelectFromPOA.AutoSize = true;
            labelSelectFromPOA.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSelectFromPOA.Location = new Point(207, 106);
            labelSelectFromPOA.Name = "labelSelectFromPOA";
            labelSelectFromPOA.Size = new Size(136, 15);
            labelSelectFromPOA.TabIndex = 6;
            labelSelectFromPOA.Text = "SELECT FROM POA:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(dgvLiquidationSummary);
            panel1.Controls.Add(dgvBudgetSummary);
            panel1.Controls.Add(btnSubmitReport);
            panel1.Controls.Add(btnUploadReceipts);
            panel1.Location = new Point(207, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 500);
            panel1.TabIndex = 7;
            // 
            // dgvLiquidationSummary
            // 
            dgvLiquidationSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLiquidationSummary.Location = new Point(44, 228);
            dgvLiquidationSummary.Name = "dgvLiquidationSummary";
            dgvLiquidationSummary.Size = new Size(666, 175);
            dgvLiquidationSummary.TabIndex = 12;
            // 
            // dgvBudgetSummary
            // 
            dgvBudgetSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgetSummary.Location = new Point(44, 42);
            dgvBudgetSummary.Name = "dgvBudgetSummary";
            dgvBudgetSummary.Size = new Size(666, 175);
            dgvBudgetSummary.TabIndex = 11;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSubmitReport.Location = new Point(618, 428);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(92, 44);
            btnSubmitReport.TabIndex = 10;
            btnSubmitReport.Text = "SUBMIT REPORT";
            btnSubmitReport.UseVisualStyleBackColor = true;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // btnUploadReceipts
            // 
            btnUploadReceipts.Font = new Font("Arial Rounded MT Bold", 9F);
            btnUploadReceipts.Location = new Point(44, 428);
            btnUploadReceipts.Name = "btnUploadReceipts";
            btnUploadReceipts.Size = new Size(92, 44);
            btnUploadReceipts.TabIndex = 9;
            btnUploadReceipts.Text = "UPLOAD RECEIPTS";
            btnUploadReceipts.UseVisualStyleBackColor = true;
            btnUploadReceipts.Click += btnUploadReceipts_Click;
            // 
            // cmbPOA
            // 
            cmbPOA.FormattingEnabled = true;
            cmbPOA.Location = new Point(361, 98);
            cmbPOA.Name = "cmbPOA";
            cmbPOA.Size = new Size(194, 23);
            cmbPOA.TabIndex = 8;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.AUF_CCS_Logo;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 76);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            // 
            // pbProfile
            // 
            pbProfile.Image = Properties.Resources.person;
            pbProfile.Location = new Point(763, 12);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(58, 50);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 10;
            pbProfile.TabStop = false;
            // 
            // labelStudent
            // 
            labelStudent.AutoSize = true;
            labelStudent.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudent.Location = new Point(827, 39);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(86, 18);
            labelStudent.TabIndex = 11;
            labelStudent.Text = "STUDENT";
            // 
            // pbSettings
            // 
            pbSettings.Image = Properties.Resources.settings;
            pbSettings.Location = new Point(919, 12);
            pbSettings.Name = "pbSettings";
            pbSettings.Size = new Size(64, 50);
            pbSettings.SizeMode = PictureBoxSizeMode.Zoom;
            pbSettings.TabIndex = 12;
            pbSettings.TabStop = false;
            // 
            // labelLiquidationReport
            // 
            labelLiquidationReport.Anchor = AnchorStyles.None;
            labelLiquidationReport.AutoSize = true;
            labelLiquidationReport.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLiquidationReport.Location = new Point(361, 30);
            labelLiquidationReport.Name = "labelLiquidationReport";
            labelLiquidationReport.Size = new Size(223, 22);
            labelLiquidationReport.TabIndex = 13;
            labelLiquidationReport.Text = "LIQUIDATION REPORT";
            // 
            // LiquidationFormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(labelLiquidationReport);
            Controls.Add(pbSettings);
            Controls.Add(labelStudent);
            Controls.Add(pbProfile);
            Controls.Add(pbLogo);
            Controls.Add(cmbPOA);
            Controls.Add(panel1);
            Controls.Add(labelSelectFromPOA);
            Controls.Add(btnFundTracking);
            Controls.Add(btnReimbursementRequests);
            Controls.Add(btnBudgetRequests);
            Controls.Add(btnMainPage);
            Controls.Add(btnDashboard);
            Name = "LiquidationFormStudent";
            Text = "Liquidation Form";
            Load += LiquidationFormStudent_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSettings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDashboard;
        private Button btnMainPage;
        private Button btnBudgetRequests;
        private Button btnReimbursementRequests;
        private Button btnFundTracking;
        private Label labelSelectFromPOA;
        private Panel panel1;
        private Button btnSubmitReport;
        private Button btnUploadReceipts;
        private ComboBox cmbPOA;
        private DataGridView dgvLiquidationSummary;
        private DataGridView dgvBudgetSummary;
        private PictureBox pbLogo;
        private PictureBox pbProfile;
        private Label labelStudent;
        private PictureBox pbSettings;
        private Label labelLiquidationReport;
    }
}