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
        private DateTime? MaintenanceEndDate = null;
        public UpdateMaintenanceRecordForm()
        {
            InitializeComponent();

            // Set the Format property to Custom
            this.MaintenanceEnddateTimePicker.Format = DateTimePickerFormat.Custom;

            // Set the CustomFormat property to an empty string
            this.MaintenanceEnddateTimePicker.CustomFormat = " ";
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

        private void MaintenanceEnddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.MaintenanceEndDate = MaintenanceEnddateTimePicker.Value.Date;
            this.MaintenanceEnddateTimePicker.CustomFormat = null;
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int selectedMaintenanceId = Convert.ToInt32(MaintenanceIdcomboBox.SelectedItem);

            byte maintenanceStatus;
            bool isMaintenanceStatusParsed = byte.TryParse(MaintenanceStatustextBox.Text, out maintenanceStatus);

            if (isMaintenanceStatusParsed || this.MaintenanceEndDate.HasValue)
            {
                if (!this.MaintenanceEndDate.HasValue || DateInRangeOperations.IsMaintenanceDateInRange(selectedMaintenanceId, this.MaintenanceEndDate))
                {
                    if(DB_Operations.UpdateMaintenance(selectedMaintenanceId, maintenanceStatus, this.MaintenanceEndDate))
                    {
                        MaintenanceForm maintenanceForm = new MaintenanceForm();
                        maintenanceForm.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The end date cannot be earlier than the entered date");
                }
            }
            else
            {
                MessageBox.Show("Please fill the boxes");
            }
        }

    }
}
