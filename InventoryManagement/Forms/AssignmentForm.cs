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
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();

            // Executes Grid view when form opens
            dataGridView1.DataSource = DB_Operations.ListPersonnel();
            dataGridView2.DataSource = DB_Operations.ListItems();
            dataGridView3.DataSource = DB_Operations.ListAssignmentList();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            //Refresh Button for Personnels
            dataGridView1.DataSource = DB_Operations.ListPersonnel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();

            //Refresh Button for Items
            dataGridView2.DataSource = DB_Operations.ListItems();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();

            //Refresh Button for Assigment List
            dataGridView3.DataSource = DB_Operations.ListAssignmentList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPanelForm.Instance.Show();
            this.Close();
        }

        private void NewAssigmentButton_Click(object sender, EventArgs e)
        {
            AddNewAssignmentForm addMaintenanceRecordPanel = new AddNewAssignmentForm();
            addMaintenanceRecordPanel.Show();
            this.Close();
        }
    }
}
