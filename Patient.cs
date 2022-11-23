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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void btn_patient_registration_Click(object sender, EventArgs e)
        {
            Patient_registration patient_reg = new Patient_registration();
            patient_reg.Show();
        }

        private void btn_patient_information_Click(object sender, EventArgs e)
        {
            Patient_information patient_display = new Patient_information();
            patient_display.Show();

        }

        private void btn_patientinfo_delete_Click(object sender, EventArgs e)
        {Patient_Info_delete patient_delete = new Patient_Info_delete();
            patient_delete.Show();
        }

        private void btn_patient_infoupdate_Click(object sender, EventArgs e)
        {
            Patient_info_update patient_update = new Patient_info_update();
            patient_update.Show();
            
            patient_update.Show();
        }

        private void btn_patient_infodetails_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
