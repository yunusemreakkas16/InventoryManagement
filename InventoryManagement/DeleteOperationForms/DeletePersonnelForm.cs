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
            NameSurnamecomboBox.DataSource = DB_Operations.ListPersonnel().ToList();
            NameSurnamecomboBox.DisplayMember = "NameAndSurname";
            NameSurnamecomboBox.ValueMember = "PersonnelId";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PersonnelPanelForm personnelPanelForm = new PersonnelPanelForm();
            personnelPanelForm.Show();
            this.Close();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete the personnel using the selected name and surname
            DB_Operations.DeletePersonnel((int)NameSurnamecomboBox.SelectedValue);
        }

    }
}
