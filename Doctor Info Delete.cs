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
    public partial class Doctor_info_delete : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);

        public Doctor_info_delete()
        {
            InitializeComponent();
        }

        private void btn_doctor_delete_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doctor_delete_clear_Click(object sender, EventArgs e)
        {
            txt_doctor_delete_id.Text = "";
            dtp_doctor_delete_date.Text = "";
            txt_doctor_delete_name.Text = "";
            cmb_doctor_delete_gender.Text = "";
            txt_doctor_delete_age.Text = "";
            txt_doctor_delete_address.Text = "";
            txt_doctor_delete_phonenumber.Text = "";
            txt_delete_email.Text = "";
            txt_delete_specialization.Text = "";
        }

        private void btn_doctor_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"delete from DOCTOR_TB where Doctors_ID='" + txt_doctor_delete_id.Text + "'";
                SqlCommand cmbdatabase = new SqlCommand(sql, con);
                cmbdatabase.ExecuteNonQuery();
                MessageBox.Show("Sucessfully deleted !");
                string SQL = "SELECT*FROM DOCTOR_TB";
                SqlDataAdapter ada = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgv_doctor_delete.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT*FROM DOCTOR_TB";
            SqlDataAdapter ada = new SqlDataAdapter(SQL, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dgv_doctor_delete.DataSource = dt;
        }

        private void dgv_doctor_delete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_doctor_delete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_doctor_delete_id.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctors_ID"].Value.ToString();
                dtp_doctor_delete_date.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctors_Register_Date"].Value.ToString();
                txt_doctor_delete_name.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctors_Name"].Value.ToString();
                cmb_doctor_delete_gender.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctor_Gender"].Value.ToString();
                txt_doctor_delete_age.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctor_Age"].Value.ToString();
                txt_doctor_delete_address.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctor_Address"].Value.ToString();
                txt_doctor_delete_phonenumber.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctor_Phone_Number"].Value.ToString();
                txt_delete_email.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Doctor_Email"].Value.ToString();
                txt_delete_specialization.Text = dgv_doctor_delete.Rows[e.RowIndex].Cells["Specialization"].Value.ToString();

            }
        }

        

        private void txt_doctor_delete_id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_doctor_delete_id.Text))
            {
                e.Cancel = true;
                txt_doctor_delete_id.Focus();
                errorProvider_doc_delete.SetError(txt_doctor_delete_id, "Please enter doctor's ID !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_delete.SetError(txt_doctor_delete_id, null);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT*FROM DOCTOR_TB where Doctors_ID = '" + txt_doctor_delete_id.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgv_doctor_delete.DataSource = dt;
            con.Close();
        }
    }
}
