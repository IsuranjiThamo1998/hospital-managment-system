using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI__group_final_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = cmb_user.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            if (user == "Admin" && username == "admin" && password == "pass")
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else if (user == "Reception" && username == "recep" && password == "pass")
            {
                this.Hide();
                Reception reception = new Reception();
                reception.Show();
            }
            else
            {
                MessageBox.Show("Wrong User name 'OR' Password");
            }
        }
    }
}
