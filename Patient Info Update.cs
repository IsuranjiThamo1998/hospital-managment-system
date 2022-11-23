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
    public partial class Patient_info_update : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);

        public Patient_info_update()
        {
            InitializeComponent();
        }

        private void btn_patient_update_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_patient_update_clear_Click(object sender, EventArgs e)
        {
            txt_patient_update_id.Text = "";
            dtp_patient_update.Text = "";
            txt_patient_update_name.Text = "";
            cmb_patient__update_gender.Text = "";
            txt_patient_update_age.Text = "";
            txt_patient__update_address.Text = "";
            txt_patient_update_phonenumber.Text = "";
            cmb_patient_update_bloodgroup.Text = "";
            txt_patient_update_roomno.Text = "";
            txt_patient_update_disease.Text = "";
            txt_patient_update_ststusofdisease.Text = "";


        }

        private void btn_patient_update_Click(object sender, EventArgs e)
        {




            try
            {

                con.Open();
                string sql = @"update PATIENT_TB set Admit_Date='" + dtp_patient_update.Value.ToString() + "',Patients_Name='" + txt_patient_update_name.Text + "',Patients_Gender='" + cmb_patient__update_gender.Text + "',Patients_Age='" + txt_patient_update_age.Text + "',Patients_Address='" + txt_patient__update_address.Text + "',Patients_Phone_Number='" + txt_patient_update_phonenumber.Text + "',Blood_Group ='" + cmb_patient_update_bloodgroup.Text + "',Patients_Room_No='" + txt_patient_update_roomno.Text + "',Disease ='" + txt_patient_update_disease.Text + "',Status_Of_Diseases ='" + txt_patient_update_ststusofdisease.Text + "'where Patient_ID='" + txt_patient_update_id.Text + "'";
                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully updated !");
                string SQL = "select *from PATIENT_TB";
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_patient_update.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        private void dgv_patient_update_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_patient_update.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_patient_update_id.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Patient_ID"].Value.ToString();
                dtp_patient_update.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Admit_Date"].Value.ToString();
                txt_patient_update_name.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Patients_Name"].Value.ToString();
                cmb_patient__update_gender.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Patients_Gender"].Value.ToString();
                txt_patient_update_age.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Patients_Age"].Value.ToString();
                txt_patient__update_address.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Patients_Address"].Value.ToString();
                txt_patient_update_phonenumber.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Patients_Phone_Number"].Value.ToString();
                cmb_patient_update_bloodgroup.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Blood_Group"].Value.ToString();
                txt_patient_update_roomno.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Patients_Room_No"].Value.ToString();
                txt_patient_update_disease.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Disease"].Value.ToString();
                txt_patient_update_ststusofdisease.Text = dgv_patient_update.Rows[e.RowIndex].Cells["Status_Of_Diseases"].Value.ToString();
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT*FROM PATIENT_TB";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_patient_update.DataSource = dt;
        }

        private void txt_patient_update_id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_patient_update_id.Text))
            {
                e.Cancel = true;
                txt_patient_update_id.Focus();
                errorProvider_patient_update.SetError(txt_patient_update_id, "Please enter patient's ID !");
            }
            else
            {
                e.Cancel = false;

                errorProvider_patient_update.SetError(txt_patient_update_id, "");
            }
        }

        private void txt_patient_update_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_patient_update_name.Text))
            {
                e.Cancel = true;
                txt_patient_update_name.Focus();
                errorProvider_patient_update.SetError(txt_patient_update_name, "Please enter patient's name");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_update.SetError(txt_patient_update_name, "");
            }
        }

        private void cmb_patient__update_gender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_patient__update_gender.Text))
            {
                e.Cancel = true;
                cmb_patient__update_gender.Focus();
                errorProvider_patient_update.SetError(cmb_patient__update_gender, "Please select gender !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_update.SetError(cmb_patient__update_gender, "");
            }
        }

        private void txt_patient_update_age_Validating(object sender, CancelEventArgs e)
        {
            if (txt_patient_update_age.Text.Any(char.IsDigit))


            {
                errorProvider_patient_update.SetError(txt_patient_update_age, null);
            }
            else
            {
                txt_patient_update_age.Focus();
                errorProvider_patient_update.SetError(txt_patient_update_age, "Please enter only digits !");
            }
        }

        private void txt_patient_update_phonenumber_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_patient_update_phonenumber.Text != string.Empty) && (txt_patient_update_phonenumber.TextLength == 10) && (txt_patient_update_phonenumber.Text.Any(char.IsDigit)))
            {
                errorProvider_patient_update.SetError(txt_patient_update_phonenumber, null);
            }
            else
            {
                txt_patient_update_phonenumber.Focus();
                errorProvider_patient_update.SetError(txt_patient_update_phonenumber, "Please enter valid phone number !");
            }
        }

        private void cmb_patient_update_bloodgroup_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_patient_update_bloodgroup.Text))
            {
                e.Cancel = true;
                cmb_patient_update_bloodgroup.Focus();
                errorProvider_patient_update.SetError(cmb_patient_update_bloodgroup, "Please select blood group !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_update.SetError(cmb_patient_update_bloodgroup, "");
            }
        }

        private void txt_patient_update_roomno_Validating(object sender, CancelEventArgs e)
        {
            if (txt_patient_update_roomno.Text.Any(char.IsDigit))

            {
                errorProvider_patient_update.SetError(txt_patient_update_roomno, null);
            }
            else
            {
                txt_patient_update_roomno.Focus();
                errorProvider_patient_update.SetError(txt_patient_update_roomno, "Please enter only digits !");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from PATIENT_TB where Patient_ID='" + txt_patient_update_id.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv_patient_update.DataSource = dt;
            con.Close();
        }
    }
}
    