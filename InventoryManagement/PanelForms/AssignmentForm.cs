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

            dataGridView2.AutoGenerateColumns = false;

            // sets GridView manually to make columns

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemId",
                DataPropertyName = "ItemId",
                HeaderText = "Item ID",
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemName",
                DataPropertyName = "ItemName",
                HeaderText = "Item Name"
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemType",
                DataPropertyName = "Type",
                HeaderText = "Item Type"
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemStatus",
                DataPropertyName = "Status",
                HeaderText = "Item Status"
            });


            dataGridView3.AutoGenerateColumns = false;

            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AssignmentId",
                DataPropertyName = "AssignmentId",
                HeaderText = "Assignment ID"
            });

            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AssignmentDate",
                DataPropertyName= "AssignmentDate",
                HeaderText = "Assignment Date"
            });

            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AssignmentEndDate",
                DataPropertyName = "AssignmentEndDate",
                HeaderText = "Assignment End Date"
            });

            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonnelId",
                DataPropertyName = "FK_PersonnelId",
                HeaderText = "Personnel ID"
            });

            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemId",
                DataPropertyName = "FK_ItemId",
                HeaderText = "Item ID"
            });

            dataGridView2.DataSource = DB_Operations.ListItems();
            dataGridView1.DataSource = DB_Operations.ListPersonnel();
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
