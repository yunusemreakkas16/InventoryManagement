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
    public partial class UpdateItemForm : Form
    {
        public UpdateItemForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ItemPanelForm itemPanelForm = new ItemPanelForm();
            itemPanelForm.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(ItemIdtextBox.Text) && !String.IsNullOrWhiteSpace(ItemStatustextBox.Text))
            {
                int itemId;
                byte itemStatus;
                if(int.TryParse(ItemIdtextBox.Text, out itemId) && byte.TryParse(ItemStatustextBox.Text, out itemStatus))
                {
                    DB_Operations.UpdateItem(itemId, itemStatus);
                    MessageBox.Show("Item Status Updated");
                }
                else
                {
                    MessageBox.Show("Please fill the box with the proper value.");
                }
            }
        }
    }
}
