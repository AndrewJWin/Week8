using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoQuiz
{
    public partial class FormCheating : Form
    {
        public FormCheating()
        {
            InitializeComponent();
        }

        private void FormCheating_Load(object sender, EventArgs e)
        {
            lblAnswer.Text = Tag.ToString();
        }

        private void btnLazy_Click(object sender, EventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you really that lazy?", "Lazy Cheater",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            this.Tag = true;
            if (closeResult == DialogResult.No)
            {
                return;
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            Close();
        }
    }
}
