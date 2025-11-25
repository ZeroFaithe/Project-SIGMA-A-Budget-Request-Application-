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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            // dgvPOASummary
            // 
            dgvPOASummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPOASummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPOASummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPOASummary.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPOASummary.EnableHeadersVisualStyles = false;
            dgvPOASummary.Location = new Point(42, 74);
            dgvPOASummary.Margin = new Padding(2);
            dgvPOASummary.Name = "dgvPOASummary";
            dgvPOASummary.RowHeadersWidth = 62;
            dgvPOASummary.Size = new Size(853, 409);
            dgvPOASummary.TabIndex = 1;
            dgvPOASummary.CellClick += dgvPOASummary_CellClick;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.PowderBlue;
            btnEdit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(42, 673);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(167, 66);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDIT ENTRY";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnPOANewEntry
            // 
            btnPOANewEntry.BackColor = Color.FromArgb(255, 128, 128);
            btnPOANewEntry.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPOANewEntry.Location = new Point(733, 673);
            btnPOANewEntry.Margin = new Padding(2);
            btnPOANewEntry.Name = "btnPOANewEntry";
            btnPOANewEntry.Size = new Size(162, 66);
            btnPOANewEntry.TabIndex = 3;
            btnPOANewEntry.Text = "ADD NEW ENTRY";
            btnPOANewEntry.UseVisualStyleBackColor = false;
            btnPOANewEntry.Click += button1_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(239, 673);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 66);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnApprovedPOA
            // 
            btnApprovedPOA.BackColor = Color.PaleGreen;
            btnApprovedPOA.FlatAppearance.BorderSize = 0;
            btnApprovedPOA.FlatStyle = FlatStyle.Flat;
            btnApprovedPOA.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprovedPOA.Location = new Point(41, 39);
            btnApprovedPOA.Margin = new Padding(0);
            btnApprovedPOA.Name = "btnApprovedPOA";
            btnApprovedPOA.Size = new Size(104, 34);
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
            btnPendingPOA.Location = new Point(145, 39);
            btnPendingPOA.Margin = new Padding(0);
            btnPendingPOA.Name = "btnPendingPOA";
            btnPendingPOA.Size = new Size(104, 34);
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
            btnToRevisePOA.Location = new Point(248, 39);
            btnToRevisePOA.Margin = new Padding(0);
            btnToRevisePOA.Name = "btnToRevisePOA";
            btnToRevisePOA.Size = new Size(104, 34);
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
            btnRejectedPOA.Location = new Point(352, 39);
            btnRejectedPOA.Margin = new Padding(0);
            btnRejectedPOA.Name = "btnRejectedPOA";
            btnRejectedPOA.Size = new Size(104, 34);
            btnRejectedPOA.TabIndex = 8;
            btnRejectedPOA.Text = "REJECTED";
            btnRejectedPOA.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 494);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 9;
            label1.Text = "REMARKS";
            // 
            // dgvRemarks
            // 
            dgvRemarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRemarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRemarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRemarks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRemarks.EnableHeadersVisualStyles = false;
            dgvRemarks.Location = new Point(42, 518);
            dgvRemarks.Margin = new Padding(2);
            dgvRemarks.Name = "dgvRemarks";
            dgvRemarks.RowHeadersWidth = 62;
            dgvRemarks.Size = new Size(853, 138);
            dgvRemarks.TabIndex = 10;
            // 
            // ManagePOA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 778);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ManagePOA";
            Text = "ManagePOA";
            ((System.ComponentModel.ISupportInitialize)dgvPOASummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRemarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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