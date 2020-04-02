using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

/**********************************\
*                                  *
* Andrew Terwilliger 4/2/2020      *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace PayApp
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }
        private void FormPayment_Load(object sender, EventArgs e)
        {
            // Adding all the accepted card types.
            lstCardType.Items.Add("Visa");
            lstCardType.Items.Add("Mastercard");
            lstCardType.Items.Add("American Express");
            lstCardType.SelectedIndex = 0;

            // Inserting the expiration year, only allowing up to 8 years in the future.
            int year = DateTime.Now.Year;
            int endYear = year + 8;
            while (year < endYear)
            {
                cbxExpY.Items.Add(year);
                year++;
            }
            cbxExpM.SelectedIndex = 0;
            cbxExpY.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                this.SaveData();
            }
        }

        private void SaveData()
        {
            StringBuilder msg = new StringBuilder();

            if (rdoCard.Checked == true)
            {
                msg.Append("Charge to Credit Card.\n\n")
                   .Append($"Card Type: {lstCardType.SelectedItem.ToString()}\n")
                   .Append($"Card Number: {txbCard.Text}\n")
                   .Append($"Expiration Date: {cbxExpM.SelectedItem.ToString()}/{cbxExpY.SelectedItem.ToString()}\n");
            }
            else
            {
                msg.Append("Send bill to Customer.\n\n");
            }
            msg.Append($"Default Billing: {ckbDefault.Checked}");
            this.Tag = msg.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private bool isValidData()
        {
            if (rdoCard.Checked)
            {
                if (lstCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry Error");
                    lstCardType.Focus();
                    return false;
                }

                if (txbCard.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number.", "Entry Error");
                    txbCard.Focus();
                    return false;
                }

                if (cbxExpM.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card expiration month.", "Entry Error");
                    cbxExpM.Focus();
                    return false;
                }

                if (cbxExpY.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card expiration year.", "Entry Error");
                    cbxExpY.Focus();
                    return false;
                }
            }
            return true;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCustomer.Checked)
            {
                disableControls();
            } else
            {
                enableControls();
            }
        }

        private void enableControls()
        {
            lstCardType.Enabled = true;
            txbCard.Enabled = true;
            cbxExpM.Enabled = true;
            cbxExpY.Enabled = true;
        }
        private void disableControls()
        {
            lstCardType.Enabled = false;
            txbCard.Enabled = false;
            cbxExpM.Enabled = false;
            cbxExpY.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
