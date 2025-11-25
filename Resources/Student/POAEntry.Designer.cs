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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label1.Location = new Point(22, 81);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 0;
            label1.Text = "Name of Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label2.Location = new Point(26, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 1;
            label2.Text = "Target Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label3.Location = new Point(26, 150);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 2;
            label3.Text = "Organization";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label5.Location = new Point(26, 257);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(230, 19);
            label5.TabIndex = 4;
            label5.Text = "Objectives and Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label6.Location = new Point(22, 184);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 19);
            label6.TabIndex = 5;
            label6.Text = "Participants Involved";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label8.Location = new Point(26, 218);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 19);
            label8.TabIndex = 7;
            label8.Text = "Venue/Mode";
            // 
            // txtEventName
            // 
            txtEventName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(262, 79);
            txtEventName.Margin = new Padding(2);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(491, 26);
            txtEventName.TabIndex = 8;
            // 
            // txtParticipants
            // 
            txtParticipants.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParticipants.Location = new Point(262, 182);
            txtParticipants.Margin = new Padding(2);
            txtParticipants.Name = "txtParticipants";
            txtParticipants.Size = new Size(491, 26);
            txtParticipants.TabIndex = 10;
            // 
            // txtVenue
            // 
            txtVenue.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVenue.Location = new Point(262, 217);
            txtVenue.Margin = new Padding(2);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(491, 26);
            txtVenue.TabIndex = 11;
            // 
            // cmbOrganization
            // 
            cmbOrganization.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbOrganization.FormattingEnabled = true;
            cmbOrganization.Items.AddRange(new object[] { "College Student Council", "CCS Honor's Society (HonSoc)", "DataLink", "Multimedia & Systems Developers (MSD)", "Junior Philippine Computer Society (JPCS)" });
            cmbOrganization.Location = new Point(262, 148);
            cmbOrganization.Margin = new Padding(2);
            cmbOrganization.Name = "cmbOrganization";
            cmbOrganization.Size = new Size(491, 26);
            cmbOrganization.TabIndex = 12;
            // 
            // dtpEventDate
            // 
            dtpEventDate.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEventDate.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEventDate.Location = new Point(262, 114);
            dtpEventDate.Margin = new Padding(2);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(491, 26);
            dtpEventDate.TabIndex = 13;
            // 
            // txtObjectives
            // 
            txtObjectives.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObjectives.Location = new Point(262, 257);
            txtObjectives.Margin = new Padding(2);
            txtObjectives.Name = "txtObjectives";
            txtObjectives.Size = new Size(491, 68);
            txtObjectives.TabIndex = 14;
            txtObjectives.Text = "";
            // 
            // btnSaveEntry
            // 
            btnSaveEntry.BackColor = Color.FromArgb(255, 192, 192);
            btnSaveEntry.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEntry.Location = new Point(762, 711);
            btnSaveEntry.Margin = new Padding(2);
            btnSaveEntry.Name = "btnSaveEntry";
            btnSaveEntry.Size = new Size(146, 46);
            btnSaveEntry.TabIndex = 15;
            btnSaveEntry.Text = "SAVE ENTRY";
            btnSaveEntry.UseVisualStyleBackColor = false;
            btnSaveEntry.Click += btnSaveEntry_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 192, 192);
            btnBack.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(26, 14);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 46);
            btnBack.TabIndex = 16;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvBudgetItems
            // 
            dgvBudgetItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBudgetItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBudgetItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgetItems.Columns.AddRange(new DataGridViewColumn[] { colParticulars, colUnits, colUnitPrice, colTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBudgetItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBudgetItems.EnableHeadersVisualStyles = false;
            dgvBudgetItems.Location = new Point(33, 370);
            dgvBudgetItems.Margin = new Padding(2);
            dgvBudgetItems.Name = "dgvBudgetItems";
            dgvBudgetItems.RowHeadersWidth = 62;
            dgvBudgetItems.Size = new Size(882, 275);
            dgvBudgetItems.TabIndex = 17;
            dgvBudgetItems.CellEndEdit += dgvBudgetItems_CellEndEdit;
            // 
            // colParticulars
            // 
            colParticulars.HeaderText = "Particulars";
            colParticulars.MinimumWidth = 6;
            colParticulars.Name = "colParticulars";
            // 
            // colUnits
            // 
            colUnits.HeaderText = "Units";
            colUnits.MinimumWidth = 6;
            colUnits.Name = "colUnits";
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "UnitPrice";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label4.Location = new Point(26, 333);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 18;
            label4.Text = "PARTICULARS";
            // 
            // lblTotalBudget
            // 
            lblTotalBudget.Anchor = AnchorStyles.None;
            lblTotalBudget.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTotalBudget.Location = new Point(523, 668);
            lblTotalBudget.Margin = new Padding(2, 0, 2, 0);
            lblTotalBudget.Name = "lblTotalBudget";
            lblTotalBudget.Size = new Size(385, 23);
            lblTotalBudget.TabIndex = 19;
            lblTotalBudget.Text = "TOTAL BUDGET: 0.00";
            lblTotalBudget.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POAEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 778);
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
            Margin = new Padding(2);
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
        private Label label4;
        private Label lblTotalBudget;
        private DataGridViewTextBoxColumn colParticulars;
        private DataGridViewTextBoxColumn colUnits;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colTotal;
    }
}