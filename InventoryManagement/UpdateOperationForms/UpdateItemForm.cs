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

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            var itemIds = DB_Operations.ListItems().Select(i => i.ItemId).ToList();
            ItemIdcomboBox.DataSource = itemIds;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(ItemStatustextBox.Text))
            {
                var selectedItemId = Convert.ToInt32(ItemIdcomboBox.SelectedItem);

                byte itemStatus;
                if(byte.TryParse(ItemStatustextBox.Text, out itemStatus))
                {
                    DB_Operations.UpdateItem(selectedItemId, itemStatus);
                }
                else
                {
                    MessageBox.Show("Please fill the box with the proper value");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Value to process");
            }
        }
    }
}
