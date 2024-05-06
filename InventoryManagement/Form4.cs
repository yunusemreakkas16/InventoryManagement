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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            dataGridView1.DataSource = DB_Operations.ListPersonnel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = DB_Operations.ListPersonnel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
