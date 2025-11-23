namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class POAEntry
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
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtEventName = new TextBox();
            txtParticipants = new TextBox();
            txtVenue = new TextBox();
            cmbOrganization = new ComboBox();
            dtpEventDate = new DateTimePicker();
            txtObjectives = new RichTextBox();
            btnSaveEntry = new Button();
            btnBack = new Button();
            dgvBudgetItems = new DataGridView();
            colParticulars = new DataGridViewTextBoxColumn();
            colUnits = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            label4 = new Label();
            lblTotalBudget = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBudgetItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.Location = new Point(28, 101);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 0;
            label1.Text = "Name of Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label2.Location = new Point(33, 144);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 1;
            label2.Text = "Target Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label3.Location = new Point(33, 187);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 2;
            label3.Text = "Organization";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label5.Location = new Point(33, 321);
            label5.Name = "label5";
            label5.Size = new Size(274, 23);
            label5.TabIndex = 4;
            label5.Text = "Objectives and Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label6.Location = new Point(28, 230);
            label6.Name = "label6";
            label6.Size = new Size(212, 23);
            label6.TabIndex = 5;
            label6.Text = "Participants Involved";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label8.Location = new Point(33, 273);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 7;
            label8.Text = "Venue/Mode";
            // 
            // txtEventName
            // 
            txtEventName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(327, 99);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(613, 30);
            txtEventName.TabIndex = 8;
            // 
            // txtParticipants
            // 
            txtParticipants.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParticipants.Location = new Point(327, 228);
            txtParticipants.Name = "txtParticipants";
            txtParticipants.Size = new Size(613, 30);
            txtParticipants.TabIndex = 10;
            // 
            // txtVenue
            // 
            txtVenue.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVenue.Location = new Point(327, 271);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(613, 30);
            txtVenue.TabIndex = 11;
            // 
            // cmbOrganization
            // 
            cmbOrganization.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbOrganization.FormattingEnabled = true;
            cmbOrganization.Items.AddRange(new object[] { "College Student Council", "CCS Honor's Society (HonSoc)", "DataLink", "Multimedia & Systems Developers (MSD)", "Junior Philippine Computer Society (JPCS)" });
            cmbOrganization.Location = new Point(327, 185);
            cmbOrganization.Name = "cmbOrganization";
            cmbOrganization.Size = new Size(613, 30);
            cmbOrganization.TabIndex = 12;
            // 
            // dtpEventDate
            // 
            dtpEventDate.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEventDate.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEventDate.Location = new Point(327, 142);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(613, 30);
            dtpEventDate.TabIndex = 13;
            // 
            // txtObjectives
            // 
            txtObjectives.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObjectives.Location = new Point(327, 321);
            txtObjectives.Name = "txtObjectives";
            txtObjectives.Size = new Size(613, 84);
            txtObjectives.TabIndex = 14;
            txtObjectives.Text = "";
            // 
            // btnSaveEntry
            // 
            btnSaveEntry.BackColor = Color.FromArgb(255, 192, 192);
            btnSaveEntry.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEntry.Location = new Point(952, 889);
            btnSaveEntry.Name = "btnSaveEntry";
            btnSaveEntry.Size = new Size(183, 57);
            btnSaveEntry.TabIndex = 15;
            btnSaveEntry.Text = "SAVE ENTRY";
            btnSaveEntry.UseVisualStyleBackColor = false;
            btnSaveEntry.Click += btnSaveEntry_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 192, 192);
            btnBack.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(33, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(183, 57);
            btnBack.TabIndex = 16;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvBudgetItems
            // 
            dgvBudgetItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgetItems.Columns.AddRange(new DataGridViewColumn[] { colParticulars, colUnits, colUnitPrice, colTotal });
            dgvBudgetItems.Location = new Point(41, 463);
            dgvBudgetItems.Name = "dgvBudgetItems";
            dgvBudgetItems.RowHeadersWidth = 62;
            dgvBudgetItems.Size = new Size(1102, 344);
            dgvBudgetItems.TabIndex = 17;
            dgvBudgetItems.CellEndEdit += dgvBudgetItems_CellEndEdit;
            // 
            // colParticulars
            // 
            colParticulars.HeaderText = "Particulars";
            colParticulars.MinimumWidth = 8;
            colParticulars.Name = "colParticulars";
            colParticulars.Width = 150;
            // 
            // colUnits
            // 
            colUnits.HeaderText = "Units";
            colUnits.MinimumWidth = 8;
            colUnits.Name = "colUnits";
            colUnits.Width = 150;
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "UnitPrice";
            colUnitPrice.MinimumWidth = 8;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Width = 150;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label4.Location = new Point(33, 416);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 18;
            label4.Text = "PARTICULARS";
            // 
            // lblTotalBudget
            // 
            lblTotalBudget.AutoSize = true;
            lblTotalBudget.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTotalBudget.Location = new Point(789, 826);
            lblTotalBudget.Name = "lblTotalBudget";
            lblTotalBudget.Size = new Size(236, 28);
            lblTotalBudget.TabIndex = 19;
            lblTotalBudget.Text = "TOTAL BUDGET: 0.00";
            // 
            // POAEntry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 972);
            Controls.Add(lblTotalBudget);
            Controls.Add(label4);
            Controls.Add(dgvBudgetItems);
            Controls.Add(btnBack);
            Controls.Add(btnSaveEntry);
            Controls.Add(txtObjectives);
            Controls.Add(dtpEventDate);
            Controls.Add(cmbOrganization);
            Controls.Add(txtVenue);
            Controls.Add(txtParticipants);
            Controls.Add(txtEventName);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "POAEntry";
            Text = "POAEntry";
            Load += POAEntry_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBudgetItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtEventName;
        private TextBox txtParticipants;
        private TextBox txtVenue;
        private ComboBox cmbOrganization;
        private DateTimePicker dtpEventDate;
        private RichTextBox txtObjectives;
        private Button btnSaveEntry;
        private Button btnBack;
        private DataGridView dgvBudgetItems;
        private DataGridViewTextBoxColumn colParticulars;
        private DataGridViewTextBoxColumn colUnits;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colTotal;
        private Label label4;
        private Label lblTotalBudget;
    }
}