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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB_Opertations.ListMaintenanceList();
            dataGridView2.DataSource = DB_Opertations.ListItems();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();                  //Return to Main Interface                  
            this.Close();                           //Closes  a Form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = DB_Opertations.ListMaintenanceList();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = DB_Opertations.ListItems();
        }

    }
}
