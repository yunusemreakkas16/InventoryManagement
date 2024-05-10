using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public static class EnumTranslate
    {
        public static string GetMaintenanceStatus(byte status)
        {
            return Enum.GetName(typeof(MaintenanceStatus), status);
        }

        public static string GetItemType(byte itemType)
        {
            return Enum.GetName(typeof (ItemType), itemType);
        }

        public static string GetItemStatus(byte itemStatus)
        {
            return Enum.GetName(typeof (ItemStatus), itemStatus);
        }
    }
}
