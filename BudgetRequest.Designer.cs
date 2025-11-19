namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class BudgetRequest
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
            this.btnSave = new Button();
            btnEdit = new Button();
            dgvBRSummary = new DataGridView();
            listBox1 = new ListBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBRSummary).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.FromArgb(192, 0, 0);
            this.btnSave.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(900, 809);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(187, 83);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE CHANGES";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnnewBR
            // 
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 128, 128);
            btnEdit.Location = new Point(80, 808);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 83);
            btnEdit.TabIndex = 10;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // dgvBRSummary
            // 
            dgvBRSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBRSummary.Location = new Point(80, 150);
            dgvBRSummary.Name = "dgvBRSummary";
            dgvBRSummary.RowHeadersWidth = 62;
            dgvBRSummary.Size = new Size(1007, 603);
            dgvBRSummary.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(920, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(167, 27);
            listBox1.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(448, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(439, 37);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // BudgetRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 972);
            Controls.Add(this.btnSave);
            Controls.Add(btnEdit);
            Controls.Add(dgvBRSummary);
            Controls.Add(listBox1);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BudgetRequest";
            Text = "BudgetRequest";
            ((System.ComponentModel.ISupportInitialize)dgvBRSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button addItemPOA;
        private Button btnEdit;
        private DataGridView dgvBRSummary;
        private ListBox listBox1;
        private TextBox txtSearch;
        private Button btnSave;
    }
}