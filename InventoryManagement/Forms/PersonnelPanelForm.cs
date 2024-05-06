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
    public partial class PersonnelPanelForm : Form
    {
        public PersonnelPanelForm()
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



        private void AddNewPersonnel_Click(object sender, EventArgs e)
        {
            AddNewPersonnelForm addNewPersonnel = new AddNewPersonnelForm();
            addNewPersonnel.Show();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainPanelForm.Instance.Show();
            this.Close();
        }
    }
}
