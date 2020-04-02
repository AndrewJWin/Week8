using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************\
*                                  *
* Andrew Terwilliger 4/2/2020      *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace PayApp
{
    public partial class CustomerForm : Form
    {
        // Here we have a private StringBuilder for the submission, used in the btnPayment method.
        private StringBuilder submission = new StringBuilder();

        public CustomerForm()
        {
            InitializeComponent();
        }

        // Form loading method, pre-fills the Customer ComboBox with random "Customers".
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            cmbCustomer.Items.Add("John Doe");
            cmbCustomer.Items.Add("Jeff Stokes");
            cmbCustomer.Items.Add("Microsoft Corp");
            lblPayment.Text = "";
        }

        // Select Payment button method, creates and presents the payment form for the user to fill.
        private void btnPayment_Click(object sender, EventArgs e)
        {
            // Create the form.
            FormPayment formPayment = new FormPayment();
            // Show the form as a dialog.
            DialogResult formPaymentResults = formPayment.ShowDialog();

            // The following waits for the Dialog to close before continuing.
            // If the Tag has a string in it, we know this to be the Payment information - and to go ahead and fill the label.
            if (formPaymentResults == DialogResult.OK)
            {
                if (formPayment.Tag is string specialRequests)
                {
                    lblPayment.Text = specialRequests;
                }
            }
        }

        // If we change customers, we have to clear out the current payment information - As it may not match.
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPayment.Text = "";
        }

        // Save button method, takes the selected customer and builds a string to present showing the selected payment method.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Error handling - If we have not selected a customer, we cannot bill.
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer to bill.", "Missing Customer");
                return;
            }
            // Or if the billing information is blank, we don't know how to bill them.
            if (lblPayment.Text.Length == 0)
            {
                MessageBox.Show("Payment information is missing.", "Missing Payment Info");
                return;
            }

            // Otherwise, build into the submission StringBuilder.
            submission.Append($"Customer: {cmbCustomer.Text}\n\n")
                      .Append("Will be charged under the following Payment method:\n\n")
                      .Append($"{lblPayment.Text}");

            // Then present to the user.
            MessageBox.Show(submission.ToString(), "Payment Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Cancel button method. Nothing fancy here.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
