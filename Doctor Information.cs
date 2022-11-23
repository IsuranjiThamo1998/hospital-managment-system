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
    public partial class Doctor_information : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);

        public Doctor_information()
        {
            InitializeComponent();
        }

        private void btn_doctor_display_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doctor_display_clear_Click(object sender, EventArgs e)
        {
            txt_doctor_display_id.Text = "";
            txt_doctor_display_date.Text = "";
            txt_doctor_display_name.Text = "";
            cmb_doctor_display_gender.Text = "";
            txt_doctor_display_age.Text = "";
            txt_doctor_display_address.Text = "";
            txt_doctor_display_phonenumber.Text = "";
            txt_display_email.Text = "";
            txt_display_specialization.Text = "";
        }

        private void btn_doctor_display_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"SELECT*FROM DOCTOR_TB";
                SqlDataAdapter ada = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgv_doctor_display.DataSource = dt;

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
            command.CommandText = "SELECT*FROM DOCTOR_TB where Doctors_ID = '" + txt_doctor_display_id.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgv_doctor_display.DataSource = dt;
            con.Close();
        }

        private void dgv_doctor_display_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_doctor_display.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_doctor_display_id.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctors_ID"].Value.ToString();
                txt_doctor_display_date.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctors_Register_Date"].Value.ToString();
                txt_doctor_display_name.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctors_Name"].Value.ToString();
                cmb_doctor_display_gender.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctor_Gender"].Value.ToString();
                txt_doctor_display_age.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctor_Age"].Value.ToString();
                txt_doctor_display_address.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctor_Address"].Value.ToString();
                txt_doctor_display_phonenumber.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctor_Phone_Number"].Value.ToString();
                txt_display_email.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Doctor_Email"].Value.ToString();
                txt_display_specialization.Text = dgv_doctor_display.Rows[e.RowIndex].Cells["Specialization"].Value.ToString();
            }
        }
    }
}
