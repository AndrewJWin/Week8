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

namespace Week8
{
    public partial class Form1 : Form
    {
        // Here we're generating the SortedList of availible programs through this particular college.
        SortedList<string, string[]> programs;

        // This generates the string objects to be added or used for the programs and how the student heard about the school.
        string[] ITPrograms = { "Programming", "Security", "Networking" };
        string[] EngineeringPrograms = { "Electrical", "Mechanical" };
        string[] HearingAbout = { "Another Student", "Another School", "Internet Search" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Here we add the programs to the premade SortedList.
            programs = new SortedList<string, string[]>
            {
                { "Information Technology", ITPrograms },
                { "Engineering", EngineeringPrograms },
            };

            // Here we add all the keys to the comboBox for the drop-down list.
            cbxDeps.Items.AddRange(programs.Keys.ToArray());
            cbxDeps.SelectedIndex = 0;

            // Adding the range of the options the student has for hearing about the college, or the dropdown allows them to input their own.
            cbxHeard.Items.AddRange(HearingAbout);
        }

        // Department ComboBox selection change Method, updates the Degree list with the proper Degrees for the selected Department.
        private void cbxDeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDegrees.Items.Clear();

            string department = cbxDeps.Text;

            if (department != null)
            {
                string[] degrees = programs[department];
                lstDegrees.Items.AddRange(degrees);
            }
        }

        // Degree list selection value change method, just updates the text with how many degrees are selected.
        private void lstDegrees_SelectedValueChanged(object sender, EventArgs e)
        {
            int numberSelected = lstDegrees.SelectedItems.Count;
            lblSelected.Text =  $"{numberSelected} Selected";
        }

        // "Submit" button method, checks all the fields for errors and builds the summary.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Building a list of errors that can be added to if needed.
            List<string> errors = new List<string>();

            // All the possible errors that could occur.
            if (cbxDeps.SelectedIndex == -1)
            {
                errors.Add("Select a Semester");
            }

            if (lstDegrees.SelectedItems.Count == 0)
            {
                errors.Add("Select at least one degree");
            }

            if (String.IsNullOrEmpty(cbxHeard.Text))
            {
                errors.Add("Type or select how you heard of us");
            }
            
            // If there is at least 1 error, we cannot continue - Return the function and tell the user what the error was.
            if (errors.Count > 0)
            {
                MessageBox.Show(String.Join("\n", errors), "Error");
                return;
            }

            // summary StringBuilder, here we append with the final information the user has inputed.
            StringBuilder summaryBuilder = new StringBuilder();

            summaryBuilder.Append("Summary")
                .Append("\n\nDepartment: ").Append(cbxDeps.Text)
                .Append("\n\nPrograms:\n");
            foreach (object degree in lstDegrees.SelectedItems)
            {
                summaryBuilder.Append(degree).Append("\n");
            }
            summaryBuilder.Append("\nYou hear about us from: ").Append(cbxHeard.Text);

            // Make the summary into a string, and show it in a new MessageBox.
            string summary = summaryBuilder.ToString();
            MessageBox.Show(summary, "Thank you!");

            // We're done - So we will close the program.
            this.Close();
        }
    }
}
