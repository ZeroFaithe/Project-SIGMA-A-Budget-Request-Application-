using Microsoft.Data.SqlClient;
using Project_SIGMA__A_Budget_Request_Application_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
            fundUsageChartInitialization();
            fundDistributionChartInitialization();
            pendingApprovalsInitialization();
            cmbPopulate();
        }

        private void fundDistributionChartInitialization()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                conn.Open();
                const string query = @"
                    SELECT POA.EventName, SUM(BudgetRequests.TotalAmount) AS TotalAmount
                    FROM POA
                    INNER JOIN BudgetRequests ON POA.ID = BudgetRequests.POAID
                    WHERE BudgetRequests.Status = 'Approved'
                    GROUP BY POA.EventName
                    ORDER BY TotalAmount DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Series series = new Series("Fund Distribution")
                    {
                        ChartType = SeriesChartType.Pie
                    };

                    series["PieLabelStyle"] = "Disabled";

                    while (reader.Read())
                    {
                        string eventName = reader.IsDBNull(0) ? "(Unknown)" : reader.GetString(0).Trim();
                        decimal totalAmount = reader.IsDBNull(1) ? 0m : reader.GetDecimal(1);
                        int pointIndex = series.Points.AddXY(eventName, (double)totalAmount);
                        var dp = series.Points[pointIndex];
                    }
                    FundDistribution.Series.Clear();
                    FundDistribution.Series.Add(series);
                }
            }
        }

        private void fundUsageChartInitialization()
        {
            // Prepare chart 
            Chart fundUsageChart = new Chart
            {
                Dock = DockStyle.None,
                Location = Point.Empty,
                AntiAliasing = AntiAliasingStyles.All,
                TextAntiAliasingQuality = TextAntiAliasingQuality.High
            };

            // Chart area
            var area = new ChartArea("MainArea");
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.Interval = 1;

            // Prevent automatic label fitting/rotation
            area.AxisX.IsLabelAutoFit = false;
            area.AxisY.IsLabelAutoFit = false;

            area.AxisX.LabelStyle.Angle = 0;
            area.AxisX.LabelStyle.IsStaggered = false;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            area.AxisY.LabelStyle.Angle = 0;
            area.AxisY.LabelStyle.IsStaggered = false;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            // Leave sufficient inner plot margins so labels are visible
            area.Position = new ElementPosition(5, 5, 90, 90);
            area.InnerPlotPosition = new ElementPosition(10, 10, 80, 80);

            fundUsageChart.ChartAreas.Add(area);

            // Series
            Series series = new Series("Fund Usage")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                ChartArea = "MainArea"
            };

            var points = new List<(string Name, double Value)>();

            // Load data (aggregated)
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                conn.Open();
                const string query = @"
                    SELECT POA.EventName, SUM(BudgetRequests.TotalAmount) AS TotalAmount
                    FROM POA
                    INNER JOIN BudgetRequests ON POA.ID = BudgetRequests.POAID
                    WHERE BudgetRequests.Status = 'Approved'
                    GROUP BY POA.EventName
                    ORDER BY TotalAmount DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eventName = reader.IsDBNull(0) ? "(Unknown)" : reader.GetString(0).Trim();
                        decimal totalAmount = reader.IsDBNull(1) ? 0m : reader.GetDecimal(1);
                        points.Add((eventName, (double)totalAmount));
                    }
                }
            }

            // Add points using numeric X indices and set AxisLabel (prevents category collisions)
            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i];
                int pointIndex = series.Points.AddXY(i + 1, p.Value); // numeric X value
                var dp = series.Points[pointIndex];
                dp.AxisLabel = p.Name;                 // what appears on X axis
                dp.Label = p.Value.ToString("N2");     // value label above bar
                dp.Label = dp.Label.Replace(".00", ""); // remove cents if zero
            }

            // Narrow bars when many points
            series["PointWidth"] = "0.6";

            fundUsageChart.Series.Clear();
            fundUsageChart.Series.Add(series);

            // Ensure label properties are applied on the actual ChartArea instance
            var ca = fundUsageChart.ChartAreas["MainArea"];
            ca.AxisX.IsLabelAutoFit = false;
            ca.AxisX.LabelStyle.Angle = 0;
            ca.AxisX.LabelStyle.IsStaggered = false;
            ca.AxisX.LabelStyle.Font = new Font("Century Gothic", 6f, FontStyle.Bold);
            ca.AxisY.IsLabelAutoFit = false;
            ca.AxisY.LabelStyle.Angle = 0;
            ca.AxisY.LabelStyle.IsStaggered = false;
            ca.AxisY.LabelStyle.Font = new Font("Century Gothic", 9f, FontStyle.Bold);

            // Autosize horizontally based on point count and enable scrolling on the panel
            int barPixel = 70; // adjust pixel-per-column to taste
            int margin = 50;
            int panelWidth = panel6.ClientSize.Width;
            if (panelWidth <= 0) panelWidth = Math.Max(this.ClientSize.Width - 40, 600); // fallback if called too early
            int neededWidth = Math.Max(panelWidth, points.Count * barPixel + margin);

            fundUsageChart.Size = new Size(neededWidth, panel6.ClientSize.Height > 0 ? panel6.ClientSize.Height : this.ClientSize.Height / 2);
            fundUsageChart.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            panel6.AutoScroll = true;
            panel6.Controls.Clear();
            panel6.Controls.Add(fundUsageChart);
        }

        private void pendingApprovalsInitialization()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                try
                {
                    connection.Open();

                    // CHANGE: I added ", Status" to the SELECT list below
                    string query = @"SELECT ID, EventName, EventDate, ProposedBudget, VenueMode, Participants, Status 
                             FROM POA 
                             WHERE Status = @Status AND SubmittedBy = @SubmittedBy";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Status", "Pending");
                        cmd.Parameters.AddWithValue("@SubmittedBy", UserSession.Username);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvDBPendingApprovals.DataSource = dt;

                        // Hide ID (Technical column)
                        if (dgvDBPendingApprovals.Columns["ID"] != null)
                        {
                            dgvDBPendingApprovals.Columns["ID"].Visible = false;
                        }

                        // Hide Status (Optional: Hide it because the buttons already tell you the status)
                        // But the data is still there for the code to read!
                        if (dgvDBPendingApprovals.Columns["Status"] != null)
                        {
                            dgvDBPendingApprovals.Columns["Status"].Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }


        private void cmbPopulate()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                conn.Open();
                const string query = @"
                    SELECT EventName
                    FROM POA
                    WHERE Status = 'Approved'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eventName = reader.GetString(0);
                        POAcmb.Items.Add(eventName);
                    }
                }
            }
        }

        private void pendingRequestsInitialization()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        BR.RequestID, 
                                        BR.TotalAmount, 
                                        BR.DateNeeded 
                                     FROM BudgetRequests BR
                                     INNER JOIN POA P ON BR.POAID = P.ID
                                     WHERE BR.Status = 'Pending'
                                     AND P.EventName = @POAName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@POAName", POAcmb.SelectedItem.ToString());

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPendingRequests.DataSource = dt;

                    // Hide ID
                    if (dgvPendingRequests.Columns["RequestID"] != null)
                        dgvPendingRequests.Columns["RequestID"].Visible = false;

                    // Format Money
                    if (dgvPendingRequests.Columns["TotalAmount"] != null)
                    {
                        dgvPendingRequests.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                        dgvPendingRequests.Columns["TotalAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading requests: " + ex.Message);
                }
            }
        }

        private void fundCalculation()
        {
            string selectedPOA = POAcmb.SelectedItem?.ToString() ?? "";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                conn.Open();
                decimal originalBudget = 0m;
                decimal usedFunds = 0m;
                decimal remainingFunds = 0m;

                string poaQuery = @"SELECT POA.ProposedBudget, SUM(BudgetRequests.TotalAmount) AS TotalAmount
                                    FROM POA
                                    INNER JOIN BudgetRequests ON POA.ID = BudgetRequests.POAID
                                    WHERE BudgetRequests.Status = 'Approved'
                                    AND POA.EventName = @POAName
                                    GROUP BY POA.ProposedBudget";

                using (SqlCommand cmd = new SqlCommand(poaQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@POAName", selectedPOA);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["ProposedBudget"] == DBNull.Value)
                                originalBudget = 0m;
                            else
                                originalBudget = Convert.ToDecimal(reader["ProposedBudget"]);

                            if (reader["TotalAmount"] == DBNull.Value)
                            {
                                usedFunds = 0m;
                            }
                            else
                                usedFunds = Convert.ToDecimal(reader["TotalAmount"]);

                            remainingFunds = originalBudget - usedFunds;
                        }
                        else
                        {
                            // no rows returned -> treat as zero
                            originalBudget = 0m;
                            usedFunds = 0m;
                            remainingFunds = 0m;
                        }
                    }
                }

                lblTotal.Text = originalBudget.ToString("C2", new CultureInfo("en-PH"));
                lblUsedFunds.Text = usedFunds.ToString("C2", new CultureInfo("en-PH"));
                lblRemainingFunds.Text = remainingFunds.ToString("C2", new CultureInfo("en-PH"));
            }          
        }


        private void POAcmb_SelectedIndexChanged(object sender, EventArgs e) 
        {
            pendingRequestsInitialization();
            fundCalculation();
        }
    }
}