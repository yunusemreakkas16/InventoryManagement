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

        private void BackButton_Click(object sender, EventArgs e)
        {
            PersonnelPanelForm personnelPanelForm = new PersonnelPanelForm();
            personnelPanelForm.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Check textboxes are empty or null
            if (!string.IsNullOrWhiteSpace(PersonnelNametextBox.Text) && !string.IsNullOrWhiteSpace(PersonnelSurnametextBox.Text))
            {
                DB_Operations.DeletePersonnel(PersonnelNametextBox.Text, PersonnelSurnametextBox.Text);
                MessageBox.Show("Personnel Deleted.");
            }
            else
            {
                // To warn user who  makes  empty spaces.
                MessageBox.Show("Please fill the boxes that you’ve left empty.");
            }
        }
    }
}
