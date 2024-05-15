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
    public partial class AddNewAssignmentForm : Form
    {
        public AddNewAssignmentForm()
        {
            InitializeComponent();

            // Set the Format property to Custom
            this.AssignmentdateTimePicker.Format = DateTimePickerFormat.Custom;

            // Set the CustomFormat property to an empty string
            this.AssignmentdateTimePicker.CustomFormat = " ";

            // Set the Format property to Custom
            this.AssignmentEnddateTimePicker.Format = DateTimePickerFormat.Custom;

            // Set the CustomFormat property to an empty string
            this.AssignmentEnddateTimePicker.CustomFormat = " ";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm();
            assignmentForm.Show();
            this.Close();
        }

        private void AddNewAssignmentForm_Load(object sender, EventArgs e)
        {
            PersonnelNamecomboBox.DataSource = ComboBoxData.GetPersonnelNames();
            PersonnelSurnamecomboBox.DataSource = ComboBoxData.GetPersonnelSurnames();
            ItemNamecomboBox.DataSource = ComboBoxData.GetUnassignedItemNames();
        }

        private void AssignmentdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.AssignmentdateTimePicker.CustomFormat = null;
        }

        private void AssignmentEnddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.AssignmentEnddateTimePicker.CustomFormat = null;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string selectedName = PersonnelNamecomboBox.SelectedItem.ToString();
            string selectedSurname = PersonnelSurnamecomboBox.SelectedItem.ToString();
            string selectedItem = ItemNamecomboBox.SelectedItem.ToString();

            DateTime assignmentDate, assignmentEndDate;

            assignmentDate = AssignmentdateTimePicker.Value.Date;
            assignmentEndDate = AssignmentEnddateTimePicker.Value.Date;

            DB_Operations.AddAssignment(selectedName, selectedSurname, selectedItem, assignmentDate, assignmentEndDate);
        }
    }
}
