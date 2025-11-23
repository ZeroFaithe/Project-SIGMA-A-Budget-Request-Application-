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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetRequest));
            btnSubmitRequest = new Button();
            btnPrint = new Button();
            dgvParticulars = new DataGridView();
            colItem = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            cmbApprovedEvents = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            lblRemainingBalance = new Label();
            lblDate = new Label();
            lblTotalBudget = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtContactNumber = new TextBox();
            dtpDateNeeded = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtStudentRemarks = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblGrandTotal = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParticulars).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.BackColor = Color.FromArgb(192, 0, 0);
            btnSubmitRequest.Enabled = false;
            btnSubmitRequest.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(953, 861);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(187, 83);
            btnSubmitRequest.TabIndex = 12;
            btnSubmitRequest.Text = "SAVE CHANGES";
            btnSubmitRequest.UseVisualStyleBackColor = false;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(255, 128, 128);
            btnPrint.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(22, 851);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(214, 83);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "SAVE AS PDF";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // dgvParticulars
            // 
            dgvParticulars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticulars.Columns.AddRange(new DataGridViewColumn[] { colItem, colQty, colAmount, colSupplier, colTotal });
            dgvParticulars.Location = new Point(22, 457);
            dgvParticulars.Name = "dgvParticulars";
            dgvParticulars.RowHeadersWidth = 62;
            dgvParticulars.Size = new Size(1118, 313);
            dgvParticulars.TabIndex = 9;
            dgvParticulars.CellEndEdit += dgvParticulars_CellEndEdit;
            // 
            // colItem
            // 
            colItem.HeaderText = "Item Name";
            colItem.MinimumWidth = 8;
            colItem.Name = "colItem";
            colItem.Width = 150;
            // 
            // colQty
            // 
            colQty.HeaderText = "Quantity";
            colQty.MinimumWidth = 8;
            colQty.Name = "colQty";
            colQty.Width = 150;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 8;
            colAmount.Name = "colAmount";
            colAmount.Width = 150;
            // 
            // colSupplier
            // 
            colSupplier.HeaderText = "Supplier";
            colSupplier.MinimumWidth = 8;
            colSupplier.Name = "colSupplier";
            colSupplier.Width = 150;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.Width = 150;
            // 
            // cmbApprovedEvents
            // 
            cmbApprovedEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbApprovedEvents.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbApprovedEvents.FormattingEnabled = true;
            cmbApprovedEvents.Location = new Point(22, 46);
            cmbApprovedEvents.Name = "cmbApprovedEvents";
            cmbApprovedEvents.Size = new Size(862, 29);
            cmbApprovedEvents.TabIndex = 13;
            cmbApprovedEvents.SelectedIndexChanged += cmbApprovedEvents_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(309, 22);
            label1.TabIndex = 14;
            label1.Text = "SELECT APPROVED ACTIVITY/EVENT:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblRemainingBalance);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblTotalBudget);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 138);
            panel1.TabIndex = 15;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.AutoSize = true;
            lblRemainingBalance.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingBalance.ForeColor = Color.ForestGreen;
            lblRemainingBalance.Location = new Point(269, 74);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(170, 22);
            lblRemainingBalance.TabIndex = 22;
            lblRemainingBalance.Text = "Remaining Budget";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(269, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 22);
            lblDate.TabIndex = 21;
            lblDate.Text = "Date";
            // 
            // lblTotalBudget
            // 
            lblTotalBudget.AutoSize = true;
            lblTotalBudget.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBudget.Location = new Point(269, 43);
            lblTotalBudget.Name = "lblTotalBudget";
            lblTotalBudget.Size = new Size(140, 22);
            lblTotalBudget.TabIndex = 20;
            lblTotalBudget.Text = "Activity Budget";
            lblTotalBudget.Click += lblTotalBudget_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 74);
            label6.Name = "label6";
            label6.Size = new Size(199, 22);
            label6.TabIndex = 19;
            label6.Text = "REMAINING BALANCE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 43);
            label5.Name = "label5";
            label5.Size = new Size(220, 22);
            label5.TabIndex = 18;
            label5.Text = "TOTAL ACTIVITY BUDGET:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 14);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 17;
            label4.Text = "DATE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(0, 22);
            label2.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtContactNumber);
            panel2.Controls.Add(dtpDateNeeded);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(588, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 138);
            panel2.TabIndex = 23;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.Location = new Point(189, 87);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(331, 30);
            txtContactNumber.TabIndex = 24;
            txtContactNumber.TextChanged += textBox1_TextChanged;
            // 
            // dtpDateNeeded
            // 
            dtpDateNeeded.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateNeeded.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateNeeded.Location = new Point(22, 45);
            dtpDateNeeded.Name = "dtpDateNeeded";
            dtpDateNeeded.Size = new Size(498, 30);
            dtpDateNeeded.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 95);
            label12.Name = "label12";
            label12.Size = new Size(138, 22);
            label12.TabIndex = 17;
            label12.Text = "CONTACT NO.:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(22, 17);
            label13.Name = "label13";
            label13.Size = new Size(241, 22);
            label13.TabIndex = 16;
            label13.Text = "ACTUAL DATE OF ACTIVITY:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(20, 24);
            label14.Name = "label14";
            label14.Size = new Size(0, 22);
            label14.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(22, 98);
            label16.Name = "label16";
            label16.Size = new Size(156, 22);
            label16.TabIndex = 24;
            label16.Text = "ACTIVITY DETAILS";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(588, 98);
            label17.Name = "label17";
            label17.Size = new Size(152, 22);
            label17.TabIndex = 25;
            label17.Text = "REQUEST DETAILS";
            // 
            // txtStudentRemarks
            // 
            txtStudentRemarks.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentRemarks.Location = new Point(22, 317);
            txtStudentRemarks.Multiline = true;
            txtStudentRemarks.Name = "txtStudentRemarks";
            txtStudentRemarks.Size = new Size(1118, 99);
            txtStudentRemarks.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 285);
            label3.Name = "label3";
            label3.Size = new Size(168, 22);
            label3.TabIndex = 26;
            label3.Text = "ADDITIONAL INFO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 432);
            label7.Name = "label7";
            label7.Size = new Size(127, 22);
            label7.TabIndex = 28;
            label7.Text = "PARTICULARS:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(728, 797);
            label8.Name = "label8";
            label8.Size = new Size(144, 22);
            label8.TabIndex = 29;
            label8.Text = "TOTAL REQUEST:";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblGrandTotal.Location = new Point(893, 792);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(81, 28);
            lblGrandTotal.TabIndex = 30;
            lblGrandTotal.Text = "₱ 0.00";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(953, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(169, 54);
            btnClose.TabIndex = 31;
            btnClose.Text = "CANCEL";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // BudgetRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 972);
            Controls.Add(btnClose);
            Controls.Add(lblGrandTotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtStudentRemarks);
            Controls.Add(label3);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(cmbApprovedEvents);
            Controls.Add(btnSubmitRequest);
            Controls.Add(btnPrint);
            Controls.Add(dgvParticulars);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BudgetRequest";
            Text = "BudgetRequest";
            ((System.ComponentModel.ISupportInitialize)dgvParticulars).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button addItemPOA;
        private Button btnPrint;
        private DataGridView dgvParticulars;
        private Button btnSubmitRequest;
        private ComboBox cmbApprovedEvents;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label lblDate;
        private Label lblTotalBudget;
        private Label label6;
        private Label lblRemainingBalance;
        private Panel panel2;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private TextBox txtContactNumber;
        private DateTimePicker dtpDateNeeded;
        private Label label17;
        private TextBox txtStudentRemarks;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label lblGrandTotal;
        private DataGridViewTextBoxColumn colItem;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colSupplier;
        private DataGridViewTextBoxColumn colTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnClose;
    }
}