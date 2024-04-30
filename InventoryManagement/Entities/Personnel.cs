using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
