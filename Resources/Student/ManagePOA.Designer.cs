namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class ManagePOA
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
            txtSearch = new TextBox();
            dgvPOASummary = new DataGridView();
            btnEdit = new Button();
            btnPOANewEntry = new Button();
            btnDelete = new Button();
            btnApprovedPOA = new Button();
            btnPendingPOA = new Button();
            btnToRevisePOA = new Button();
            btnRejectedPOA = new Button();
            label1 = new Label();
            dgvRemarks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPOASummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRemarks).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(682, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(436, 37);
            txtSearch.TabIndex = 0;
            // 
            // dgvPOASummary
            // 
            dgvPOASummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPOASummary.Location = new Point(52, 92);
            dgvPOASummary.Name = "dgvPOASummary";
            dgvPOASummary.RowHeadersWidth = 62;
            dgvPOASummary.Size = new Size(1066, 511);
            dgvPOASummary.TabIndex = 1;
            dgvPOASummary.CellClick += dgvPOASummary_CellClick;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.PowderBlue;
            btnEdit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(52, 841);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(209, 83);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDIT ENTRY";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnPOANewEntry
            // 
            btnPOANewEntry.BackColor = Color.FromArgb(255, 128, 128);
            btnPOANewEntry.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPOANewEntry.Location = new Point(916, 841);
            btnPOANewEntry.Name = "btnPOANewEntry";
            btnPOANewEntry.Size = new Size(202, 83);
            btnPOANewEntry.TabIndex = 3;
            btnPOANewEntry.Text = "ADD NEW ENTRY";
            btnPOANewEntry.UseVisualStyleBackColor = false;
            btnPOANewEntry.Click += button1_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(299, 841);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 83);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnApprovedPOA
            // 
            btnApprovedPOA.BackColor = Color.PaleGreen;
            btnApprovedPOA.FlatAppearance.BorderSize = 0;
            btnApprovedPOA.FlatStyle = FlatStyle.Flat;
            btnApprovedPOA.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprovedPOA.Location = new Point(51, 49);
            btnApprovedPOA.Margin = new Padding(0);
            btnApprovedPOA.Name = "btnApprovedPOA";
            btnApprovedPOA.Size = new Size(130, 42);
            btnApprovedPOA.TabIndex = 5;
            btnApprovedPOA.Text = "APPROVED";
            btnApprovedPOA.UseVisualStyleBackColor = false;
            // 
            // btnPendingPOA
            // 
            btnPendingPOA.BackColor = Color.NavajoWhite;
            btnPendingPOA.FlatAppearance.BorderSize = 0;
            btnPendingPOA.FlatStyle = FlatStyle.Flat;
            btnPendingPOA.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendingPOA.Location = new Point(181, 49);
            btnPendingPOA.Margin = new Padding(0);
            btnPendingPOA.Name = "btnPendingPOA";
            btnPendingPOA.Size = new Size(130, 42);
            btnPendingPOA.TabIndex = 6;
            btnPendingPOA.Text = "PENDING";
            btnPendingPOA.UseVisualStyleBackColor = false;
            // 
            // btnToRevisePOA
            // 
            btnToRevisePOA.BackColor = Color.LightSkyBlue;
            btnToRevisePOA.FlatAppearance.BorderSize = 0;
            btnToRevisePOA.FlatStyle = FlatStyle.Flat;
            btnToRevisePOA.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToRevisePOA.Location = new Point(310, 49);
            btnToRevisePOA.Margin = new Padding(0);
            btnToRevisePOA.Name = "btnToRevisePOA";
            btnToRevisePOA.Size = new Size(130, 42);
            btnToRevisePOA.TabIndex = 7;
            btnToRevisePOA.Text = "TO REVISE";
            btnToRevisePOA.UseVisualStyleBackColor = false;
            // 
            // btnRejectedPOA
            // 
            btnRejectedPOA.BackColor = Color.LightCoral;
            btnRejectedPOA.FlatAppearance.BorderSize = 0;
            btnRejectedPOA.FlatStyle = FlatStyle.Flat;
            btnRejectedPOA.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejectedPOA.Location = new Point(440, 49);
            btnRejectedPOA.Margin = new Padding(0);
            btnRejectedPOA.Name = "btnRejectedPOA";
            btnRejectedPOA.Size = new Size(130, 42);
            btnRejectedPOA.TabIndex = 8;
            btnRejectedPOA.Text = "REJECTED";
            btnRejectedPOA.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 618);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 9;
            label1.Text = "REMARKS";
            // 
            // dgvRemarks
            // 
            dgvRemarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRemarks.Location = new Point(52, 648);
            dgvRemarks.Name = "dgvRemarks";
            dgvRemarks.RowHeadersWidth = 62;
            dgvRemarks.Size = new Size(1066, 172);
            dgvRemarks.TabIndex = 10;
            // 
            // ManagePOA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 972);
            Controls.Add(dgvRemarks);
            Controls.Add(label1);
            Controls.Add(btnRejectedPOA);
            Controls.Add(btnToRevisePOA);
            Controls.Add(btnPendingPOA);
            Controls.Add(btnApprovedPOA);
            Controls.Add(btnDelete);
            Controls.Add(btnPOANewEntry);
            Controls.Add(btnEdit);
            Controls.Add(dgvPOASummary);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagePOA";
            Text = "ManagePOA";
            ((System.ComponentModel.ISupportInitialize)dgvPOASummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRemarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvPOASummary;
        private Button btnEdit;
        private Button btnPOANewEntry;
        private Button btnDelete;
        private Button btnApprovedPOA;
        private Button btnPendingPOA;
        private Button btnToRevisePOA;
        private Button btnRejectedPOA;
        private Label label1;
        private DataGridView dgvRemarks;
    }
}