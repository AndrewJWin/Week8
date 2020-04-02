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

namespace GeoQuiz
{
    public partial class FormCheating : Form
    {
        public FormCheating()
        {
            InitializeComponent();
        }

        // Loading function, takes the answer provided by the main program and pastes it into the lblAnswer field.
        private void FormCheating_Load(object sender, EventArgs e)
        {
            lblAnswer.Text = Tag.ToString();
        }

        // If the user is really lazy, we will go ahead and pre-fill the answer field in the main program.
        private void btnLazy_Click(object sender, EventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you really that lazy?", "Lazy Cheater",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            // This allows the main program to figure out that the user is really lazy and wants us to pre-fill the answer.
            this.Tag = true;
            if (closeResult == DialogResult.No)
            {
                return;
            }
            Close();
        }

        // Close button method, pretty basic - But it ensures the program does not pre-fill for the user.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            Close();
        }
    }
}
