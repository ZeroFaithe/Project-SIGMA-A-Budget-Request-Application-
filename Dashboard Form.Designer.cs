namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class Dashboard_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            panel1 = new Panel();
            dgvDBPendingApprovals = new DataGridView();
            label7 = new Label();
            panel7 = new Panel();
            FundDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            dgvPendingRequests = new DataGridView();
            panel4 = new Panel();
            label3 = new Label();
            lblRemainingFunds = new Label();
            panel3 = new Panel();
            label2 = new Label();
            lblUsedFunds = new Label();
            panel2 = new Panel();
            lblTotal = new Label();
            label1 = new Label();
            POAcmb = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDBPendingApprovals).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FundDistribution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingRequests).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvDBPendingApprovals);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(POAcmb);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 745);
            panel1.TabIndex = 7;
            // 
            // dgvDBPendingApprovals
            // 
            dgvDBPendingApprovals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDBPendingApprovals.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDBPendingApprovals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDBPendingApprovals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDBPendingApprovals.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDBPendingApprovals.EnableHeadersVisualStyles = false;
            dgvDBPendingApprovals.Location = new Point(47, 575);
            dgvDBPendingApprovals.Name = "dgvDBPendingApprovals";
            dgvDBPendingApprovals.RowHeadersWidth = 51;
            dgvDBPendingApprovals.Size = new Size(856, 143);
            dgvDBPendingApprovals.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label7.Location = new Point(47, 305);
            label7.Name = "label7";
            label7.Size = new Size(164, 19);
            label7.TabIndex = 15;
            label7.Text = "FUND DISTRIBUTION";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDark;
            panel7.Controls.Add(FundDistribution);
            panel7.Location = new Point(47, 337);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(404, 189);
            panel7.TabIndex = 16;
            // 
            // FundDistribution
            // 
            chartArea1.Name = "ChartArea1";
            FundDistribution.ChartAreas.Add(chartArea1);
            legend1.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            FundDistribution.Legends.Add(legend1);
            FundDistribution.Location = new Point(0, 0);
            FundDistribution.Name = "FundDistribution";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            FundDistribution.Series.Add(series1);
            FundDistribution.Size = new Size(404, 189);
            FundDistribution.TabIndex = 0;
            FundDistribution.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 575);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(856, 143);
            dataGridView1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label6.Location = new Point(41, 548);
            label6.Name = "label6";
            label6.Size = new Size(188, 19);
            label6.TabIndex = 13;
            label6.Text = "PENDING APPROVALS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label5.Location = new Point(457, 305);
            label5.Name = "label5";
            label5.Size = new Size(206, 19);
            label5.TabIndex = 10;
            label5.Text = "FUND USAGE PER EVENT ";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Location = new Point(457, 337);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(446, 215);
            panel6.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 91, 91);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dgvPendingRequests);
            panel5.Location = new Point(712, 99);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(191, 160);
            panel5.TabIndex = 11;
            // 
            // label4
            // 
            label4.BackColor = Color.Maroon;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 51);
            label4.TabIndex = 14;
            label4.Text = "PENDING REQUESTS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPendingRequests
            // 
            dgvPendingRequests.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(160, 5, 0);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPendingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPendingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPendingRequests.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPendingRequests.EnableHeadersVisualStyles = false;
            dgvPendingRequests.Location = new Point(0, 48);
            dgvPendingRequests.Name = "dgvPendingRequests";
            dgvPendingRequests.RowHeadersVisible = false;
            dgvPendingRequests.RowHeadersWidth = 51;
            dgvPendingRequests.Size = new Size(191, 112);
            dgvPendingRequests.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 91, 91);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(lblRemainingFunds);
            panel4.Location = new Point(486, 99);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 160);
            panel4.TabIndex = 11;
            // 
            // label3
            // 
            label3.BackColor = Color.Maroon;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 51);
            label3.TabIndex = 13;
            label3.Text = "REMAINING FUNDS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainingFunds
            // 
            lblRemainingFunds.Anchor = AnchorStyles.None;
            lblRemainingFunds.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblRemainingFunds.Location = new Point(0, 88);
            lblRemainingFunds.Name = "lblRemainingFunds";
            lblRemainingFunds.Size = new Size(186, 20);
            lblRemainingFunds.TabIndex = 13;
            lblRemainingFunds.Text = "Select POA to View";
            lblRemainingFunds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 91, 91);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblUsedFunds);
            panel3.Location = new Point(264, 99);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 160);
            panel3.TabIndex = 11;
            // 
            // label2
            // 
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 51);
            label2.TabIndex = 12;
            label2.Text = "TOTAL USED";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsedFunds
            // 
            lblUsedFunds.Anchor = AnchorStyles.None;
            lblUsedFunds.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblUsedFunds.Location = new Point(3, 88);
            lblUsedFunds.Name = "lblUsedFunds";
            lblUsedFunds.Size = new Size(177, 20);
            lblUsedFunds.TabIndex = 12;
            lblUsedFunds.Text = "Select POA to View";
            lblUsedFunds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 91, 91);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(41, 99);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 160);
            panel2.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblTotal.Location = new Point(0, 88);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(186, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Select POA to View";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 51);
            label1.TabIndex = 10;
            label1.Text = "TOTAL ALLOCATED";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // POAcmb
            // 
            POAcmb.BackColor = Color.White;
            POAcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            POAcmb.FlatStyle = FlatStyle.System;
            POAcmb.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            POAcmb.FormattingEnabled = true;
            POAcmb.Location = new Point(47, 28);
            POAcmb.Margin = new Padding(3, 4, 3, 4);
            POAcmb.Name = "POAcmb";
            POAcmb.Size = new Size(223, 28);
            POAcmb.TabIndex = 8;
            POAcmb.SelectedIndexChanged += POAcmb_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1198, 57);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 71);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(950, 744);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard_Form";
            Text = "Dashboard_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDBPendingApprovals).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FundDistribution).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendingRequests).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox POAcmb;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Label label5;
        private Label label7;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart FundDistribution;
        private DataGridView dgvDBPendingApprovals;
        private DataGridView dgvPendingRequests;
        private Label lblTotal;
        private Label lblRemainingFunds;
        private Label lblUsedFunds;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}