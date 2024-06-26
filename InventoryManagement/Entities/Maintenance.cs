﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{

    public enum MaintenanceStatus
    {
        Idling = 0,
        Maintaining = 1,
        UnderRepair = 2,
        MaintenanceDone = 3,
    }

    internal class Maintenance
    {
        public int MaintenanceId { get; set; }
        public byte MaintenanceStatus { get; set; }                         //tiny int!
        public DateTime MaintenanceDate { get; set; } = DateTime.Today;     //date!
        public DateTime MaintenanceEndDate { get; set; } = DateTime.Today;  //date!
        public int FK_ItemId { get; set; }

        public string Status
        {
            get{ return EnumTranslate.GetMaintenanceStatus(this.MaintenanceStatus); }
        }
    }
}
