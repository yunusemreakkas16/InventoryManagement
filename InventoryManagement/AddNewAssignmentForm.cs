using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AddNewAssignmentForm : Form
    {
        public AddNewAssignmentForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm();
            assignmentForm.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DateTime assignmentDate;
            DateTime assignmentEndDate;

            if (!string.IsNullOrWhiteSpace(PersonnelNametextBox.Text) && !string.IsNullOrWhiteSpace(PersonnelSurnametextBox.Text) && !string.IsNullOrWhiteSpace(ItemNametextBox.Text) && !string.IsNullOrWhiteSpace(AssignmentDatetextBox.Text) && !string.IsNullOrWhiteSpace(AssignmentEndDatetextBox.Text))
            {
                if (DateTime.TryParse(AssignmentDatetextBox.Text, out assignmentDate) && DateTime.TryParse(AssignmentEndDatetextBox.Text, out assignmentEndDate))
                {
                    DB_Operations.AddAssignment(PersonnelNametextBox.Text, PersonnelSurnametextBox.Text, ItemNametextBox.Text, assignmentDate, assignmentEndDate);
                    MessageBox.Show("New Assignment Added.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid date.");
                }

            }
            else
            {
                // To warn user who  makes  empty spaces.
                MessageBox.Show("Please fill the boxes that you’ve left empty.");
            }
        }
    }
}
