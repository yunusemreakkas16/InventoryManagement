using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryManagement.Authentication;

namespace InventoryManagement
{
    public partial class GetAuthenticateForm : Form
    {
        public GetAuthenticateForm()
        {
            InitializeComponent();
        }

        private void GetRolebutton_Click(object sender, EventArgs e)
        {
            // Check textboxes are empty or null
            if (!string.IsNullOrWhiteSpace(UserNametextBox.Text) && !string.IsNullOrWhiteSpace(PasswordtextBox.Text))
            {
                var UserName = UserNametextBox.Text;
                var Password = PasswordtextBox.Text;
                Authentication.AuthenticateUser(UserName, Password);
            }
            else
            {
                // To warn user who  makes  empty spaces.
                MessageBox.Show("Please fill the boxes that you’ve left empty.");
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            MainPanelForm.Instance.Show();
            this.Close();
        }
    }
}
