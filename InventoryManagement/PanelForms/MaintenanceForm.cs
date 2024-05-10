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
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();

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



            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {   Name = "MaintenanceId",
                DataPropertyName = "MaintenanceId",
                HeaderText = "Maintenance ID"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn 
            {
                Name = "MaintenanceStatus",
                DataPropertyName = "Status",
                HeaderText = "Maintenance Status"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaintenanceDate",
                DataPropertyName = "MaintenanceDate",
                HeaderText = "Maintenance Date"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaintenanceEndDate",
                DataPropertyName = "MaintenanceEndDate",
                HeaderText = "Maintenance End Date"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemId",
                DataPropertyName = "FK_ItemId",
                HeaderText = "Item ID"
            });

            dataGridView1.DataSource = DB_Operations.ListMaintenanceList();    // Shows data when Maintenance Panel is opened
            dataGridView2.DataSource = DB_Operations.ListItems();              // Shows data when Maintenance Panel is opened
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPanelForm.Instance.Show();                  //Return to Main Interface                  
            this.Close();                                   //Closes  a Form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewMaintenanceRecordForm addNewMaintenanceRecordForm = new AddNewMaintenanceRecordForm();
            addNewMaintenanceRecordForm.Show();
            this.Close();
        }

        private void RemoveServiceRecordButton_Click(object sender, EventArgs e)
        {
            DeleteMaintenanceRecordForm deleteMaintenanceRecordForm = new DeleteMaintenanceRecordForm();
            deleteMaintenanceRecordForm.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateMaintenanceRecordForm updateMaintenanceRecordForm = new UpdateMaintenanceRecordForm();
            updateMaintenanceRecordForm.Show();
            this.Close();
        }
    }
}
