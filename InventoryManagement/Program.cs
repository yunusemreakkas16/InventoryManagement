using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            DB_Opertations dboperation =  new DB_Opertations();
            dboperation.AddingData();


            /*using(IDbConnection connection = new SqlConnection("Data Source=NEUTRONSTAR\\SQLEXPRESS;Initial Catalog=INVENTORY;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                //Add Data
                connection.Execute(
                    "insert into Personnel(PersonnelName,PersonnelSurname,PersonnelDepartment) values(@PersonnelName,@PersonnelSurname,@PersonnelDepartment)",
                    new Personnel { PersonnelName = "Emerald", PersonnelSurname = "Houston", PersonnelDepartment ="RD" }
                    );
                //Get Data
                List<Personnel> personnelsList = connection.Query<Personnel>("select * from Personnel").ToList();
                connection.Close();
            }*/
        }
    }
}
