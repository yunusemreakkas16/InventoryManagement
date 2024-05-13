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

        private void UpdateAssignmentRecordForm_Load(object sender, EventArgs e)
        {
            var AssignmentIds = DB_Operations.ListAssignmentList().Select(a=> a.AssignmentId).ToList();
            AssignmentIdcomboBox.DataSource = AssignmentIds;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            int selectedAssignmentId = Convert.ToInt32(AssignmentIdcomboBox.SelectedItem);

            DateTime endDate;
            bool isendDate = DateTime.TryParse(AssignmentEndDatetextBox.Text, out endDate);

                if(isendDate)
                {
                    DB_Operations.UpdateAssignment(selectedAssignmentId, endDate);
                }
                else 
                {
                    MessageBox.Show("Please fill the box with the proper value");
                }
            
        }
    }
}
