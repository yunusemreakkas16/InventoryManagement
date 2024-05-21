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

            // Set the Format property to Custom
            this.AssignmentEnddateTimePicker.Format = DateTimePickerFormat.Custom;

            // Set the CustomFormat property to an empty string
            this.AssignmentEnddateTimePicker.CustomFormat = " ";
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

        private void AssignmentEnddateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            this.AssignmentEnddateTimePicker.CustomFormat = null;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            int selectedAssignmentId = Convert.ToInt32(AssignmentIdcomboBox.SelectedItem);
            DateTime endDate;
            endDate = AssignmentEnddateTimePicker.Value.Date;
            if (DateInRangeOperations.IsAssignmentDateInRange(selectedAssignmentId, endDate))
            {
                if(DB_Operations.UpdateAssignment(selectedAssignmentId, endDate))
                {
                    AssignmentForm assignmentForm = new AssignmentForm();
                    assignmentForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("The end date cannot be earlier than the entered date");
            }



        }
    }
}
