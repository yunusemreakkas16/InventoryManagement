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
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB_Operations.ListMaintenanceList();    // Shows data when Maintenance Panel is opened
            dataGridView2.DataSource = DB_Operations.ListItems();              // Shows data when Maintenance Panel is opened
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPanelForm.Instance.Show();                  //Return to Main Interface                  
            this.Close();                           //Closes  a Form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;                                    // Sets the Gridview's data source to null to avoid binding conflict
            dataGridView1.Rows.Clear();                                         // Clears the Gridview's Rows
            dataGridView1.DataSource = DB_Operations.ListMaintenanceList();    // Sets the Gridview's data source to a list of object retrieved from the database
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = DB_Operations.ListItems();
        }

    }
}
