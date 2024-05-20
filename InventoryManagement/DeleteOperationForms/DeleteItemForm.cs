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
    public partial class DeleteItemForm : Form
    {
        public DeleteItemForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ItemPanelForm itemPanelForm = new ItemPanelForm();
            itemPanelForm.Show();
            this.Close();
        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            ItemIdcomboBox.DataSource = DB_Operations.ListItem().ToList();
            ItemIdcomboBox.DisplayMember = "ItemIdItemName";
            ItemIdcomboBox.ValueMember = "ItemId";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB_Operations.DeleteItem((int)ItemIdcomboBox.SelectedValue);
        }
    }
}
