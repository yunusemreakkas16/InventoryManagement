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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(PersonnelIdtextBox.Text))
            {
                int personnelId;

                if(int.TryParse(PersonnelIdtextBox.Text, out personnelId))
                {
                    DB_Operations.UpdatePersonnel(personnelId,PersonnelNametextBox.Text,PersonnelSurnametextBox.Text,DepartmenttextBox.Text);
                }
                else
                {
                    MessageBox.Show("Please fill the ID box with the proper value.");
                }
            }
            else
            {
                MessageBox.Show("The ID field must be filled");
            }
        }
    }
}
