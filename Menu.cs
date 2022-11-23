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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       
     
        private void btn_menu_doctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
           
        }

        private void btn_menu_patient_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.Show();
        }

        private void btn_menu_staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }

        private void btn_menu_room_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
        }

        private void btn_menu_bill_Click(object sender, EventArgs e)
        {
            Bill_information bill = new Bill_information();
            bill.Show();
        }

        private void btn_menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
