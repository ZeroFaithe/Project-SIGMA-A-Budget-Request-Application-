namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Admin
{
    partial class LiquidationAdmin
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
            btnRejected = new Button();
            btn_Revise = new Button();
            btnPending = new Button();
            btnApproved = new Button();
            dgvRequests = new DataGridView();
            dgvReceipts = new DataGridView();
            pbReceipt = new PictureBox();
            label1 = new Label();
            btnApprove = new Button();
            btnReject = new Button();
            btnReviseAction = new Button();
            rtbRemarks = new RichTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReceipt).BeginInit();
            SuspendLayout();
            // 
            // btnRejected
            // 
            btnRejected.BackColor = Color.LightCoral;
            btnRejected.FlatAppearance.BorderSize = 0;
            btnRejected.FlatStyle = FlatStyle.Flat;
            btnRejected.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejected.Location = new Point(334, 28);
            btnRejected.Margin = new Padding(0);
            btnRejected.Name = "btnRejected";
            btnRejected.Size = new Size(104, 34);
            btnRejected.TabIndex = 25;
            btnRejected.Text = "REJECTED";
            btnRejected.UseVisualStyleBackColor = false;
            btnRejected.Click += btnRejected_Click;
            // 
            // btn_Revise
            // 
            btn_Revise.BackColor = Color.LightSkyBlue;
            btn_Revise.FlatAppearance.BorderSize = 0;
            btn_Revise.FlatStyle = FlatStyle.Flat;
            btn_Revise.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Revise.Location = new Point(230, 28);
            btn_Revise.Margin = new Padding(0);
            btn_Revise.Name = "btn_Revise";
            btn_Revise.Size = new Size(104, 34);
            btn_Revise.TabIndex = 24;
            btn_Revise.Text = "TO REVISE";
            btn_Revise.UseVisualStyleBackColor = false;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.NavajoWhite;
            btnPending.FlatAppearance.BorderSize = 0;
            btnPending.FlatStyle = FlatStyle.Flat;
            btnPending.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPending.Location = new Point(127, 28);
            btnPending.Margin = new Padding(0);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(104, 34);
            btnPending.TabIndex = 23;
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
            btnApproved.Location = new Point(23, 28);
            btnApproved.Margin = new Padding(0);
            btnApproved.Name = "btnApproved";
            btnApproved.Size = new Size(104, 34);
            btnApproved.TabIndex = 22;
            btnApproved.Text = "APPROVED";
            btnApproved.UseVisualStyleBackColor = false;
            btnApproved.Click += btnApproved_Click;
            // 
            // dgvRequests
            // 
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRequests.EnableHeadersVisualStyles = false;
            dgvRequests.Location = new Point(23, 86);
            dgvRequests.Margin = new Padding(2);
            dgvRequests.Name = "dgvRequests";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRequests.RowHeadersWidth = 21;
            dgvRequests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRequests.Size = new Size(880, 180);
            dgvRequests.TabIndex = 26;
            dgvRequests.CellClick += dgvRequests_CellClick;
            // 
            // dgvReceipts
            // 
            dgvReceipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvReceipts.DefaultCellStyle = dataGridViewCellStyle4;
            dgvReceipts.EnableHeadersVisualStyles = false;
            dgvReceipts.Location = new Point(23, 307);
            dgvReceipts.Margin = new Padding(2);
            dgvReceipts.Name = "dgvReceipts";
            dgvReceipts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReceipts.RowHeadersWidth = 62;
            dgvReceipts.Size = new Size(592, 243);
            dgvReceipts.TabIndex = 27;
            dgvReceipts.CellClick += dgvReceipts_CellClick;
            // 
            // pbReceipt
            // 
            pbReceipt.BorderStyle = BorderStyle.FixedSingle;
            pbReceipt.Location = new Point(632, 307);
            pbReceipt.Margin = new Padding(2);
            pbReceipt.Name = "pbReceipt";
            pbReceipt.Size = new Size(272, 244);
            pbReceipt.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReceipt.TabIndex = 28;
            pbReceipt.TabStop = false;
            pbReceipt.Click += pbReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 286);
            label1.Name = "label1";
            label1.Size = new Size(212, 19);
            label1.TabIndex = 29;
            label1.Text = "RECEIPTS IN THIS REPORT:";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.PaleGreen;
            btnApprove.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(768, 585);
            btnApprove.Margin = new Padding(2);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(135, 105);
            btnApprove.TabIndex = 32;
            btnApprove.Text = "APPROVE";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Salmon;
            btnReject.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.Location = new Point(610, 646);
            btnReject.Margin = new Padding(2);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(147, 43);
            btnReject.TabIndex = 31;
            btnReject.Text = "REJECT";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnReviseAction
            // 
            btnReviseAction.BackColor = Color.PaleTurquoise;
            btnReviseAction.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReviseAction.Location = new Point(610, 585);
            btnReviseAction.Margin = new Padding(2);
            btnReviseAction.Name = "btnReviseAction";
            btnReviseAction.Size = new Size(147, 43);
            btnReviseAction.TabIndex = 30;
            btnReviseAction.Text = "TO REVISE";
            btnReviseAction.UseVisualStyleBackColor = false;
            btnReviseAction.Click += btnReviseAction_Click;
            // 
            // rtbRemarks
            // 
            rtbRemarks.Location = new Point(23, 585);
            rtbRemarks.Margin = new Padding(2);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(565, 106);
            rtbRemarks.TabIndex = 33;
            rtbRemarks.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 564);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 34;
            label2.Text = "REMARKS:";
            // 
            // LiquidationAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 699);
            Controls.Add(label2);
            Controls.Add(rtbRemarks);
            Controls.Add(btnApprove);
            Controls.Add(btnReject);
            Controls.Add(btnReviseAction);
            Controls.Add(label1);
            Controls.Add(pbReceipt);
            Controls.Add(dgvReceipts);
            Controls.Add(dgvRequests);
            Controls.Add(btnRejected);
            Controls.Add(btn_Revise);
            Controls.Add(btnPending);
            Controls.Add(btnApproved);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LiquidationAdmin";
            Text = "LiquidationAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReceipt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRejected;
        private Button btn_Revise;
        private Button btnPending;
        private Button btnApproved;
        private DataGridView dgvRequests;
        private DataGridView dgvReceipts;
        private PictureBox pbReceipt;
        private Label label1;
        private Button btnApprove;
        private Button btnReject;
        private Button btnReviseAction;
        private RichTextBox rtbRemarks;
        private Label label2;
    }
}