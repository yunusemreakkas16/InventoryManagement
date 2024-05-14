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
    public partial class DeletePersonnelForm : Form
    {
        public DeletePersonnelForm()
        {
            InitializeComponent();
        }
        
        private void DeletePersonnelForm_Load(object sender, EventArgs e)
        {
            var names = ComboBoxData.GetPersonnelNames();
            NamecomboBox.DataSource = names;
            
            var surnames = ComboBoxData.GetPersonnelSurnames();
            SurnamecomboBox.DataSource= surnames;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PersonnelPanelForm personnelPanelForm = new PersonnelPanelForm();
            personnelPanelForm.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get the name and surname selected from the ComboBox
            string selectedName = NamecomboBox.SelectedItem.ToString();
            string selectedSurname = SurnamecomboBox.SelectedItem.ToString();

            // Delete the personnel using the selected name and surname
            DB_Operations.DeletePersonnel(selectedName, selectedSurname);
        }
    }
}
