﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AddNewMaintenanceRecordForm : Form
    {
        public AddNewMaintenanceRecordForm()
        {
            InitializeComponent();

            // Set the Format property to Custom
            this.MaintenancedateTimePicker.Format = DateTimePickerFormat.Custom;

            // Set the CustomFormat property to an empty string
            this.MaintenancedateTimePicker.CustomFormat = " ";

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

        private void AddNewMaintenanceRecordForm_Load(object sender, EventArgs e)
        {
            var itemIds = ComboBoxData.GetUnassignedItemIds();
            ItemIdcomboBox.DataSource = itemIds;
        }

        private void MaintenancedateTimePicker_ValueChanged(object send, EventArgs e)
        {
            this.MaintenancedateTimePicker.CustomFormat = null;

        }

        private void MaintenanceEnddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.MaintenanceEnddateTimePicker.CustomFormat = null;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Check textboxes are empty or null
            if (!string.IsNullOrWhiteSpace(StatustextBox.Text))
            {
                int selectedItemId = Convert.ToInt32(ItemIdcomboBox.SelectedItem);

                DateTime date;
                DateTime endDate;
                byte status;

                date = MaintenancedateTimePicker.Value.Date;
                endDate = MaintenanceEnddateTimePicker.Value.Date;


                if (byte.TryParse(StatustextBox.Text, out status))
                {
                    if (DateInRangeOperations.IsDateInRange(date, endDate))
                    {
                        if(DB_Operations.AddMaintenance(selectedItemId, status, date, endDate))
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
                    MessageBox.Show("Please enter a valid status value.");
                }



            }
            else
            {
                // To warn user who  makes  empty spaces.
                MessageBox.Show("Please fill the box that you’ve left empty.");
            }
        }
    }
}
