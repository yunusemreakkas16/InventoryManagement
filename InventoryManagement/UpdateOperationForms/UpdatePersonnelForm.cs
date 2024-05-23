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
            var personnelIds = ComboBoxData.GetPersonnelId();
            PersonnelIdcomboBox.DataSource = personnelIds;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string name = TextBoxOperations.AdjustTextBoxNameValue(PersonnelNametextBox.Text);
            string surname = TextBoxOperations.AdjustTextBoxNameValue(PersonnelSurnametextBox.Text);
            string department  = TextBoxOperations.AdjustTextBoxCharacterLimit(DepartmenttextBox.Text);
            department = TextBoxOperations.AdjustTextBoxUpperCaseFirstCharacter(department);
            int selectedPersonnelId = Convert.ToInt32(PersonnelIdcomboBox.SelectedItem);
            if(DB_Operations.UpdatePersonnel(selectedPersonnelId,name, surname, department))
            {
                PersonnelPanelForm personnelPanelForm = new PersonnelPanelForm();
                personnelPanelForm.Show();
                this.Close();
            }
        }
    }
}
