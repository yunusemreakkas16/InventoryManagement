﻿using System;
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
    public partial class AddNewItemForm : Form
    {
        public AddNewItemForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ItemPanelForm itemPanelForm = new ItemPanelForm();
            itemPanelForm.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Check textboxes are empty or null
            if (!string.IsNullOrWhiteSpace(ItemNametextBox.Text) && !string.IsNullOrWhiteSpace(ItemTypetextBox.Text) && !string.IsNullOrWhiteSpace(ItemStatustextBox.Text))
            {
                byte itemType;
                byte itemStatus;
                if (byte.TryParse(ItemTypetextBox.Text, out itemType) && byte.TryParse(ItemStatustextBox.Text, out itemStatus))
                {
                    DB_Operations.AddItem(ItemNametextBox.Text, itemType, itemStatus);
                    MessageBox.Show("New Item Added.");
                }
                else
                {
                    MessageBox.Show("Item Type and Item Status must be byte values.");
                }

            }
            else
            {
                // To warn user who  makes  empty spaces.
                MessageBox.Show("Please fill the boxes that you’ve left empty.");
            }
        }
    }
}
