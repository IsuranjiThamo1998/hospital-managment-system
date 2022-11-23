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
    public partial class Doctor_info_update : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);

        public Doctor_info_update()
        {
            InitializeComponent();
        }



        private void btn_doctor_update_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doctor__update_clear_Click(object sender, EventArgs e)
        {
            txt_doctor_update_id.Text = "";
            dtp_doctor_update_date.Text = "";
            txt_doctor_update_name.Text = "";
            cmb_doctor_update_gender.Text = "";
            txt_doctor_update_age.Text = "";
            txt_doctor_update_address.Text = "";
            txt_doctor_update_phonenumber.Text = "";
            txt_update_email.Text = "";
            txt_update_specialization.Text = "";
        }

        private void btn_doctor_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"UPDATE DOCTOR_TB SET  Doctors_Register_Date ='" + dtp_doctor_update_date.Value.ToString() + "',Doctors_Name='" + txt_doctor_update_name.Text + "',Doctor_Gender='" + cmb_doctor_update_gender.Text + "',Doctor_Age='" + txt_doctor_update_age.Text + "',Doctor_Address='" + txt_doctor_update_address.Text + "',Doctor_Phone_Number='" + txt_doctor_update_phonenumber.Text + "',Doctor_Email ='" + txt_update_email.Text + "',Specialization='" + txt_update_specialization.Text + "'where Doctors_ID='" + txt_doctor_update_id.Text + "'";
                SqlCommand command = new SqlCommand(sql, con);

                command.ExecuteNonQuery();
                MessageBox.Show("Successfully updated !");
                string SQL = @"SELECT*FROM DOCTOR_TB";
                SqlDataAdapter ada = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgv_doctor_update.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT*FROM DOCTOR_TB";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_doctor_update.DataSource = dt;
        }

        private void dgv_doctor_update_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_doctor_update.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_doctor_update_id.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctors_ID"].Value.ToString();
                dtp_doctor_update_date.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctors_Register_Date"].Value.ToString();
                txt_doctor_update_name.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctors_Name"].Value.ToString();
                cmb_doctor_update_gender.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctor_Gender"].Value.ToString();
                txt_doctor_update_age.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctor_Age"].Value.ToString();
                txt_doctor_update_address.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctor_Address"].Value.ToString();
                txt_doctor_update_phonenumber.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctor_Phone_Number"].Value.ToString();
                txt_update_email.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Doctor_Email"].Value.ToString();
                txt_update_specialization.Text = dgv_doctor_update.Rows[e.RowIndex].Cells["Specialization"].Value.ToString();
            }
        }

        private void txt_doctor_update_id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_doctor_update_id.Text))
            {
                e.Cancel = true;
                txt_doctor_update_id.Focus();
                errorProvider_doc_update.SetError(txt_doctor_update_id, "Please enter doctor's ID !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_update.SetError(txt_doctor_update_id, null);
            }
        }

        private void txt_doctor_update_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_doctor_update_name.Text))
            {
                e.Cancel = true;
                txt_doctor_update_name.Focus();
                errorProvider_doc_update.SetError(txt_doctor_update_name, "Please enter doctor's name  !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_update.SetError(txt_doctor_update_name, null);
            }
        }

        private void cmb_doctor_update_gender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_doctor_update_gender.Text))
            {
                e.Cancel = true;
                cmb_doctor_update_gender.Focus();
                errorProvider_doc_update.SetError(cmb_doctor_update_gender, "Please select gender !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_update.SetError(cmb_doctor_update_gender, null);
            }
        }

        private void txt_doctor_update_address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_doctor_update_address.Text))
            {
                e.Cancel = true;
                txt_doctor_update_address.Focus();
                errorProvider_doc_update.SetError(txt_doctor_update_address, "Please enter address !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_update.SetError(txt_doctor_update_address, null);
            }
        }

        private void txt_doctor_update_phonenumber_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_doctor_update_phonenumber.Text != string.Empty) && (txt_doctor_update_phonenumber.TextLength == 10) && (txt_doctor_update_phonenumber.Text.Any(char.IsDigit)))
            {
                errorProvider_doc_update.SetError(txt_doctor_update_phonenumber, null);
            }
            else
            {
                txt_doctor_update_phonenumber.Focus();
                errorProvider_doc_update.SetError(txt_doctor_update_phonenumber, "Please enter valid phone number !");
            }
        }

        private void txt_update_email_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_update_email.Text != string.Empty) && (txt_update_email.Text.Contains("@") && (txt_update_email.Text.Contains("."))))
            {
                errorProvider_doc_update.SetError(txt_update_email, null);
            }
            else
            {
                txt_update_email.Focus();
                errorProvider_doc_update.SetError(txt_update_email, "Please enter valid email address !");
            }
        }

        private void txt_update_specialization_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_update_specialization.Text))
            {
                e.Cancel = true;
                txt_update_specialization.Focus();
                errorProvider_doc_update.SetError(txt_update_specialization, "Please enter specialization !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_update.SetError(txt_update_specialization, null);
            }
        }

       

        private void dtp_doctor_update_date_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtp_doctor_update_date.Text))
            {
                e.Cancel = true;
                dtp_doctor_update_date.Focus();
                errorProvider_doc_update.SetError(dtp_doctor_update_date, "Please select date !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_update.SetError(dtp_doctor_update_date, null);
            }
        }

        private void txt_doctor_update_age_Validating(object sender, CancelEventArgs e)
        {
            if (txt_doctor_update_age.Text.Any(char.IsDigit))


            {
                errorProvider_doc_update.SetError(txt_doctor_update_age, null);
            }
            else
            {
                txt_doctor_update_age.Focus();
                errorProvider_doc_update.SetError(txt_doctor_update_age, "Please enter only digits !");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT*FROM DOCTOR_TB where Doctors_ID = '" + txt_doctor_update_id.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgv_doctor_update.DataSource = dt;
            con.Close();
        }
    }
}

