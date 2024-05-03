using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Configuration;

namespace InventoryManagement
{
    internal class DB_Opertations
    {
        static IDbConnection dbConnection = new SqlConnection("Data Source=NEUTRONSTAR\\SQLEXPRESS;Initial Catalog=INVENTORY;Integrated Security=True;Encrypt=False");

        public static List<Personnel>ListPersonnel()
        {
            var personnels = dbConnection.Query<Personnel>("SELECT* FROM Personnel");
            return personnels.ToList();
        }
        public static List<Item>ListItems()
        {
            var items = dbConnection.Query<Item>("SELECT * FROM Item");
            return items.ToList();
            
        }
        
        public static List<Maintenance>ListMaintenanceList()
        {
            var maintenancelist = dbConnection.Query<Maintenance>("SELECT * FROM Maintenance");
            return maintenancelist.ToList();
        }
        public static List<Assigment>ListAssigmentList()

        {
            var assigmentlist = dbConnection.Query<Assigment>("SELECT * FROM Assigment");
            return assigmentlist.ToList();
        }
    }
}
