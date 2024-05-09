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
