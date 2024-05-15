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
    public partial class AddNewMaintenanceRecordForm : Form
    {
        public AddNewMaintenanceRecordForm()
        {
            InitializeComponent();
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
                    DB_Operations.AddMaintenance(selectedItemId, status, date, endDate);
                    
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
