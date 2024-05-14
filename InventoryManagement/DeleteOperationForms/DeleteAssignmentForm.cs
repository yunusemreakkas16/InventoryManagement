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

        private void DeleteAssignmentForm_Load(object sender, EventArgs e)
        {
            var assignmentId = ComboBoxData.GetAssignmentListIds();
            AssignmentIdcomboBox.DataSource = assignmentId;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm();
            assignmentForm.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int selectedAssignmentId = Convert.ToInt32(AssignmentIdcomboBox.SelectedItem);
            DB_Operations.DeleteAssignment(selectedAssignmentId);
        }
    }
}
