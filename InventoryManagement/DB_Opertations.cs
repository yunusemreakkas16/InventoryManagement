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
        public void AddingData()
        {
            using (IDbConnection connection = new SqlConnection("Data Source=NEUTRONSTAR\\SQLEXPRESS;Initial Catalog=INVENTORY;Integrated Security=True;Encrypt=False"))
            {

                var newPersonnel = new Personnel { PersonnelName = "Kudret", PersonnelSurname = "Aslan", PersonnelDepartment = "HR" };
                connection.Execute("INSERT INTO Personnel (PersonnelName,PersonnelSurname,PersonnelDepartment) VALUES (@PersonnelName,@PersonnelSurname,@PersonnelDepartment)", newPersonnel);

            }
        }
    }
}
