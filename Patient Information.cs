using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI__group_final_project
{
    public partial class Patient_information : Form
    {
        public static string connectionstring = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);

        public Patient_information()
        {
            InitializeComponent();
        }

        private void btn_patient_display_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_patient_display_clear_Click(object sender, EventArgs e)
        {
            txt_patient_display_id.Text = "";
            dtp_patient_info.Text = "";
            txt_patient_display_name.Text = "";
            cmb_patient_display_gender.Text = "";
            txt_patient_display_age.Text = "";
            txt_patient_display_address.Text = "";
            txt_patient_display_phonenumber.Text = "";
            cmb_patient_display_bloodgroup.Text = "";
            txt_patient_display_roomno.Text = "";
            txt_patient_display_disease.Text = "";
            txt_patient_display_ststusofdisease.Text = "";

        }

        private void btn_patient_display_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "select *from PATIENT_TB";
                SqlDataAdapter ada = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgv_patient_display.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from PATIENT_TB where Patient_ID='" + txt_patient_display_id.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv_patient_display.DataSource = dt;
            con.Close();
        }

        private void dgv_patient_display_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_patient_display.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_patient_display_id.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Patient_ID"].Value.ToString();
                dtp_patient_info.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Admit_Date"].Value.ToString();
                txt_patient_display_name.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Patients_Name"].Value.ToString();
                cmb_patient_display_gender.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Patients_Gender"].Value.ToString();
                txt_patient_display_age.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Patients_Age"].Value.ToString();
                txt_patient_display_address.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Patients_Address"].Value.ToString();
                txt_patient_display_phonenumber.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Patients_Phone_Number"].Value.ToString();
                cmb_patient_display_bloodgroup.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Blood_Group"].Value.ToString();
                txt_patient_display_roomno.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Patients_Room_No"].Value.ToString();
                txt_patient_display_disease.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Disease"].Value.ToString();
                txt_patient_display_ststusofdisease.Text = dgv_patient_display.Rows[e.RowIndex].Cells["Status_Of_Diseases"].Value.ToString();
            }
        }
    }

    
    
}
