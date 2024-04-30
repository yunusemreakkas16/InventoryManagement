using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Assigment
    {
        public int AssigmentId { get; set; }
        public DateTime AssigmentDate { get; set; } //date!
        public DateTime AssigmentEndDate { get; set; } //date!
        public int FK_PersonnelId {  get; set; }
        public int FK_ItemId { get; set; }
    }
}
