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
    public partial class UpdateMaintenanceRecordForm : Form
    {
        public UpdateMaintenanceRecordForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MaintenanceIdtextBox.Text))
            {
                int maintenanceId;
                byte maintenanceStatus;
                DateTime maintenanceEndDate;

                bool isMaintenanceIdParsed = int.TryParse(MaintenanceIdtextBox.Text, out maintenanceId);
                bool isMaintenanceStatusParsed = byte.TryParse(MaintenanceStatustextBox.Text, out maintenanceStatus);
                bool isMaintenanceEndDateParsed = DateTime.TryParse(MaintenanceEndDatetextBox.Text, out maintenanceEndDate);

                if (isMaintenanceIdParsed && (isMaintenanceStatusParsed || isMaintenanceEndDateParsed))
                {
                    DB_Operations.UpdateMaintenance(maintenanceId, maintenanceStatus, maintenanceEndDate);
                }
                else
                {
                    MessageBox.Show("Please fill the boxes with the proper values");
                }
            }
            else
            {
                MessageBox.Show("The ID field must be filled");
            }
        }

    }
}
