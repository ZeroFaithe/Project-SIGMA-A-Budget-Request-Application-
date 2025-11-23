namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Student
{
    partial class ReceiptForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtInvoice = new TextBox();
            txtSupplier = new TextBox();
            btnUpload = new Button();
            cmbChargeTo = new ComboBox();
            lblFileStatus = new Label();
            btnAddReceipt = new Button();
            label6 = new Label();
            txtTotalAmount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(195, 23);
            label1.TabIndex = 0;
            label1.Text = "NEW RECEIPT ENTRY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 86);
            label2.Name = "label2";
            label2.Size = new Size(180, 23);
            label2.TabIndex = 1;
            label2.Text = "INVOICE NUMBER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 134);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 2;
            label3.Text = "SUPPLIER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 184);
            label4.Name = "label4";
            label4.Size = new Size(238, 23);
            label4.TabIndex = 3;
            label4.Text = "CHARGE TO CATEGORY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 241);
            label5.Name = "label5";
            label5.Size = new Size(168, 23);
            label5.TabIndex = 4;
            label5.Text = "UPLOAD RECEIPT";
            // 
            // txtInvoice
            // 
            txtInvoice.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoice.Location = new Point(412, 84);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(467, 32);
            txtInvoice.TabIndex = 5;
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(412, 134);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(467, 32);
            txtSupplier.TabIndex = 6;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(660, 241);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(219, 34);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload Receipt";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click_1;
            // 
            // cmbChargeTo
            // 
            cmbChargeTo.FormattingEnabled = true;
            cmbChargeTo.Location = new Point(412, 184);
            cmbChargeTo.Name = "cmbChargeTo";
            cmbChargeTo.Size = new Size(467, 33);
            cmbChargeTo.TabIndex = 8;
            // 
            // lblFileStatus
            // 
            lblFileStatus.AutoSize = true;
            lblFileStatus.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileStatus.Location = new Point(412, 246);
            lblFileStatus.Name = "lblFileStatus";
            lblFileStatus.Size = new Size(169, 23);
            lblFileStatus.TabIndex = 9;
            lblFileStatus.Text = "No File Selected";
            // 
            // btnAddReceipt
            // 
            btnAddReceipt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddReceipt.Location = new Point(660, 410);
            btnAddReceipt.Name = "btnAddReceipt";
            btnAddReceipt.Size = new Size(219, 59);
            btnAddReceipt.TabIndex = 12;
            btnAddReceipt.Text = "ADD THIS RECEIPT";
            btnAddReceipt.UseVisualStyleBackColor = true;
            btnAddReceipt.Click += btnAddReceipt_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 290);
            label6.Name = "label6";
            label6.Size = new Size(159, 23);
            label6.TabIndex = 13;
            label6.Text = "TOTAL AMOUNT";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(412, 290);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(467, 32);
            txtTotalAmount.TabIndex = 14;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 481);
            Controls.Add(txtTotalAmount);
            Controls.Add(label6);
            Controls.Add(btnAddReceipt);
            Controls.Add(lblFileStatus);
            Controls.Add(cmbChargeTo);
            Controls.Add(btnUpload);
            Controls.Add(txtSupplier);
            Controls.Add(txtInvoice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReceiptForm";
            Text = "ReceiptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtInvoice;
        private TextBox txtSupplier;
        private Button btnUpload;
        private ComboBox cmbChargeTo;
        private Label lblFileStatus;
        private Button btnAddReceipt;
        private Label label6;
        private TextBox txtTotalAmount;
    }
}