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
    internal class DB_Operations
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
        public static List<Assignment>ListAssignmentList()

        {
            var assigmentlist = dbConnection.Query<Assignment>("SELECT * FROM Assignment");
            return assigmentlist.ToList();
        }


        public static void AddPersonnel(string Name, string Surname, string Department)
        {
            var newPersonnel = new Personnel { PersonnelName = Name, PersonnelSurname = Surname, PersonnelDepartment = Department };
            dbConnection.Execute("INSERT INTO Personnel (PersonnelName, PersonnelSurname, PersonnelDepartment) VALUES (@PersonnelName, @PersonnelSurname, @PersonnelDepartment)",newPersonnel);
        }

        public static void AddItem(string Name, byte Type, byte Status)
        {
            var newItem = new Item { ItemName = Name, ItemType = Type, ItemStatus = Status };
            dbConnection.Execute("INSERT INTO Item (ItemName, ItemType, ItemStatus) VALUES (@ItemName, @ItemType, @ItemStatus)",newItem);
        }

        public static void AddAssignment(string personnelName, string personnelSurname, string itemName, DateTime assignmentDate, DateTime assignmentEndDate)
        {
            var personnelId = dbConnection.Query<int>("SELECT PersonnelId FROM Personnel WHERE PersonnelName = @PersonnelName AND PersonnelSurname = @PersonnelSurname", new { personnelName, personnelSurname }).Single();
            var itemId = dbConnection.Query<int>("SELECT ItemId FROM Item WHERE ItemName = @ItemName", new { itemName }).Single();

            var newAssignment = new Assignment {AssignmentDate = assignmentDate, AssignmentEndDate = assignmentEndDate, FK_PersonnelId = personnelId, FK_ItemId = itemId};
            dbConnection.Execute("INSERT INTO Assignment (AssignmentDate, AssignmentEndDate, FK_PersonnelId, FK_ItemId) VALUES (@AssignmentDate, @AssignmentEndDate, @FK_PersonnelId, @FK_ItemId)",newAssignment);
        }

        public static void AddMaintenance(int itemId, byte status, DateTime maintenanceDate, DateTime maintenanceEndDate)
        {
            var newMaintenance = new Maintenance { FK_ItemId = itemId, MaintenanceStatus = status, MaintenanceDate = maintenanceDate, MaintenanceEndDate = maintenanceEndDate };
            dbConnection.Execute("INSERT INTO Maintenance (FK_ItemId, MaintenanceStatus, MaintenanceDate, MaintenanceEndDate) VALUES (@FK_ItemId, @MaintenanceStatus, @MaintenanceDate, @MaintenanceEndDate)", newMaintenance);
        }


    }
}
