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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dgvPendingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPendingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPendingRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPendingRequests.EnableHeadersVisualStyles = false;
            dgvPendingRequests.GridColor = SystemColors.ScrollBar;
            dgvPendingRequests.Location = new Point(19, 66);
            dgvPendingRequests.Margin = new Padding(2);
            dgvPendingRequests.Name = "dgvPendingRequests";
            dgvPendingRequests.RowHeadersWidth = 62;
            dgvPendingRequests.Size = new Size(870, 180);
            dgvPendingRequests.TabIndex = 0;
            dgvPendingRequests.CellClick += dgvPendingRequests_CellClick_1;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.SandyBrown;
            btnApprove.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(754, 590);
            btnApprove.Margin = new Padding(2);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(135, 93);
            btnApprove.TabIndex = 22;
            btnApprove.Text = "APPROVE";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.SandyBrown;
            btnReject.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.Location = new Point(597, 641);
            btnReject.Margin = new Padding(2);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(147, 60);
            btnReject.TabIndex = 21;
            btnReject.Text = "REJECT";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnToRevise
            // 
            btnToRevise.BackColor = Color.SandyBrown;
            btnToRevise.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToRevise.Location = new Point(597, 576);
            btnToRevise.Margin = new Padding(2);
            btnToRevise.Name = "btnToRevise";
            btnToRevise.Size = new Size(147, 60);
            btnToRevise.TabIndex = 20;
            btnToRevise.Text = "TO REVISE";
            btnToRevise.UseVisualStyleBackColor = false;
            btnToRevise.Click += btnToRevise_Click;
            // 
            // rtbRemarks
            // 
            rtbRemarks.BorderStyle = BorderStyle.FixedSingle;
            rtbRemarks.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbRemarks.Location = new Point(19, 576);
            rtbRemarks.Margin = new Padding(2);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(561, 126);
            rtbRemarks.TabIndex = 18;
            rtbRemarks.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 554);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 19);
            label8.TabIndex = 19;
            label8.Text = "REMARKS";
            // 
            // dgvBreakdown
            // 
            dgvBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBreakdown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBreakdown.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBreakdown.EnableHeadersVisualStyles = false;
            dgvBreakdown.GridColor = SystemColors.ScrollBar;
            dgvBreakdown.Location = new Point(23, 277);
            dgvBreakdown.Margin = new Padding(2);
            dgvBreakdown.Name = "dgvBreakdown";
            dgvBreakdown.RowHeadersWidth = 62;
            dgvBreakdown.Size = new Size(870, 259);
            dgvBreakdown.TabIndex = 23;
            // 
            // btnRejectedBR
            // 
            btnRejectedBR.BackColor = Color.LightCoral;
            btnRejectedBR.FlatAppearance.BorderSize = 0;
            btnRejectedBR.FlatStyle = FlatStyle.Flat;
            btnRejectedBR.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejectedBR.Location = new Point(330, 31);
            btnRejectedBR.Margin = new Padding(0);
            btnRejectedBR.Name = "btnRejectedBR";
            btnRejectedBR.Size = new Size(104, 34);
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
            btnToReviseBR.Location = new Point(226, 31);
            btnToReviseBR.Margin = new Padding(0);
            btnToReviseBR.Name = "btnToReviseBR";
            btnToReviseBR.Size = new Size(104, 34);
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
            btnPendingBR.Location = new Point(18, 31);
            btnPendingBR.Margin = new Padding(0);
            btnPendingBR.Name = "btnPendingBR";
            btnPendingBR.Size = new Size(104, 34);
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
            btnApprovedBR.Location = new Point(122, 31);
            btnApprovedBR.Margin = new Padding(0);
            btnApprovedBR.Name = "btnApprovedBR";
            btnApprovedBR.Size = new Size(104, 34);
            btnApprovedBR.TabIndex = 24;
            btnApprovedBR.Text = "APPROVED";
            btnApprovedBR.UseVisualStyleBackColor = false;
            btnApprovedBR.Click += btnApprovedBR_Click;
            // 
            // BudgetRequestAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 733);
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
            Margin = new Padding(2);
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