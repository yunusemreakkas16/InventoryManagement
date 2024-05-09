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
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();

            // Executes Grid view when form opens
            dataGridView1.DataSource = DB_Operations.ListPersonnel();
            dataGridView2.DataSource = DB_Operations.ListItems();
            dataGridView3.DataSource = DB_Operations.ListAssignmentList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPanelForm.Instance.Show();
            this.Close();
        }

        private void NewAssigmentButton_Click(object sender, EventArgs e)
        {
            AddNewAssignmentForm addMaintenanceRecordPanel = new AddNewAssignmentForm();
            addMaintenanceRecordPanel.Show();
            this.Close();
        }

        private void UnAssigment_Click(object sender, EventArgs e)
        {
            DeleteAssignmentForm deleteMaintenanceRecordPanel = new DeleteAssignmentForm();
            deleteMaintenanceRecordPanel.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateAssignmentRecordForm updateMaintenanceRecordPanel = new UpdateAssignmentRecordForm();
            updateMaintenanceRecordPanel.Show();
            this.Close();
        }
    }
}
