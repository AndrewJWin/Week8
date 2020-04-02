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
    public partial class FormSpecialRequests : Form
    {
        private bool Saved = false;
        public FormSpecialRequests()
        {
            InitializeComponent();
        }

        private void FormSpecialRequests_Load(object sender, EventArgs e)
        {
            txtRequests.Text = Tag.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Storing the users special requests in the forms Tag propery.
            // The main form will be able to view this property, and the data included with it.
            Tag = txtRequests.Text;
            // Setting that the information has been saved.
            Saved = true;
            // Then let the dialog result know that we have saved successfully.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {   
            Close();
        }


        private void FormSpecialRequests_Close(object sender, FormClosingEventArgs e)
        {
            // By intercepting the form close event, we can verify with the user if they want to save the data they have inputed.
            // If the user approves losing the data, allow closing the form.
            // Elsewise, let the user close the form.

            bool userMadeChanges = Tag.ToString() != txtRequests.Text;

            // If not saved, and changes have been made - confirm if they want to keep the changes.
            if (!Saved && userMadeChanges)
            {
                DialogResult closeResult = MessageBox.Show("Your changes have not been saved, close anyway?", "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (closeResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }
    }
}
