using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    internal class SortingFunctions
    {
        public static List<Personnel> PersonnelDepartmentSort()
        {
            List<Personnel> personnel = DB_Operations.ListPersonnel();
            personnel.Sort((a, b) => a.PersonnelDepartment.CompareTo(b.PersonnelDepartment));
            return personnel;
        }

        public static List<Assignment> AssignmentPersonnelIdSort()
        {
            List<Assignment> assignments = DB_Operations.ListAssignmentList();
            assignments.Sort((a, b) => a.FK_PersonnelId.CompareTo(b.FK_PersonnelId));
            return assignments;
        }

        public static List<Item> ItemTypeSort()
        {
            List<Item> items = DB_Operations.ListItems();
            items.Sort((a, b) => a.ItemType.CompareTo(b.ItemType));
            return items;
        }

        public static void SortDataGridView(DataGridView dataGridView, string columnName, Func<IEnumerable> sortFunction, Func<IEnumerable> defaultFunction, string sortableColumn)
        {
            if (sortableColumn == columnName)
            {
                if (dataGridView.Columns[columnName].HeaderCell.SortGlyphDirection != SortOrder.Ascending)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    dataGridView.DataSource = sortFunction();
                    dataGridView.Columns[columnName].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                }
                else
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    dataGridView.DataSource = defaultFunction();
                    dataGridView.Columns[columnName].HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
        }

    }
}
