using Microsoft.Data.SqlClient;
using Project_SIGMA__A_Budget_Request_Application_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class BudgetRequest : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        private decimal _currentRemainingBalance = 0;
        private bool _isEditMode = false;
        private int _requestIDToEdit = -1;

        public BudgetRequest(int requestID)
        {
            InitializeComponent();
            _isEditMode = true;
            _requestIDToEdit = requestID;

            LoadApprovedEvents(); // Load the dropdown first
            LoadDataForEdit();    // Then fill the form
        }

        private void LoadDataForEdit()
        {
            btnSubmitRequest.Text = "UPDATE REQUEST";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // A. GET HEADER INFO
                string query = "SELECT * FROM BudgetRequests WHERE RequestID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", _requestIDToEdit);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 1. Select the correct Event in Dropdown
                            int poaID = Convert.ToInt32(reader["POAID"]);
                            foreach (ComboBoxItem item in cmbApprovedEvents.Items)
                            {
                                if (item.Value == poaID)
                                {
                                    cmbApprovedEvents.SelectedItem = item;
                                    break;
                                }
                            }

                            // 2. Fill TextFields
                            dtpDateNeeded.Value = Convert.ToDateTime(reader["DateNeeded"]);
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtStudentRemarks.Text = reader["StudentRemarks"].ToString();
                        }
                    }
                }

                // B. GET PARTICULAR ITEMS (Grid)
                string itemQuery = "SELECT ItemName, Quantity, Amount, Supplier, TotalCost FROM BudgetParticulars WHERE RequestID = @ID";
                using (SqlCommand cmdItems = new SqlCommand(itemQuery, conn))
                {
                    cmdItems.Parameters.AddWithValue("@ID", _requestIDToEdit);
                    using (SqlDataReader itemReader = cmdItems.ExecuteReader())
                    {
                        dgvParticulars.Rows.Clear();
                        while (itemReader.Read())
                        {
                            dgvParticulars.Rows.Add(
                                itemReader["ItemName"].ToString(),
                                itemReader["Quantity"].ToString(),
                                itemReader["Amount"].ToString(),
                                itemReader["Supplier"].ToString(), // Make sure this matches your ComboBox items
                                itemReader["TotalCost"].ToString()
                            );
                        }
                    }
                }

                // C. Recalculate Totals
                CalculateGrandTotal();
            }
        }
        public BudgetRequest()
        {
            InitializeComponent();
            LoadApprovedEvents();
        }

        private void LoadApprovedEvents()

        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Get ID and EventName, but ONLY for 'Approved' events by this User
                    string query = @"SELECT ID, EventName 
                                 FROM POA 
                                 WHERE Status = 'Approved' 
                                 AND SubmittedBy = @User";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", UserSession.Username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbApprovedEvents.Items.Clear();

                            while (reader.Read())
                            {
                                ComboBoxItem item = new ComboBoxItem();
                                item.Text = reader["EventName"].ToString();
                                item.Value = Convert.ToInt32(reader["ID"]); // This is the POA ID

                                cmbApprovedEvents.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading events: " + ex.Message);
                }
            }
        }

        // 2. WHEN USER SELECTS AN EVENT -> CALCULATE BALANCE
        // (Make sure to link this event in the Designer!)
        private void cmbApprovedEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbApprovedEvents.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)cmbApprovedEvents.SelectedItem;
                int poaID = selectedItem.Value;

                CalculateRemainingBalance(poaID);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalBudget_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void CalculateRemainingBalance(int poaID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // A. GET ORIGINAL POA BUDGET
                decimal originalBudget = 0;
                string poaQuery = "SELECT ProposedBudget, EventDate FROM POA WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(poaQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", poaID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            originalBudget = Convert.ToDecimal(reader["ProposedBudget"]);
                            lblTotalBudget.Text = "Total POA Budget: " + originalBudget.ToString("C2");
                            lblDate.Text = "Event Date: " + Convert.ToDateTime(reader["EventDate"]).ToShortDateString();
                        }
                    }
                }

                // B. GET TOTAL OF PREVIOUSLY APPROVED/PENDING REQUESTS
                // 1. Declare the variable HERE so it works everywhere
                decimal alreadyRequested = 0;

                string spentQuery = @"SELECT ISNULL(SUM(TotalAmount), 0) 
                              FROM BudgetRequests 
                              WHERE POAID = @ID 
                              AND Status != 'Rejected'";

                // 2. Modify Query if Editing
                if (_isEditMode)
                {
                    spentQuery += " AND RequestID != @CurrentReqID";
                }

                using (SqlCommand cmdSpent = new SqlCommand(spentQuery, conn))
                {
                    cmdSpent.Parameters.AddWithValue("@ID", poaID);

                    // 3. Add Parameter if Editing
                    if (_isEditMode)
                    {
                        cmdSpent.Parameters.AddWithValue("@CurrentReqID", _requestIDToEdit);
                    }

                    alreadyRequested = Convert.ToDecimal(cmdSpent.ExecuteScalar());
                }

                // C. CALCULATE AND DISPLAY
                // Now 'alreadyRequested' exists and can be used here
                _currentRemainingBalance = originalBudget - alreadyRequested;

                lblRemainingBalance.Text = "Remaining Balance: " + _currentRemainingBalance.ToString("C2");

                if (_currentRemainingBalance <= 0)
                    lblRemainingBalance.ForeColor = System.Drawing.Color.Red;
                else
                    lblRemainingBalance.ForeColor = System.Drawing.Color.DarkGreen;
            }
        }

        private void BudgetRequest_Load(object sender, EventArgs e)
        {
            LoadApprovedEvents();
        }

        private void cmbApprovedEvents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbApprovedEvents.SelectedItem != null)
            {
                // 1. Unpack the selected item to get the ID
                ComboBoxItem selectedItem = (ComboBoxItem)cmbApprovedEvents.SelectedItem;
                int poaID = selectedItem.Value;

                // 2. Call the calculation function
                CalculateRemainingBalance(poaID);
            }
        }

        private void dgvParticulars_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParticulars.Columns[e.ColumnIndex].Name == "colQty" ||
        dgvParticulars.Columns[e.ColumnIndex].Name == "colAmount")
            {
                DataGridViewRow row = dgvParticulars.Rows[e.RowIndex];

                // Variables to hold numbers
                decimal qty = 0;
                decimal amount = 0;

                // Safe conversion (prevents crash if they type "abc" or leave it empty)
                decimal.TryParse(Convert.ToString(row.Cells["colQty"].Value), out qty);
                decimal.TryParse(Convert.ToString(row.Cells["colAmount"].Value), out amount);

                // Math: Quantity * Amount
                decimal total = qty * amount;

                // Display result in the Total column
                row.Cells["colTotal"].Value = total.ToString("N2");

                // Now recalculate the bottom label
                CalculateGrandTotal();
            }
        }

        private void CalculateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvParticulars.Rows)
            {
                // Skip empty rows to avoid errors
                if (row.Cells["colTotal"].Value != null)
                {
                    decimal rowTotal = 0;
                    decimal.TryParse(row.Cells["colTotal"].Value.ToString(), out rowTotal);
                    grandTotal += rowTotal;
                }
            }

            // Update the big label
            lblGrandTotal.Text = grandTotal.ToString("C2");

            // IMPORTANT: Store the raw number in the Tag so we can use it for saving later
            lblGrandTotal.Tag = grandTotal;

            // --- VALIDATION LOGIC ---

            // 1. Check if they are asking for more money than they have
            if (grandTotal > _currentRemainingBalance)
            {
                lblGrandTotal.ForeColor = Color.Red;
                MessageBox.Show($"Warning: You are requesting {grandTotal:C2}, but you only have {_currentRemainingBalance:C2} remaining!", "Over Budget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSubmitRequest.Enabled = false; // Block submission
            }
            // 2. Check if total is 0 (Cannot submit empty request)
            else if (grandTotal <= 0)
            {
                lblGrandTotal.ForeColor = Color.Black;
                btnSubmitRequest.Enabled = false;
            }
            // 3. Everything looks good
            else
            {
                lblGrandTotal.ForeColor = Color.DarkGreen;
                btnSubmitRequest.Enabled = true; // Allow submission
            }
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            // 1. VALIDATION
            if (lblGrandTotal.Tag == null || Convert.ToDecimal(lblGrandTotal.Tag) <= 0)
            {
                MessageBox.Show("Cannot submit a request with 0 amount.", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbApprovedEvents.SelectedItem == null)
            {
                MessageBox.Show("Please select an Approved Event first.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm Submission
            string actionWord = _isEditMode ? "update" : "submit";
            if (MessageBox.Show($"Are you sure you want to {actionWord} this budget request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // 2. PREPARE DATA
            ComboBoxItem selectedEvent = (ComboBoxItem)cmbApprovedEvents.SelectedItem;
            int poaID = selectedEvent.Value;
            decimal totalRequest = Convert.ToDecimal(lblGrandTotal.Tag);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int activeRequestID = 0;

                    // 3. DETERMINE IF INSERT OR UPDATE
                    if (_isEditMode)
                    {
                        // --- A. UPDATE MODE ---
                        activeRequestID = _requestIDToEdit; // Use the existing ID

                        // 3.1 Update the Main Info (Header)
                        string updateQuery = @"UPDATE BudgetRequests SET 
                                       POAID=@POAID, DateNeeded=@DateNeeded, ContactNumber=@Contact, 
                                       StudentRemarks=@Remarks, TotalAmount=@Total, 
                                       Status='Pending', DateSubmitted=GETDATE() 
                                       WHERE RequestID=@ID";

                        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn, transaction))
                        {
                            cmdUpdate.Parameters.AddWithValue("@POAID", poaID);
                            cmdUpdate.Parameters.AddWithValue("@DateNeeded", dtpDateNeeded.Value);
                            cmdUpdate.Parameters.AddWithValue("@Contact", txtContactNumber.Text);
                            cmdUpdate.Parameters.AddWithValue("@Remarks", txtStudentRemarks.Text);
                            cmdUpdate.Parameters.AddWithValue("@Total", totalRequest);
                            cmdUpdate.Parameters.AddWithValue("@ID", activeRequestID);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        // 3.2 DELETE OLD ITEMS (To clean slate for new items)
                        string deleteItems = "DELETE FROM BudgetParticulars WHERE RequestID = @ID";
                        using (SqlCommand cmdDel = new SqlCommand(deleteItems, conn, transaction))
                        {
                            cmdDel.Parameters.AddWithValue("@ID", activeRequestID);
                            cmdDel.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // --- B. INSERT MODE ---
                        string headerQuery = @"INSERT INTO BudgetRequests 
                                       (POAID, DateNeeded, ContactNumber, StudentRemarks, TotalAmount, Status, SubmittedBy, DateSubmitted) 
                                       VALUES 
                                       (@POAID, @DateNeeded, @Contact, @Remarks, @Total, 'Pending', @User, GETDATE());
                                       SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmdHeader = new SqlCommand(headerQuery, conn, transaction))
                        {
                            cmdHeader.Parameters.AddWithValue("@POAID", poaID);
                            cmdHeader.Parameters.AddWithValue("@DateNeeded", dtpDateNeeded.Value);
                            cmdHeader.Parameters.AddWithValue("@Contact", txtContactNumber.Text);
                            cmdHeader.Parameters.AddWithValue("@Remarks", txtStudentRemarks.Text);
                            cmdHeader.Parameters.AddWithValue("@Total", totalRequest);
                            cmdHeader.Parameters.AddWithValue("@User", UserSession.Username);

                            // Get the New ID
                            activeRequestID = Convert.ToInt32(cmdHeader.ExecuteScalar());
                        }
                    }

                    // 4. INSERT CHILDREN (BudgetParticulars) - Loop through the grid
                    // This logic is shared! It inserts items for BOTH new and updated requests.
                    foreach (DataGridViewRow row in dgvParticulars.Rows)
                    {
                        if (!row.IsNewRow && row.Cells["colTotal"].Value != null)
                        {
                            // Safe Data Retrieval
                            string itemName = Convert.ToString(row.Cells["colItem"].Value);
                            string supplier = Convert.ToString(row.Cells["colSupplier"].Value);
                            decimal qty = 0;
                            decimal amount = 0;

                            decimal.TryParse(Convert.ToString(row.Cells["colQty"].Value), out qty);
                            decimal.TryParse(Convert.ToString(row.Cells["colAmount"].Value), out amount);

                            // Insert Query
                            string detailQuery = @"INSERT INTO BudgetParticulars 
                                           (RequestID, ItemName, Quantity, Amount, Supplier) 
                                           VALUES 
                                           (@ReqID, @Item, @Qty, @Amt, @Supp)";

                            using (SqlCommand cmdDetail = new SqlCommand(detailQuery, conn, transaction))
                            {
                                cmdDetail.Parameters.AddWithValue("@ReqID", activeRequestID); // Uses either the New ID or Existing ID
                                cmdDetail.Parameters.AddWithValue("@Item", itemName);
                                cmdDetail.Parameters.AddWithValue("@Qty", qty);
                                cmdDetail.Parameters.AddWithValue("@Amt", amount);
                                cmdDetail.Parameters.AddWithValue("@Supp", supplier);

                                cmdDetail.ExecuteNonQuery();
                            }
                        }
                    }

                    // 5. SUCCESS
                    transaction.Commit();

                    if (_isEditMode)
                        MessageBox.Show("Request Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Budget Request Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving request: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private string NumberToWords(int number)
        {
            if (number == 0) return "ZERO";

            if (number < 0) return "MINUS " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " MILLION ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " HUNDRED ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "") words += " ";

                var unitsMap = new[] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
                var tensMap = new[] { "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 1. DEFINE FONTS
            Font fontTitle = new Font("Times New Roman", 14, FontStyle.Bold);
            Font fontBold = new Font("Times New Roman", 11, FontStyle.Bold);
            Font fontReg = new Font("Times New Roman", 11, FontStyle.Regular);
            Font fontSmall = new Font("Times New Roman", 10, FontStyle.Regular);

            Brush brush = Brushes.Black;
            Pen linePen = new Pen(Brushes.Black, 1);

            // 2. PAGE SETUP
            int leftMargin = 80;
            int rightMargin = 770;
            int y = 80;

            // ==========================================
            // SECTION 1: HEADINGS & DATE
            // ==========================================

            // CORRECT DATE FORMAT: "October 9, 2025"
            string dateStr = DateTime.Now.ToString("MMMM d, yyyy");
            e.Graphics.DrawString(dateStr, fontReg, brush, leftMargin, y);

            // Title
            e.Graphics.DrawString("Budget Request", fontTitle, brush, rightMargin - 150, y);
            y += 50;

            // Addressee 1
            e.Graphics.DrawString("DR. MARIA LORETO ANGELES-CANLAS, CPA", fontBold, brush, leftMargin, y);
            y += 20;
            e.Graphics.DrawString("Vice President for Finance", fontReg, brush, leftMargin, y);
            y += 40;

            // Through
            e.Graphics.DrawString("Through:", fontReg, brush, leftMargin, y);
            e.Graphics.DrawString("MS. HERMILINDA E. LACSON", fontBold, brush, leftMargin + 80, y);
            y += 20;
            e.Graphics.DrawString("Chief Accountant and Budget Officer", fontReg, brush, leftMargin + 80, y);
            y += 40;

            // Salutation
            e.Graphics.DrawString("Dear Madam,", fontReg, brush, leftMargin, y);
            y += 30;

            // ==========================================
            // SECTION 2: THE BODY (Dynamic Words)
            // ==========================================

            e.Graphics.DrawString("Greetings of Peace and Favor from God!", fontReg, brush, leftMargin, y);
            y += 30;

            // --- DYNAMIC AMOUNT LOGIC ---
            decimal totalAmount = lblGrandTotal.Tag != null ? Convert.ToDecimal(lblGrandTotal.Tag) : 0;

            // 1. Get numeric string (e.g., "1,450.00")
            string amountNumber = totalAmount.ToString("N2");

            // 2. Get word string (e.g., "ONE THOUSAND FOUR HUNDRED FIFTY PESOS")
            string amountWords = NumberToWords((int)totalAmount) + " PESOS";

            string paragraph1 = $"We, the College of Computer Studies - College Student Council (CCS-CSC), would like to formally request the budget of {amountWords} (PHP {amountNumber}) from the Student Activity Funds.";

            RectangleF rect1 = new RectangleF(leftMargin, y, rightMargin - leftMargin, 60);
            e.Graphics.DrawString(paragraph1, fontReg, brush, rect1);
            y += 50;

            // Paragraph 2: Event Name & Date
            string eventName = cmbApprovedEvents.Text;

            // Parse the Event Date safely to reformat it
            string rawEventDate = lblDate.Text.Replace("Event Date:", "").Trim();
            string formattedEventDate = rawEventDate;
            if (DateTime.TryParse(rawEventDate, out DateTime parsedDate))
            {
                formattedEventDate = parsedDate.ToString("MMMM d, yyyy"); // Reformat to October 9, 2025
            }

            string paragraph2 = $"This requested budget is designated for the {eventName} scheduled to take place on {formattedEventDate}.";
            RectangleF rect2 = new RectangleF(leftMargin, y, rightMargin - leftMargin, 40);
            e.Graphics.DrawString(paragraph2, fontReg, brush, rect2);
            y += 40;

            // Paragraph 3 & 4  
            e.Graphics.DrawString("Thank you very much for your unwavering support and cooperation!", fontReg, brush, leftMargin, y);
            y += 40;

            e.Graphics.DrawString("In Angelenean Spirit and Excellence,", fontReg, brush, leftMargin, y);
            y += 50;

            // ==========================================
            // SECTION 3: SIGNATORIES
            // ==========================================

            int sigLeftX = leftMargin;
            int sigRightX = 450;

            // 1. Treasurer & President
            e.Graphics.DrawString("LAUREN KAILEY A. FRANCISCO", fontBold, brush, sigLeftX, y);
            y += 20;
            e.Graphics.DrawString("Treasurer, CCS-College Student Council", fontSmall, brush, sigLeftX, y);
            y += 40;

            e.Graphics.DrawString("DON HENESSY DAVID", fontBold, brush, sigLeftX, y);
            y += 20;
            e.Graphics.DrawString("President, CCS-College Student Council", fontSmall, brush, sigLeftX, y);
            y += 40;

            // 2. Adviser
            e.Graphics.DrawString("Noted by:", fontReg, brush, sigLeftX, y);
            y += 40;
            e.Graphics.DrawString("DR. DAISY S. YAP", fontBold, brush, sigLeftX, y);
            y += 20;
            e.Graphics.DrawString("Adviser, CCS-College Student Council", fontSmall, brush, sigLeftX, y);
            y += 40;

            // 3. Recommending Approval
            e.Graphics.DrawString("Recommending Approval:", fontReg, brush, sigLeftX, y);
            y += 40;

            // Dean (Left)
            e.Graphics.DrawString("DR. LILIBETH T. CUISON", fontBold, brush, sigLeftX, y);
            e.Graphics.DrawString("Dean, College of Computer Studies", fontSmall, brush, sigLeftX, y + 20);

            // OSA Director (Right)
            e.Graphics.DrawString("MR. PRINCE ROMEL S. PANGILINAN", fontBold, brush, sigRightX, y);
            e.Graphics.DrawString("Director, OSA and Financial Aid", fontSmall, brush, sigRightX, y + 20);

            // ==========================================
            // SECTION 4: THE TABLE (Page 2)
            // ==========================================

            y += 100;
            e.Graphics.DrawLine(linePen, leftMargin, y, rightMargin, y);
            y += 20;

            e.Graphics.DrawString(eventName.ToUpper(), fontTitle, brush, leftMargin, y);
            y += 25;
            e.Graphics.DrawString("Cheque Payee and Release Date", fontReg, brush, leftMargin, y);
            y += 40;

            int col1 = leftMargin;
            int col2 = leftMargin + 250;
            int col3 = leftMargin + 350;
            int col4 = leftMargin + 550;

            e.Graphics.DrawString("PARTICULARS", fontBold, brush, col1, y);
            e.Graphics.DrawString("AMOUNT", fontBold, brush, col2, y);
            e.Graphics.DrawString("PAYEE", fontBold, brush, col3, y);
            e.Graphics.DrawString("RELEASE DATE", fontBold, brush, col4, y);

            y += 20;
            e.Graphics.DrawLine(linePen, leftMargin, y, rightMargin, y);
            y += 10;

            foreach (DataGridViewRow row in dgvParticulars.Rows)
            {
                if (!row.IsNewRow && row.Cells["colTotal"].Value != null)
                {
                    string item = row.Cells["colItem"].Value?.ToString();
                    string total = row.Cells["colTotal"].Value?.ToString();
                    string payee = row.Cells["colSupplier"].Value?.ToString();

                    // Format the date needed as Month Day, Year
                    string relDate = dtpDateNeeded.Value.ToString("MMMM d, yyyy");

                    e.Graphics.DrawString(item, fontReg, brush, col1, y);
                    e.Graphics.DrawString("P " + total, fontReg, brush, col2, y);
                    e.Graphics.DrawString(payee, fontReg, brush, col3, y);
                    e.Graphics.DrawString(relDate, fontReg, brush, col4, y);

                    y += 25;
                }
            }

            y += 10;
            e.Graphics.DrawLine(linePen, leftMargin, y, rightMargin, y);
            y += 10;
            e.Graphics.DrawString("TOTAL: P " + amountNumber, fontBold, brush, col2, y);
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to close? Any unsaved data will be lost.",
        "Confirm Close",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            // Only close if they clicked 'Yes'
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

