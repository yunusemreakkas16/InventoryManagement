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

            dataGridView1.AutoGenerateColumns = false;

            // sets GridView manually to make columns

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonnelId",
                DataPropertyName = "PersonnelId",
                HeaderText = "Personnel ID",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonnelName",
                DataPropertyName = "PersonnelName",
                HeaderText = "Personnel Name"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PersonnelSurname",
                DataPropertyName = "PersonnelSurname",
                HeaderText = "Personnel Surname"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Department",
                DataPropertyName = "PersonnelDepartment",
                HeaderText = "Department"
            });

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

        private void DeletePersonnel_Click(object sender, EventArgs e)
        {
            DeletePersonnelForm deletePersonnel = new DeletePersonnelForm();
            deletePersonnel.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePersonnelForm updatePersonnelForm = new UpdatePersonnelForm();
            updatePersonnelForm.Show();
            this.Close();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            var sortableColumn = "Department";
            SortingFunctions.SortDataGridView(dataGridView1, columnName, SortingFunctions.PersonnelDepartmentSort, DB_Operations.ListPersonnel, sortableColumn);
        }

        private void PersonnelPanelForm_Load(object sender, EventArgs e)
        {
            PersonnelCountlabel.Text = "Personnel Count : " + TableCounts.GetPersonnelCount();
        }
    }
}
