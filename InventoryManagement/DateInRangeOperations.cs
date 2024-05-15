using Dapper;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class DateInRangeOperations
    {
        public static bool IsDateInRange(DateTime date, DateTime endDate)
        {
            return endDate > date;
        }

        public static bool IsMaintenanceDateInRange(int maintenanceId, DateTime? endDate)
        {
            var dbConnection = DB_Operations.GetDbConnection();
            var date = dbConnection.Query<DateTime>("SELECT MaintenanceDate FROM Maintenance WHERE MaintenanceId = @maintenanceId", new {maintenanceId}).SingleOrDefault();
            if(endDate == null)
            {
                throw new Exception("End Date Null, That can't be");
            }

            return endDate > date;
        }

        public static bool IsAssignmentDateInRange(int assignmentId, DateTime endDate)
        {
            var dbConnection = DB_Operations.GetDbConnection();
            var date = dbConnection.Query<DateTime>("SELECT AssignmentDate FROM Assignment WHERE AssignmentId = @assignmentId", new {assignmentId}).SingleOrDefault();
            return endDate > date;
        }
    }
}
