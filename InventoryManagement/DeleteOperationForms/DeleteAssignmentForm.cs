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
    public partial class DeleteAssignmentForm : Form
    {
        public DeleteAssignmentForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm();
            assignmentForm.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DeleteAssignmenttextBox.Text))
            {
                int assignmentId;

                if(int.TryParse(DeleteAssignmenttextBox.Text, out assignmentId))
                {
                    DB_Operations.DeleteAssignment(assignmentId);
                    MessageBox.Show("Assignment Deleted");
                }
                else
                {
                    MessageBox.Show("Please fill the box with the proper value.");
                }
            }
        }
    }
}
