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
using System.Windows.Forms;

namespace InventoryManagement
{
    internal class DB_Operations
    {
        static IDbConnection dbConnection = new SqlConnection("Data Source=NEUTRONSTAR\\SQLEXPRESS;Initial Catalog=INVENTORY;Integrated Security=True;Encrypt=False");

        //                                                                                      ***** List Operations*****

        public static List<Personnel> ListPersonnel()
        {
            var personnels = dbConnection.Query<Personnel>("SELECT* FROM Personnel");
            return personnels.ToList();
        }
        public static List<Item> ListItems()
        {
            var items = dbConnection.Query<Item>("SELECT * FROM Item");
            return items.ToList();
        }

        public static List<Maintenance> ListMaintenanceList()
        {
            var maintenancelist = dbConnection.Query<Maintenance>("SELECT * FROM Maintenance");
            return maintenancelist.ToList();
        }
        public static List<Assignment> ListAssignmentList()

        {
            var assigmentlist = dbConnection.Query<Assignment>("SELECT * FROM Assignment");
            return assigmentlist.ToList();
        }

        //                                                                                      ***** Add Operations *****

        public static void AddPersonnel(string Name, string Surname, string Department)
        {
            var newPersonnel = new Personnel { PersonnelName = Name, PersonnelSurname = Surname, PersonnelDepartment = Department };
            dbConnection.Execute("INSERT INTO Personnel (PersonnelName, PersonnelSurname, PersonnelDepartment) VALUES (@PersonnelName, @PersonnelSurname, @PersonnelDepartment)", newPersonnel);
        }

        public static void AddItem(string Name, byte Type, byte Status)
        {
            var newItem = new Item { ItemName = Name, ItemType = Type, ItemStatus = Status };
            dbConnection.Execute("INSERT INTO Item (ItemName, ItemType, ItemStatus) VALUES (@ItemName, @ItemType, @ItemStatus)", newItem);
        }

        public static void AddAssignment(string personnelName, string personnelSurname, string itemName, DateTime assignmentDate, DateTime assignmentEndDate)
        {
            var personnelId = dbConnection.Query<int>("SELECT PersonnelId FROM Personnel WHERE PersonnelName = @PersonnelName AND PersonnelSurname = @PersonnelSurname", new { personnelName, personnelSurname }).Single();

            // To find item which  is assignable


            var itemId = dbConnection.Query<int>("SELECT ItemId FROM Item WHERE ItemName = @ItemName AND ItemId NOT IN (SELECT FK_ItemId FROM Assignment)", new { itemName }).FirstOrDefault();

            if (itemId != 0)
            {
                var newAssignment = new Assignment { AssignmentDate = assignmentDate, AssignmentEndDate = assignmentEndDate, FK_PersonnelId = personnelId, FK_ItemId = itemId };
                dbConnection.Execute("INSERT INTO Assignment (AssignmentDate, AssignmentEndDate, FK_PersonnelId, FK_ItemId) VALUES (@AssignmentDate, @AssignmentEndDate, @FK_PersonnelId, @FK_ItemId)", newAssignment);
                MessageBox.Show("New Assignment Added");
            }
            else
            {
                MessageBox.Show("No assignable item found");
            }
        }

        public static void AddMaintenance(int itemId, byte status, DateTime maintenanceDate, DateTime maintenanceEndDate)
        {
            //To control of existing a item in Maintenance Panel

            var existingMaintenance = dbConnection.Query<int>("SELECT FK_ItemId FROM Maintenance WHERE FK_ItemId = @FK_ItemId", new { FK_ItemId = itemId }).SingleOrDefault();

            if (existingMaintenance == 0)
            {
                var newMaintenance = new Maintenance { FK_ItemId = itemId, MaintenanceStatus = status, MaintenanceDate = maintenanceDate, MaintenanceEndDate = maintenanceEndDate };
                dbConnection.Execute("INSERT INTO Maintenance (FK_ItemId, MaintenanceStatus, MaintenanceDate, MaintenanceEndDate) VALUES (@FK_ItemId, @MaintenanceStatus, @MaintenanceDate, @MaintenanceEndDate)", newMaintenance);
                MessageBox.Show("New Maintenance record  added");
            }
            else
            {
                MessageBox.Show("This item already has a maintenance record");
            }
        }


