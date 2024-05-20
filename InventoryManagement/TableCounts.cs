using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class TableCounts
    {
        public static int GetPersonnelCount()
        {
            return DB_Operations.ListPersonnel().Count;
        }
        public static int GetItemCount()
        {
            return DB_Operations.ListItem().Count;
        }
        
        public static int GetAssignmentRecordCount()
        {
            return DB_Operations.ListAssignmentList().Count;
        }

        public static int GetMaintenanceListCount()
        {
            return DB_Operations.ListMaintenanceList().Count;
        }
    }
}
