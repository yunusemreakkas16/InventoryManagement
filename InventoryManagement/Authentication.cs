using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    internal class Authentication
    {
        public enum UserRole
        {
            Admin,
            Moderator,
            User
        }

        public static UserRole CurrentUserRole { get; set; } = UserRole.User;

        public static void AuthenticateUser(string username, string password)
        {
            if (username == "admin" && password == "admin") 
            { 
                MessageBox.Show("Admin Role Granted"); 
                CurrentUserRole = UserRole.Admin; 
            }
            else if (username == "moderator" && password == "moderator") 
            { 
                MessageBox.Show("Moderator Role Granted"); 
                CurrentUserRole = UserRole.Moderator; 
            }
            else 
            { 
                MessageBox.Show("There is not any role you typed"); 
                CurrentUserRole = UserRole.User; 
            }
        }
    }
}

