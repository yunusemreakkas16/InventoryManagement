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
            dataGridView1.AutoGenerateColumns = false;

            // sets GridView manually to make columns

            #region
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonnelId",
                DataPropertyName = "PersonnelId",
                HeaderText = "Personnel ID",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonnelName",
                DataPropertyName = "PersonnelName",
                HeaderText = "Personnel Name"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonnelSurname",
                DataPropertyName = "PersonnelSurname",
                HeaderText = "Personnel Surname"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Department",
                DataPropertyName = "PersonnelDepartment",
                HeaderText = "Department"
            });
            dataGridView1.DataSource = DB_Operations.ListPersonnel();
            #endregion

            #region
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
            dataGridView2.DataSource = DB_Operations.ListItem();
            #endregion

            #region
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
            dataGridView3.DataSource = DB_Operations.ListAssignmentList();
            #endregion

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

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            var sortableColumn = "Department";
            SortingFunctions.SortDataGridView(dataGridView1,columnName,SortingFunctions.PersonnelDepartmentSort,DB_Operations.ListPersonnel,sortableColumn);
        }

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnName = dataGridView2.Columns[e.ColumnIndex].Name;
            var sortableColumn = "ItemType";
            SortingFunctions.SortDataGridView(dataGridView2,columnName, SortingFunctions.ItemTypeSort, DB_Operations.ListItem,sortableColumn);
        }

        private void dataGridView3_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnName = dataGridView3.Columns[e.ColumnIndex].Name;
            var sortableColumn = "PersonnelId";
            SortingFunctions.SortDataGridView(dataGridView3, columnName, SortingFunctions.AssignmentPersonnelIdSort, DB_Operations.ListAssignmentList,sortableColumn);
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            AssignmentCountlabel.Text = "Assignment Record Count: " + TableCounts.GetAssignmentRecordCount();
            ItemCountlabel.Text = "Item Record: " + TableCounts.GetItemCount();
            PersonnelCountlabel.Text = "Personnel Count: " + TableCounts.GetPersonnelCount();
        }
    }
}
