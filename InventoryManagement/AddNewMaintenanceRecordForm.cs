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

        private void Save_Click(object sender, EventArgs e)
        {
            // Check textboxes are empty or null
            if (!string.IsNullOrWhiteSpace(ItemIdtextBox.Text) && !string.IsNullOrWhiteSpace(StatustextBox.Text) && !string.IsNullOrWhiteSpace(MaintenanceDatetextBox.Text) && !string.IsNullOrWhiteSpace(MaintenanceDateEndtextBox.Text))
            {
                DateTime date;
                DateTime endDate;
                byte status;
                int itemId;
                if (DateTime.TryParse(MaintenanceDatetextBox.Text, out date) && DateTime.TryParse(MaintenanceDateEndtextBox.Text, out endDate) && byte.TryParse(StatustextBox.Text, out status) && int.TryParse(ItemIdtextBox.Text, out itemId))
                {
                    DB_Operations.AddMaintenance(itemId, status, date, endDate);
                    MessageBox.Show("New Item Added.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid values.");
                }

            }
            else
            {
                // To warn user who  makes  empty spaces.
                MessageBox.Show("Please fill the boxes that you’ve left empty.");
            }
        }
    }
}
