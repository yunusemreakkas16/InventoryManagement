using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Maintenance
    {
        public int MaintenanceId { get; set; }
        public byte MaintenanceStatus { get; set; } //tiny int!
        public DateTime MaintenanceDate { get; set; } //date!
        public DateTime MaintenanceEndDate { get; set; } //date!
        public int FK_ItemId { get; set; }
    }
}
