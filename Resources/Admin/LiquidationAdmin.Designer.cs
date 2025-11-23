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
            btnRejected.Location = new Point(418, 35);
            btnRejected.Margin = new Padding(0);
            btnRejected.Name = "btnRejected";
            btnRejected.Size = new Size(130, 42);
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
            btn_Revise.Location = new Point(288, 35);
            btn_Revise.Margin = new Padding(0);
            btn_Revise.Name = "btn_Revise";
            btn_Revise.Size = new Size(130, 42);
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
            btnPending.Location = new Point(159, 35);
            btnPending.Margin = new Padding(0);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(130, 42);
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
            btnApproved.Location = new Point(29, 35);
            btnApproved.Margin = new Padding(0);
            btnApproved.Name = "btnApproved";
            btnApproved.Size = new Size(130, 42);
            btnApproved.TabIndex = 22;
            btnApproved.Text = "APPROVED";
            btnApproved.UseVisualStyleBackColor = false;
            btnApproved.Click += btnApproved_Click;
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(29, 107);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 62;
            dgvRequests.Size = new Size(1100, 225);
            dgvRequests.TabIndex = 26;
            dgvRequests.CellClick += dgvRequests_CellClick;
            // 
            // dgvReceipts
            // 
            dgvReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceipts.Location = new Point(29, 384);
            dgvReceipts.Name = "dgvReceipts";
            dgvReceipts.RowHeadersWidth = 62;
            dgvReceipts.Size = new Size(740, 304);
            dgvReceipts.TabIndex = 27;
            dgvReceipts.CellClick += dgvReceipts_CellClick;
            // 
            // pbReceipt
            // 
            pbReceipt.BorderStyle = BorderStyle.FixedSingle;
            pbReceipt.Location = new Point(790, 384);
            pbReceipt.Name = "pbReceipt";
            pbReceipt.Size = new Size(339, 304);
            pbReceipt.TabIndex = 28;
            pbReceipt.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 358);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 23);
            label1.TabIndex = 29;
            label1.Text = "RECEIPTS IN THIS REPORT:";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.PaleGreen;
            btnApprove.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(960, 731);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(169, 131);
            btnApprove.TabIndex = 32;
            btnApprove.Text = "APPROVE";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Salmon;
            btnReject.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.Location = new Point(763, 808);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(184, 54);
            btnReject.TabIndex = 31;
            btnReject.Text = "REJECT";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnReviseAction
            // 
            btnReviseAction.BackColor = Color.PaleTurquoise;
            btnReviseAction.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReviseAction.Location = new Point(763, 731);
            btnReviseAction.Name = "btnReviseAction";
            btnReviseAction.Size = new Size(184, 54);
            btnReviseAction.TabIndex = 30;
            btnReviseAction.Text = "TO REVISE";
            btnReviseAction.UseVisualStyleBackColor = false;
            btnReviseAction.Click += btnReviseAction_Click;
            // 
            // rtbRemarks
            // 
            rtbRemarks.Location = new Point(29, 731);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(705, 131);
            rtbRemarks.TabIndex = 33;
            rtbRemarks.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 705);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 34;
            label2.Text = "REMARKS:";
            // 
            // LiquidationAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 874);
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