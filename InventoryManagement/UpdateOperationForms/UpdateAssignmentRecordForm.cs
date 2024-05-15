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
            var AssignmentIds = ComboBoxData.GetAssignmentListIds();
            AssignmentIdcomboBox.DataSource = AssignmentIds;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            int selectedAssignmentId = Convert.ToInt32(AssignmentIdcomboBox.SelectedItem);

            DateTime endDate;

            endDate = AssignmentEnddateTimePicker.Value.Date;
            DB_Operations.UpdateAssignment(selectedAssignmentId, endDate);


            
        }
    }
}
