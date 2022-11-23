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
    public partial class Reception : Form
    {
        public Reception()
        {
            InitializeComponent();
        }

       

       

      

       
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_bill_Click_1(object sender, EventArgs e)
        {
            Bill_information bill_Information = new Bill_information();
            bill_Information.Show();
        }

        private void btn_menu_patient_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.Show();
        }
    }
}
