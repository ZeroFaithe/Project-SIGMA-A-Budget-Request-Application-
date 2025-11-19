namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class StudentFrame : Form
    {
        public StudentFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadform(new Dashboard_Form());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard_Form());
        }

        private void btnManagePOA_Click(object sender, EventArgs e)
        {
            loadform(new ManagePOA());
        }

        private void btnBudgetRequest_Click(object sender, EventArgs e)
        {
            loadform(new BudgetRequest());
        }

        private void btnLiquidation_Click(object sender, EventArgs e)
        {
            loadform(new LiquidationFormStudent());
        }

        private void btnReimbursement_Click(object sender, EventArgs e)
        {
            loadform(new ReimbursementFormStudent());
        }
    }
}

