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

        private void UpdateMaintenanceRecordForm_Load(object sender, EventArgs e)
        {
            var maintenanceId = ComboBoxData.GetMaintenanceIds();
            MaintenanceIdcomboBox.DataSource = maintenanceId;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
                int selectedMaintenanceId = Convert.ToInt32(MaintenanceIdcomboBox.SelectedItem);

                byte maintenanceStatus;
                DateTime? maintenanceEndDate = null;
                bool isMaintenanceStatusParsed = byte.TryParse(MaintenanceStatustextBox.Text, out maintenanceStatus);
                bool bmaintenanceDate = false;

                if (!string.IsNullOrEmpty(MaintenanceEndDatetextBox.Text))                   
                {
                    maintenanceEndDate = Convert.ToDateTime(MaintenanceEndDatetextBox.Text);
                    bmaintenanceDate = true;
                }
                
                if ((isMaintenanceStatusParsed || bmaintenanceDate))
                {
                    DB_Operations.UpdateMaintenance(selectedMaintenanceId, maintenanceStatus, maintenanceEndDate);
                }
                else
                {
                    MessageBox.Show("Please fill the boxes with the proper values");
                }
        }

    }
}
