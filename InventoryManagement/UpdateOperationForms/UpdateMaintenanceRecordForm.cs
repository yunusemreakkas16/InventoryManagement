﻿using System;
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
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
                int selectedMaintenanceId = Convert.ToInt32(MaintenanceIdcomboBox.SelectedItem);

                byte maintenanceStatus;
                bool isMaintenanceStatusParsed = byte.TryParse(MaintenanceStatustextBox.Text, out maintenanceStatus);

                
                if ((isMaintenanceStatusParsed || this.MaintenanceEndDate.HasValue))
                {
                    DB_Operations.UpdateMaintenance(selectedMaintenanceId, maintenanceStatus, this.MaintenanceEndDate);
                }
                else
                {
                    MessageBox.Show("Please fill the boxes");
                }
        }

    }
}
