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
            button1 = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPOASummary).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(682, 107);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(436, 37);
            txtSearch.TabIndex = 0;
            // 
            // dgvPOASummary
            // 
            dgvPOASummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPOASummary.Location = new Point(52, 179);
            dgvPOASummary.Name = "dgvPOASummary";
            dgvPOASummary.RowHeadersWidth = 62;
            dgvPOASummary.Size = new Size(1066, 638);
            dgvPOASummary.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 128, 128);
            btnEdit.Location = new Point(52, 841);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 83);
            btnEdit.TabIndex = 2;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(916, 841);
            button1.Name = "button1";
            button1.Size = new Size(202, 83);
            button1.TabIndex = 3;
            button1.Text = "ADD NEW ENTRY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(173, 841);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 83);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // ManagePOA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 972);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(btnEdit);
            Controls.Add(dgvPOASummary);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagePOA";
            Text = "ManagePOA";
            ((System.ComponentModel.ISupportInitialize)dgvPOASummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvPOASummary;
        private Button btnEdit;
        private Button button1;
        private Button btnDelete;
    }
}