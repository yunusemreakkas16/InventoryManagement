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
    public partial class ItemPanelForm : Form
    {
        public ItemPanelForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            // sets GridView manually to make columns

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemId",
                DataPropertyName = "ItemId",
                HeaderText = "Item ID",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {   Name = "ItemName",
                DataPropertyName = "ItemName",
                HeaderText = "Item Name"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn 
            {   Name = "ItemType",
                DataPropertyName = "Type",
                HeaderText = "Item Type"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemStatus",
                DataPropertyName = "Status",
                HeaderText ="Item Status"
            });

            dataGridView1.DataSource = DB_Operations.ListItems();
            
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanelForm.Instance.Show();
            this.Close();
        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItemForm addNewItemForm = new AddNewItemForm();
            addNewItemForm.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteItemForm deleteItemForm = new DeleteItemForm();
            deleteItemForm.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateItemForm updateItemForm = new UpdateItemForm();
            updateItemForm.Show();
            this.Close();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            var sortableColumn = "ItemType";
            SortingFunctions.SortDataGridView(dataGridView1, columnName, SortingFunctions.ItemTypeSort, DB_Operations.ListItems, sortableColumn);
        }
    }
}
