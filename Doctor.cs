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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void btn_doctor_infoupdate_Click(object sender, EventArgs e)
        {
            Doctor_info_update doc_update = new Doctor_info_update();
            doc_update.Show();
        }

        private void btn_doctordetails_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doctor_registration_Click(object sender, EventArgs e)
        {
            Doctor_registration doc_register = new Doctor_registration();
            doc_register.Show();
        }

        private void btn_doctor_delete_Click(object sender, EventArgs e)
        {
            
            Doctor_info_delete doc_delete = new Doctor_info_delete();
            doc_delete.Show();
        }

        private void btn_doctor_display_Click(object sender, EventArgs e)
        {
            
            Doctor_information doc_display = new Doctor_information();
            doc_display.Show();
            
        }
    }
}
