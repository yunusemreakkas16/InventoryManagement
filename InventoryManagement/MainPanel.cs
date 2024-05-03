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
    public partial class Form1 : Form
    {
        
        public static Form1 Instance { get; private set; }              //Saved Form instance
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AssigmentPanel AssigmentPanel = new AssigmentPanel();                      // To create new form
            this.Hide();                                            // To hide current form
            AssigmentPanel.Show();                                 // Show new form
        }

        private void MaintenanceButton_Click(object sender, EventArgs e)
        {
            Form3 MaintenancePanel = new Form3();
            this.Hide();
            MaintenancePanel.Show();
        }
    }
}
