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
    public partial class DeleteMaintenanceRecordForm : Form
    {
        public DeleteMaintenanceRecordForm()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(DeleteMaintenancetextBox.Text))
            {
                int maintenanceId;
                if (int.TryParse(DeleteMaintenancetextBox.Text, out maintenanceId))
                {
                    DB_Operations.DeleteMaintenance(maintenanceId);
                    MessageBox.Show("Maintenance Record Deleted");
                }
                else 
                {
                    MessageBox.Show("Please fill the box with the proper value.");
                }
            }
        }


    }
}
