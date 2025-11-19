namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class LiquidationFormAdmin
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvLiquidationReport = new DataGridView();
            txtSearchbox = new TextBox();
            labelRemarks = new Label();
            txtRemarks = new TextBox();
            btnDeclineReport = new Button();
            btnApproveReport = new Button();
            btnSaveReport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvLiquidationReport);
            panel1.Controls.Add(txtSearchbox);
            panel1.Controls.Add(labelRemarks);
            panel1.Controls.Add(txtRemarks);
            panel1.Controls.Add(btnDeclineReport);
            panel1.Controls.Add(btnApproveReport);
            panel1.Controls.Add(btnSaveReport);
            panel1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 778);
            panel1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(747, 149);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 27;
            label3.Text = "STATUS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(393, 149);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 26;
            label2.Text = "DATE SUBMITTED";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 149);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 25;
            label1.Text = "FILE";
            // 
            // dgvLiquidationReport
            // 
            dgvLiquidationReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLiquidationReport.Location = new Point(70, 194);
            dgvLiquidationReport.Margin = new Padding(3, 4, 3, 4);
            dgvLiquidationReport.Name = "dgvLiquidationReport";
            dgvLiquidationReport.RowHeadersWidth = 51;
            dgvLiquidationReport.Size = new Size(783, 255);
            dgvLiquidationReport.TabIndex = 24;
            dgvLiquidationReport.CellContentClick += dgvLiquidationReport_CellContentClick;
            // 
            // txtSearchbox
            // 
            txtSearchbox.BackColor = SystemColors.ControlLight;
            txtSearchbox.Location = new Point(591, 92);
            txtSearchbox.Margin = new Padding(3, 4, 3, 4);
            txtSearchbox.Name = "txtSearchbox";
            txtSearchbox.Size = new Size(261, 26);
            txtSearchbox.TabIndex = 22;
            // 
            // labelRemarks
            // 
            labelRemarks.AutoSize = true;
            labelRemarks.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRemarks.Location = new Point(70, 509);
            labelRemarks.Name = "labelRemarks";
            labelRemarks.Size = new Size(333, 20);
            labelRemarks.TabIndex = 21;
            labelRemarks.Text = "REMARKS/COMMENTS/ SUGGESTIONS";
            // 
            // txtRemarks
            // 
            txtRemarks.BackColor = SystemColors.ControlLight;
            txtRemarks.Location = new Point(70, 549);
            txtRemarks.Margin = new Padding(3, 4, 3, 4);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(471, 136);
            txtRemarks.TabIndex = 12;
            // 
            // btnDeclineReport
            // 
            btnDeclineReport.BackColor = Color.Firebrick;
            btnDeclineReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnDeclineReport.ForeColor = Color.White;
            btnDeclineReport.Location = new Point(591, 628);
            btnDeclineReport.Margin = new Padding(3, 4, 3, 4);
            btnDeclineReport.Name = "btnDeclineReport";
            btnDeclineReport.Size = new Size(105, 59);
            btnDeclineReport.TabIndex = 11;
            btnDeclineReport.Text = "DECLINE REPORT";
            btnDeclineReport.UseVisualStyleBackColor = false;
            btnDeclineReport.Click += btnDeclineReport_Click;
            // 
            // btnApproveReport
            // 
            btnApproveReport.BackColor = SystemColors.ControlLight;
            btnApproveReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnApproveReport.Location = new Point(591, 561);
            btnApproveReport.Margin = new Padding(3, 4, 3, 4);
            btnApproveReport.Name = "btnApproveReport";
            btnApproveReport.Size = new Size(105, 59);
            btnApproveReport.TabIndex = 10;
            btnApproveReport.Text = "APPROVE REPORT";
            btnApproveReport.UseVisualStyleBackColor = false;
            btnApproveReport.Click += btnApproveReport_Click;
            // 
            // btnSaveReport
            // 
            btnSaveReport.BackColor = SystemColors.ControlLight;
            btnSaveReport.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSaveReport.Location = new Point(747, 561);
            btnSaveReport.Margin = new Padding(3, 4, 3, 4);
            btnSaveReport.Name = "btnSaveReport";
            btnSaveReport.Size = new Size(105, 59);
            btnSaveReport.TabIndex = 9;
            btnSaveReport.Text = "SAVE REPORT AS";
            btnSaveReport.UseVisualStyleBackColor = false;
            btnSaveReport.Click += btnSaveReport_Click;
            // 
            // LiquidationFormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 778);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LiquidationFormAdmin";
            Text = "Liquidation Form Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLiquidationReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvLiquidationSummary;
        private DataGridView dgvBudgetSummary;
        private Button btnApproveReport;
        private Button btnSaveReport;
        private Button btnDeclineReport;
        private TextBox txtSearchbox;
        private Label labelRemarks;
        private TextBox txtRemarks;
        private DataGridView dgvLiquidationReport;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}