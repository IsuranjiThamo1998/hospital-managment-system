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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_home_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Login login = new Login();
            login.Show();
        }
    }
}
