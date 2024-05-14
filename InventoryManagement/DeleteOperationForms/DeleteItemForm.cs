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
            var itemIds = ComboBoxData.GetItemsIds();
            ItemIdcomboBox.DataSource = itemIds;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedItemId = Convert.ToInt32(ItemIdcomboBox.SelectedItem);
            DB_Operations.DeleteItem(selectedItemId);
        }
    }
}
