using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowShovel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting minimum and maximum dates to the DateTimePicker, we're only able to do appointments
            // 7 Days ahead of time, and the easliest is the same day. So we will need to set those now.

            dteAppointment.MinDate = DateTime.Today;
            dteAppointment.MaxDate = DateTime.Today.AddDays(7);
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            // Create the form.
            FormSpecialRequests frmSpecialRequests = new FormSpecialRequests();
            // Set the tag as the current text in the Requests Form.
            frmSpecialRequests.Tag = lblRequests.Text;
            // Show the form as a dialog.
            DialogResult specialRequestResults = frmSpecialRequests.ShowDialog();

            // The following waits for the Dialog to close before continuing.
            if (specialRequestResults == DialogResult.OK)
            {
                if (frmSpecialRequests.Tag is string specialRequests)
                {
                    lblRequests.Text = specialRequests;
                }
            }
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            // Storing variables under appropriate names.
            string name = txbName.Text;
            string address = txbAddress.Text;
            DateTime date = dteAppointment.Value;

            // If any of the forms are missing or invalid, inform the user to fix.
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(address) || date == null)
            {
                MessageBox.Show("Please fill in all the fields", "Error");
                return;
            }

            // Initializing price value as a double variable.
            double price;

            // Figuring which radio is selected to set the price.
            if (rdoSingle.Checked)
            {
                price = 20;
            }
            else
            {
                price = 30;
            }

            // If the selected Date is today, add an additional $5 for same-day service.
            if (date.Date == DateTime.Today)
            {
                price += 5;
            }

            // Finally setting the estimate price as a string formatted as currency.
            txbEstimate.Text = $"{price:c}";
        }
    }
}
