namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Student
{
    partial class ManageBudget
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
            dgvRemarks = new DataGridView();
            label1 = new Label();
            btnRejected = new Button();
            btnToRevise = new Button();
            btnPending = new Button();
            btnApproved = new Button();
            btnPOANewEntry = new Button();
            btnEditRequest = new Button();
            dgvMyRequests = new DataGridView();
            dgvBreakdown = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRemarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).BeginInit();
            SuspendLayout();
            // 
            // dgvRemarks
            // 
            dgvRemarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRemarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRemarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRemarks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRemarks.EnableHeadersVisualStyles = false;
            dgvRemarks.Location = new Point(32, 521);
            dgvRemarks.Margin = new Padding(2);
            dgvRemarks.Name = "dgvRemarks";
            dgvRemarks.RowHeadersWidth = 62;
            dgvRemarks.Size = new Size(853, 113);
            dgvRemarks.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 494);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 18);
            label1.TabIndex = 18;
            label1.Text = "ADMIN REMARKS";
            // 
            // btnRejected
            // 
            btnRejected.BackColor = Color.LightCoral;
            btnRejected.FlatAppearance.BorderSize = 0;
            btnRejected.FlatStyle = FlatStyle.Flat;
            btnRejected.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejected.Location = new Point(342, 17);
            btnRejected.Margin = new Padding(0);
            btnRejected.Name = "btnRejected";
            btnRejected.Size = new Size(104, 34);
            btnRejected.TabIndex = 17;
            btnRejected.Text = "REJECTED";
            btnRejected.UseVisualStyleBackColor = false;
            btnRejected.Click += btnRejected_Click;
            // 
            // btnToRevise
            // 
            btnToRevise.BackColor = Color.LightSkyBlue;
            btnToRevise.FlatAppearance.BorderSize = 0;
            btnToRevise.FlatStyle = FlatStyle.Flat;
            btnToRevise.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToRevise.Location = new Point(238, 17);
            btnToRevise.Margin = new Padding(0);
            btnToRevise.Name = "btnToRevise";
            btnToRevise.Size = new Size(104, 34);
            btnToRevise.TabIndex = 16;
            btnToRevise.Text = "TO REVISE";
            btnToRevise.UseVisualStyleBackColor = false;
            btnToRevise.Click += btnToRevise_Click;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.NavajoWhite;
            btnPending.FlatAppearance.BorderSize = 0;
            btnPending.FlatStyle = FlatStyle.Flat;
            btnPending.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPending.Location = new Point(135, 17);
            btnPending.Margin = new Padding(0);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(104, 34);
            btnPending.TabIndex = 15;
            btnPending.Text = "PENDING";
            btnPending.UseVisualStyleBackColor = false;
            btnPending.Click += btnPending_Click;
            // 
            // btnApproved
            // 
            btnApproved.BackColor = Color.PaleGreen;
            btnApproved.FlatAppearance.BorderSize = 0;
            btnApproved.FlatStyle = FlatStyle.Flat;
            btnApproved.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApproved.Location = new Point(31, 17);
            btnApproved.Margin = new Padding(0);
            btnApproved.Name = "btnApproved";
            btnApproved.Size = new Size(104, 34);
            btnApproved.TabIndex = 14;
            btnApproved.Text = "APPROVED";
            btnApproved.UseVisualStyleBackColor = false;
            btnApproved.Click += btnApproved_Click;
            // 
            // btnPOANewEntry
            // 
            btnPOANewEntry.BackColor = Color.FromArgb(255, 128, 128);
            btnPOANewEntry.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPOANewEntry.Location = new Point(723, 650);
            btnPOANewEntry.Margin = new Padding(2);
            btnPOANewEntry.Name = "btnPOANewEntry";
            btnPOANewEntry.Size = new Size(162, 66);
            btnPOANewEntry.TabIndex = 13;
            btnPOANewEntry.Text = "ADD NEW ENTRY";
            btnPOANewEntry.UseVisualStyleBackColor = false;
            btnPOANewEntry.Click += btnPOANewEntry_Click;
            // 
            // btnEditRequest
            // 
            btnEditRequest.BackColor = Color.PowderBlue;
            btnEditRequest.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditRequest.Location = new Point(32, 650);
            btnEditRequest.Margin = new Padding(2);
            btnEditRequest.Name = "btnEditRequest";
            btnEditRequest.Size = new Size(167, 66);
            btnEditRequest.TabIndex = 12;
            btnEditRequest.Text = "EDIT ENTRY";
            btnEditRequest.UseVisualStyleBackColor = false;
            btnEditRequest.Click += btnEditRequest_Click;
            // 
            // dgvMyRequests
            // 
            dgvMyRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMyRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMyRequests.EnableHeadersVisualStyles = false;
            dgvMyRequests.Location = new Point(32, 51);
            dgvMyRequests.Margin = new Padding(2);
            dgvMyRequests.Name = "dgvMyRequests";
            dgvMyRequests.RowHeadersWidth = 62;
            dgvMyRequests.Size = new Size(853, 198);
            dgvMyRequests.TabIndex = 11;
            dgvMyRequests.CellClick += dgvMyRequests_CellClick;
            // 
            // dgvBreakdown
            // 
            dgvBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBreakdown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakdown.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBreakdown.EnableHeadersVisualStyles = false;
            dgvBreakdown.Location = new Point(31, 280);
            dgvBreakdown.Margin = new Padding(2);
            dgvBreakdown.Name = "dgvBreakdown";
            dgvBreakdown.RowHeadersWidth = 62;
            dgvBreakdown.Size = new Size(853, 198);
            dgvBreakdown.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 260);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 18);
            label2.TabIndex = 21;
            label2.Text = "BUDGET BREAKDOWN";
            // 
            // ManageBudget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 733);
            Controls.Add(label2);
            Controls.Add(dgvBreakdown);
            Controls.Add(dgvRemarks);
            Controls.Add(label1);
            Controls.Add(btnRejected);
            Controls.Add(btnToRevise);
            Controls.Add(btnPending);
            Controls.Add(btnApproved);
            Controls.Add(btnPOANewEntry);
            Controls.Add(btnEditRequest);
            Controls.Add(dgvMyRequests);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ManageBudget";
            Text = "ManageBudget";
            ((System.ComponentModel.ISupportInitialize)dgvRemarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRemarks;
        private Label label1;
        private Button btnRejected;
        private Button btnToRevise;
        private Button btnPending;
        private Button btnApproved;
        private Button btnPOANewEntry;
        private Button btnEditRequest;
        private DataGridView dgvMyRequests;
        private DataGridView dgvBreakdown;
        private Label label2;
    }
}