namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Admin
{
    partial class BudgetRequestAdmin
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
            dgvPendingRequests = new DataGridView();
            btnApprove = new Button();
            btnReject = new Button();
            btnToRevise = new Button();
            rtbRemarks = new RichTextBox();
            label8 = new Label();
            dgvBreakdown = new DataGridView();
            btnRejectedBR = new Button();
            btnToReviseBR = new Button();
            btnPendingBR = new Button();
            btnApprovedBR = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPendingRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).BeginInit();
            SuspendLayout();
            // 
            // dgvPendingRequests
            // 
            dgvPendingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingRequests.Location = new Point(24, 82);
            dgvPendingRequests.Name = "dgvPendingRequests";
            dgvPendingRequests.RowHeadersWidth = 62;
            dgvPendingRequests.Size = new Size(1087, 225);
            dgvPendingRequests.TabIndex = 0;
            dgvPendingRequests.CellClick += dgvPendingRequests_CellClick_1;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.SandyBrown;
            btnApprove.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(942, 738);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(169, 116);
            btnApprove.TabIndex = 22;
            btnApprove.Text = "APPROVE";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.SandyBrown;
            btnReject.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.Location = new Point(746, 801);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(184, 75);
            btnReject.TabIndex = 21;
            btnReject.Text = "REJECT";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnToRevise
            // 
            btnToRevise.BackColor = Color.SandyBrown;
            btnToRevise.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToRevise.Location = new Point(746, 720);
            btnToRevise.Name = "btnToRevise";
            btnToRevise.Size = new Size(184, 75);
            btnToRevise.TabIndex = 20;
            btnToRevise.Text = "TO REVISE";
            btnToRevise.UseVisualStyleBackColor = false;
            btnToRevise.Click += btnToRevise_Click;
            // 
            // rtbRemarks
            // 
            rtbRemarks.BorderStyle = BorderStyle.FixedSingle;
            rtbRemarks.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbRemarks.Location = new Point(24, 720);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(700, 156);
            rtbRemarks.TabIndex = 18;
            rtbRemarks.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 692);
            label8.Name = "label8";
            label8.Size = new Size(99, 23);
            label8.TabIndex = 19;
            label8.Text = "REMARKS";
            // 
            // dgvBreakdown
            // 
            dgvBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakdown.Location = new Point(29, 346);
            dgvBreakdown.Name = "dgvBreakdown";
            dgvBreakdown.RowHeadersWidth = 62;
            dgvBreakdown.Size = new Size(1087, 324);
            dgvBreakdown.TabIndex = 23;
            // 
            // btnRejectedBR
            // 
            btnRejectedBR.BackColor = Color.LightCoral;
            btnRejectedBR.FlatAppearance.BorderSize = 0;
            btnRejectedBR.FlatStyle = FlatStyle.Flat;
            btnRejectedBR.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejectedBR.Location = new Point(413, 39);
            btnRejectedBR.Margin = new Padding(0);
            btnRejectedBR.Name = "btnRejectedBR";
            btnRejectedBR.Size = new Size(130, 42);
            btnRejectedBR.TabIndex = 27;
            btnRejectedBR.Text = "REJECTED";
            btnRejectedBR.UseVisualStyleBackColor = false;
            btnRejectedBR.Click += btnRejectedBR_Click;
            // 
            // btnToReviseBR
            // 
            btnToReviseBR.BackColor = Color.LightSkyBlue;
            btnToReviseBR.FlatAppearance.BorderSize = 0;
            btnToReviseBR.FlatStyle = FlatStyle.Flat;
            btnToReviseBR.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToReviseBR.Location = new Point(283, 39);
            btnToReviseBR.Margin = new Padding(0);
            btnToReviseBR.Name = "btnToReviseBR";
            btnToReviseBR.Size = new Size(130, 42);
            btnToReviseBR.TabIndex = 26;
            btnToReviseBR.Text = "TO REVISE";
            btnToReviseBR.UseVisualStyleBackColor = false;
            btnToReviseBR.Click += btnToReviseBR_Click;
            // 
            // btnPendingBR
            // 
            btnPendingBR.BackColor = Color.NavajoWhite;
            btnPendingBR.FlatAppearance.BorderSize = 0;
            btnPendingBR.FlatStyle = FlatStyle.Flat;
            btnPendingBR.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendingBR.Location = new Point(23, 39);
            btnPendingBR.Margin = new Padding(0);
            btnPendingBR.Name = "btnPendingBR";
            btnPendingBR.Size = new Size(130, 42);
            btnPendingBR.TabIndex = 25;
            btnPendingBR.Text = "PENDING";
            btnPendingBR.UseVisualStyleBackColor = false;
            btnPendingBR.Click += btnPendingBR_Click;
            // 
            // btnApprovedBR
            // 
            btnApprovedBR.BackColor = Color.PaleGreen;
            btnApprovedBR.FlatAppearance.BorderSize = 0;
            btnApprovedBR.FlatStyle = FlatStyle.Flat;
            btnApprovedBR.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprovedBR.Location = new Point(153, 39);
            btnApprovedBR.Margin = new Padding(0);
            btnApprovedBR.Name = "btnApprovedBR";
            btnApprovedBR.Size = new Size(130, 42);
            btnApprovedBR.TabIndex = 24;
            btnApprovedBR.Text = "APPROVED";
            btnApprovedBR.UseVisualStyleBackColor = false;
            btnApprovedBR.Click += btnApprovedBR_Click;
            // 
            // BudgetRequestAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 916);
            Controls.Add(btnRejectedBR);
            Controls.Add(btnToReviseBR);
            Controls.Add(btnPendingBR);
            Controls.Add(btnApprovedBR);
            Controls.Add(dgvBreakdown);
            Controls.Add(btnApprove);
            Controls.Add(btnReject);
            Controls.Add(btnToRevise);
            Controls.Add(rtbRemarks);
            Controls.Add(label8);
            Controls.Add(dgvPendingRequests);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BudgetRequestAdmin";
            Text = "BudgetRequestAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvPendingRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPendingRequests;
        private Button btnApprove;
        private Button btnReject;
        private Button btnToRevise;
        private RichTextBox rtbRemarks;
        private Label label8;
        private DataGridView dgvBreakdown;
        private Button btnRejectedBR;
        private Button btnToReviseBR;
        private Button btnPendingBR;
        private Button btnApprovedBR;
    }
}