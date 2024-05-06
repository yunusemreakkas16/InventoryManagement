using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Assignment
    {
        public Personnel Personnel { get; set; }
        public Item Item { get; set; }

        public int AssignmentId { get; set; }
        public DateTime AssignmentDate { get; set; } = DateTime.Today;       //date!
        public DateTime AssignmentEndDate { get; set; } = DateTime.Today;    //date!
        public int FK_PersonnelId {  get; set; }
        public int FK_ItemId { get; set; }
    }
}
