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
            dgvRemarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRemarks.Location = new Point(40, 651);
            dgvRemarks.Name = "dgvRemarks";
            dgvRemarks.RowHeadersWidth = 62;
            dgvRemarks.Size = new Size(1066, 141);
            dgvRemarks.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 617);
            label1.Name = "label1";
            label1.Size = new Size(153, 22);
            label1.TabIndex = 18;
            label1.Text = "ADMIN REMARKS";
            // 
            // btnRejected
            // 
            btnRejected.BackColor = Color.LightCoral;
            btnRejected.FlatAppearance.BorderSize = 0;
            btnRejected.FlatStyle = FlatStyle.Flat;
            btnRejected.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejected.Location = new Point(428, 21);
            btnRejected.Margin = new Padding(0);
            btnRejected.Name = "btnRejected";
            btnRejected.Size = new Size(130, 42);
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
            btnToRevise.Location = new Point(298, 21);
            btnToRevise.Margin = new Padding(0);
            btnToRevise.Name = "btnToRevise";
            btnToRevise.Size = new Size(130, 42);
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
            btnPending.Location = new Point(169, 21);
            btnPending.Margin = new Padding(0);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(130, 42);
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
            btnApproved.Location = new Point(39, 21);
            btnApproved.Margin = new Padding(0);
            btnApproved.Name = "btnApproved";
            btnApproved.Size = new Size(130, 42);
            btnApproved.TabIndex = 14;
            btnApproved.Text = "APPROVED";
            btnApproved.UseVisualStyleBackColor = false;
            btnApproved.Click += btnApproved_Click;
            // 
            // btnPOANewEntry
            // 
            btnPOANewEntry.BackColor = Color.FromArgb(255, 128, 128);
            btnPOANewEntry.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPOANewEntry.Location = new Point(904, 813);
            btnPOANewEntry.Name = "btnPOANewEntry";
            btnPOANewEntry.Size = new Size(202, 83);
            btnPOANewEntry.TabIndex = 13;
            btnPOANewEntry.Text = "ADD NEW ENTRY";
            btnPOANewEntry.UseVisualStyleBackColor = false;
            btnPOANewEntry.Click += btnPOANewEntry_Click;
            // 
            // btnEditRequest
            // 
            btnEditRequest.BackColor = Color.PowderBlue;
            btnEditRequest.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditRequest.Location = new Point(40, 813);
            btnEditRequest.Name = "btnEditRequest";
            btnEditRequest.Size = new Size(209, 83);
            btnEditRequest.TabIndex = 12;
            btnEditRequest.Text = "EDIT ENTRY";
            btnEditRequest.UseVisualStyleBackColor = false;
            btnEditRequest.Click += btnEditRequest_Click;
            // 
            // dgvMyRequests
            // 
            dgvMyRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyRequests.Location = new Point(40, 64);
            dgvMyRequests.Name = "dgvMyRequests";
            dgvMyRequests.RowHeadersWidth = 62;
            dgvMyRequests.Size = new Size(1066, 247);
            dgvMyRequests.TabIndex = 11;
            dgvMyRequests.CellClick += dgvMyRequests_CellClick;
            // 
            // dgvBreakdown
            // 
            dgvBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakdown.Location = new Point(39, 350);
            dgvBreakdown.Name = "dgvBreakdown";
            dgvBreakdown.RowHeadersWidth = 62;
            dgvBreakdown.Size = new Size(1066, 247);
            dgvBreakdown.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 325);
            label2.Name = "label2";
            label2.Size = new Size(192, 22);
            label2.TabIndex = 21;
            label2.Text = "BUDGET BREAKDOWN";
            // 
            // ManageBudget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 916);
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