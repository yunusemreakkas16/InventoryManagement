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
    public partial class UpdateAssignmentRecordForm : Form
    {
        public UpdateAssignmentRecordForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm();
            assignmentForm.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(AssignmentIdtextBox.Text))
            {
                int assignmentId;
                DateTime endDate;

                bool isassignmentIdParsed = int.TryParse( AssignmentIdtextBox.Text, out assignmentId ) ;
                bool isendDate = DateTime.TryParse(AssignmentEndDatetextBox.Text, out endDate);

                if(isassignmentIdParsed && isendDate)
                {
                    DB_Operations.UpdateAssignment(assignmentId, endDate);
                }
                else 
                {
                    MessageBox.Show("Please fill the box with the proper value");
                }
            }
            else
            {
                MessageBox.Show("Please fill  the boxes you left empy");
            }
        }
    }
}
