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
    public partial class UpdatePersonnelForm : Form
    {
        public UpdatePersonnelForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PersonnelPanelForm personnelPanelForm = new PersonnelPanelForm();
            personnelPanelForm.Show();
            this.Close();
        }

        private void UpdatePersonnelForm_load(object sender, EventArgs e)
        {
            var personnelIds = DB_Operations.ListPersonnel().Select(p=> p.PersonnelId).ToList();
            PersonnelIdcomboBox.DataSource = personnelIds;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int selectedPersonnelId = Convert.ToInt32(PersonnelIdcomboBox.SelectedItem);
            DB_Operations.UpdatePersonnel(selectedPersonnelId,PersonnelNametextBox.Text,PersonnelSurnametextBox.Text,DepartmenttextBox.Text);
        }
    }
}
