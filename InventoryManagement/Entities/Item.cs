using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public enum ItemType
    {
        Electronics = 0,
        Furniture = 1,
        Vehicles = 2,
        OutDoorSport = 3
    }

    public enum ItemStatus
    {
        BrandNew = 0,
        GoodCondition = 1,
        MediumWear = 2,
        NeedMaintenance = 3,
        HeavyWear = 4,
        Retired = 5
    }

    internal class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } // limit 50 characters!
        public Byte ItemType { get; set; }  // tiny int!
        public Byte ItemStatus { get; set; } //tiny int!

        public string Type
        {
            get { return EnumTranslate.GetItemType(this.ItemType); }
        }

        public string Status
        {
            get { return EnumTranslate.GetItemStatus(this.ItemStatus); }
        }
    }
}
