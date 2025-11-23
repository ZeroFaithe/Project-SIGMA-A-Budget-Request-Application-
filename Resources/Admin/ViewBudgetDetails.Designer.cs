namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Admin
{
    partial class ViewBudgetDetails
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
            dgvItems = new DataGridView();
            label1 = new Label();
            lblTotal = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(12, 75);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(776, 441);
            dgvItems.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(460, 529);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 1;
            label1.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(554, 529);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 28);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0.00";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightCoral;
            btnClose.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(12, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 57);
            btnClose.TabIndex = 3;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ViewBudgetDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(btnClose);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(dgvItems);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViewBudgetDetails";
            Text = "ViewBudgetDetails";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private Label label1;
        private Label lblTotal;
        private Button btnClose;
    }
}