        //                                                                                      ***** Delete Operations *****

        public static void DeletePersonnel(string name, string surname)
        {
            dbConnection.Execute("DELETE FROM Personnel WHERE PersonnelName = @PersonnelName AND PersonnelSurname = @PersonnelSurname", new { PersonnelName = name, PersonnelSurname = surname });
        }

        public static void DeleteItem(int itemId)
        {
            dbConnection.Execute("DELETE FROM Item WHERE ItemId = @ItemId", new { ItemId = itemId });
        }

        public static void DeleteAssignment(int assignmentId)
        {
            dbConnection.Execute("DELETE FROM Assignment WHERE AssignmentId = @AssignmentId", new { AssignmentId = assignmentId });
        }

        public static void DeleteMaintenance(int maintenanceId)
        {
            dbConnection.Execute("DELETE FROM Maintenance WHERE MaintenanceId = @MaintenanceId", new { MaintenanceId = maintenanceId });
        }

        //                                                                                      ***** Update Operations *****

        public static void UpdatePersonnel(int personnelId, string name, string surname, string department)
        {
            // To avoid Update failures.

            if (personnelId == 0 || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(surname) && string.IsNullOrEmpty(department)))
            {
                MessageBox.Show("At least one field must be filled and the ID cannot be 0.");
                return;
            }
            else
            {
                var query = "UPDATE Personnel SET ";
                var parameters = new DynamicParameters();

                if (!string.IsNullOrEmpty(name)) { query += "PersonnelName = @PersonnelName, "; parameters.Add("@PersonnelName", name); }

                if (!string.IsNullOrEmpty(surname)) { query += "PersonnelSurname = @PersonnelSurname, "; parameters.Add("@PersonnelSurname", surname); }

                if (!string.IsNullOrEmpty(department)) { query += "PersonnelDepartment = @PersonnelDepartment, "; parameters.Add("@PersonnelDepartment", department); }



                query = query.TrimEnd(',', ' ');                                                // Removes last comma

                query += " WHERE PersonnelId = @PersonnelId";
                parameters.Add("@PersonnelId", personnelId);
                dbConnection.Execute(query, parameters);
                MessageBox.Show("The update process has been completed.");
            }
        }

        public static void UpdateItem(int itemId, byte? itemStatus = null)
        {
            if (itemId == 0)
            {
                MessageBox.Show("the ID cannot be 0");
                return;
            }

            dbConnection.Execute("UPDATE Item SET ItemStatus = @ItemStatus WHERE ItemId = @ItemId", new { itemStatus, itemId });
            MessageBox.Show("Item Status Updated");
        }

        public static void UpdateAssignment(int assignmentId, DateTime? endDate)
        {
            if (assignmentId == 0 || !endDate.HasValue)
            {
                MessageBox.Show("At least one field must be filled and the ID cannot be 0");
                return;
            }

            dbConnection.Execute("UPDATE Assignment SET AssignmentEndDate = @endDate WHERE AssignmentId = @assignmentId", new { endDate, assignmentId });
            MessageBox.Show("Assignment record updated");
        }

        public static void UpdateMaintenance(int maintenanceId, byte? maintenanceStatus, DateTime? maintenanceEndDate)
        {
            if ((!maintenanceStatus.HasValue) && (!maintenanceEndDate.HasValue) || maintenanceId == 0)
            {
                MessageBox.Show("At least one field must be filled and the ID cannot be 0");
                return;
            }

            var query = "UPDATE Maintenance SET ";
            var parameters = new DynamicParameters();

            if (maintenanceStatus.HasValue) { query += "MaintenanceStatus = @MaintenanceStatus, "; parameters.Add("@MaintenanceStatus", maintenanceStatus); }

            if (maintenanceEndDate.HasValue) { query += "MaintenanceEndDate = @MaintenanceEndDate, "; parameters.Add("@MaintenanceEndDate", maintenanceEndDate); }

            query = query.TrimEnd(',', ' ');
            query += " WHERE MaintenanceId = @MaintenanceId";
            parameters.Add("@MaintenanceId", maintenanceId);
            dbConnection.Execute(query, parameters);
            MessageBox.Show("Maintenance record updated");
        }

    }
}
