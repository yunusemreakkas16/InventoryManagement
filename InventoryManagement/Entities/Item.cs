using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } // limit 50 characters!
        public Byte ItemType { get; set; }  // tiny int!
        public Byte ItemStatus { get; set;} //tiny int!
    }
}
