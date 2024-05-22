using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement
{
    public partial class AddNewPersonnelForm : Form
    {
        public AddNewPersonnelForm()
        {
            InitializeComponent();
        }
        

        private void Back_Click(object sender, EventArgs e)
        {
            PersonnelPanelForm personnelPanelForm = new PersonnelPanelForm();
            personnelPanelForm.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Check textboxes are empty or null
            if (!string.IsNullOrWhiteSpace(PersonnelNametextBox.Text) && !string.IsNullOrWhiteSpace(PersonnelSurnametextBox.Text) && !string.IsNullOrWhiteSpace(PersonnelDepartmenttextBox.Text))
            {
                string name = TextBoxOperations.AdjustTextBoxNameValue(PersonnelNametextBox.Text);
                string surname = TextBoxOperations.AdjustTextBoxNameValue(PersonnelSurnametextBox.Text);
                string department = PersonnelDepartmenttextBox.Text.Substring(0, 1).ToUpper() + PersonnelDepartmenttextBox.Text.Substring(1);

                if (DB_Operations.AddPersonnel(name, surname, department))
                {
                    PersonnelPanelForm personnelPanelForm = new PersonnelPanelForm();
                    personnelPanelForm.Show();
                    this.Close();
                }
            }
            else
            {
                // To warn user who  makes  empty spaces.
                MessageBox.Show("Please fill the boxes that you’ve left empty");
            }
        }
    }
}
