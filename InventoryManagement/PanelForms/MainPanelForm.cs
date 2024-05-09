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
    public partial class MainPanelForm : Form
    {
        
        public static MainPanelForm Instance { get; private set; }              //Saved Form instance
        public MainPanelForm()
        {
            InitializeComponent();
            Instance = this;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AssignmentForm AssignmentPanel = new AssignmentForm();                      // To create new form
            this.Hide();                                            // To hide current form
            AssignmentPanel.Show();                                 // Show new form
        }

        private void MaintenanceButton_Click(object sender, EventArgs e)
        {
            MaintenanceForm MaintenancePanel = new MaintenanceForm();
            this.Hide();
            MaintenancePanel.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PersonnelPanelForm PersonnelPanel = new PersonnelPanelForm();
            this.Hide();
            PersonnelPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemPanelForm ItemPanel = new ItemPanelForm();
            this.Hide();
            ItemPanel.Show();
        }
    }
}
