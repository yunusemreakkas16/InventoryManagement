using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    internal class ComboBoxData
    {

        #region Personnel Based Operations

        public static List<string> GetPersonnelNames()
        {
            return DB_Operations.ListPersonnel().Select(p => p.PersonnelName).ToList();
        }

        public static List<string> GetPersonnelSurnames()
        {
            return DB_Operations.ListPersonnel().Select(p => p.PersonnelSurname).ToList();
        }

        public static List <int> GetPersonnelId()
        {
            return DB_Operations.ListPersonnel().Select(p => p.PersonnelId).ToList();
        }



        #endregion



        #region Item Based Operations

        public static List<int> GetItemsIds()
        {
            return DB_Operations.ListItems().Select(i => i.ItemId).ToList();
        }

        public static List<string> GetUnassignedItemNames()
        {
            var dbConnection = DB_Operations.GetDbConnection();
            var items = dbConnection.Query<string>("SELECT ItemName FROM Item WHERE ItemId NOT IN (SELECT FK_ItemId FROM Assignment) AND ItemId NOT IN (SELECT FK_ItemId FROM Maintenance)");
            return items.ToList();
        }

        public static List<int> GetUnassignedItemIds()
        {
            var dbConnection = DB_Operations.GetDbConnection();
            var items = dbConnection.Query<int>("SELECT ItemId FROM Item WHERE ItemId NOT IN (SELECT FK_ItemId FROM Maintenance) AND ItemId NOT IN (SELECT FK_ItemId FROM Assignment)");
            return items.ToList();
        }

        #endregion



        #region Assignment Based Operations

        public static List<int> GetAssignmentListIds()
        {
            return DB_Operations.ListAssignmentList().Select(a => a.AssignmentId).ToList();
        }

        #endregion


        #region Maintenance Based Operations

        public static List <int> GetMaintenanceIds() 
        {
            return DB_Operations.ListMaintenanceList().Select(m => m.MaintenanceId).ToList();
        }

        #endregion

    }
}
