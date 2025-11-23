using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Student
{

    public partial class ReceiptForm : Form
    {
        public ReceiptData OutputData { get; private set; }

        // Variable to hold image temporarily
        private byte[] _imageBytes = null;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        public void SetCategories(List<string> categories)
        {
            // Assuming your dropdown is named 'cmbCategory'
            // If you named it 'cmbExpenseCategory', change it here!
            // Based on your UI description, likely 'cmbCategory' or 'cmbExpenseCategory'

            // CHECK DESIGNER NAME: I will assume 'cmbChargeTo' based on "Charge To Category" label
            // If red line appears, rename your combobox in design view to 'cmbChargeTo'
            cmbChargeTo.Items.Clear();
            foreach (string cat in categories)
            {
                cmbChargeTo.Items.Add(cat);
            }
        }


        public class ReceiptData
        {
            public string Invoice { get; set; }
            public string Supplier { get; set; }
            public string Category { get; set; } // e.g., "Food", "Venue"
            public decimal TotalAmount { get; set; }
            public byte[] ReceiptImage { get; set; } // Stores the picture
            public decimal AllottedBudget { get; set; } // Limit for this category
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.png;*.bmp;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblFileStatus.Text = Path.GetFileName(ofd.FileName); // Show filename

                    // Convert Image to Bytes for Database
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            _imageBytes = br.ReadBytes((int)fs.Length);
                        }
                    }
                }
            }
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            // 1. Validation
            if (string.IsNullOrWhiteSpace(txtInvoice.Text)) { MessageBox.Show("Enter Invoice Number"); return; }
            if (string.IsNullOrWhiteSpace(txtSupplier.Text)) { MessageBox.Show("Enter Supplier"); return; }
            if (cmbChargeTo.SelectedIndex == -1) { MessageBox.Show("Select a Category"); return; }
            if (_imageBytes == null) { MessageBox.Show("Please upload the receipt image"); return; }

            decimal total = 0;
            if (!decimal.TryParse(txtTotalAmount.Text, out total) || total <= 0)
            {
                MessageBox.Show("Enter a valid Total Amount");
                return;
            }

            // 2. Pack Data
            OutputData = new ReceiptData
            {
                Invoice = txtInvoice.Text,
                Supplier = txtSupplier.Text,
                Category = cmbChargeTo.Text,
                TotalAmount = total,
                ReceiptImage = _imageBytes
            };

            // 3. Close and Return
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

