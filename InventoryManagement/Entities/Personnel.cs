using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    internal class Personnel 
    {
        public int PersonnelId { get; set; }
        public string PersonnelName { get; set; } //limit 50 characters!
        public string PersonnelSurname { get; set;} //limit 50 characters!
        public string PersonnelDepartment { get; set;} //limit 50 characters!       
    }
}
