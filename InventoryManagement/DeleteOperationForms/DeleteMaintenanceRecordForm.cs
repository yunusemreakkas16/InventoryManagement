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

        private void DeleteMaintenanceRecordForm_Load(object sender, EventArgs e)
        {
            var maintenanceids = ComboBoxData.GetMaintenanceIds();
            maintenanceIdscomboBox.DataSource = maintenanceids;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(maintenanceIdscomboBox.SelectedItem);
            DB_Operations.DeleteMaintenance(selectedId);
        }


    }
}
