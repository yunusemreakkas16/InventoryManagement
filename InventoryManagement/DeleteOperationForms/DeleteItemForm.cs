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

        private void button1_Click(object sender, EventArgs e)
        {
            ItemPanelForm itemPanelForm = new ItemPanelForm();
            itemPanelForm.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ItemIdtextBox.Text))
            {
                int itemId;
                if (int.TryParse(ItemIdtextBox.Text, out itemId))
                {
                    DB_Operations.DeleteItem(itemId);
                    MessageBox.Show("Item Deleted.");
                }
                else
                {
                    MessageBox.Show("Please fill the box with the proper value.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the box that you’ve left empty.");
            }
        }
    }
}
