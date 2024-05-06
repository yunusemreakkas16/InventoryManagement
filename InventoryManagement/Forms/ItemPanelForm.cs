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
            dataGridView1.DataSource = DB_Operations.ListItems();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = DB_Operations.ListItems();
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
    }
}
