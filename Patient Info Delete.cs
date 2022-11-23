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
    public partial class Patient_Info_delete : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);
        public Patient_Info_delete()
        {
            InitializeComponent();
        }

        private void btn_patient_delete_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_patient_delete_clear_Click(object sender, EventArgs e)
        {
            txt_patient_delete_id.Text = "";
            dtp_patient_delete.Text = "";
            txt_patient_delete_name.Text = "";
            cmb_patient_delete_gender.Text = "";
            txt_patient_delete_age.Text = "";
            txt_patient_delete_address.Text = "";
            txt_patient_delete_phonenumber.Text = "";
            cmb_patient_delete_bloodgroup.Text = "";
            txt_patient_delete_roomno.Text = "";
            txt_patient_delete_disease.Text = "";
            txt_patient_delete_statusofdisease.Text = "";
        }

        private void btn_patient__delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"delete from PATIENT_TB where Patient_ID='" + txt_patient_delete_id.Text + "'";
                SqlCommand cmbdatabase = new SqlCommand(sql, con);
                cmbdatabase.ExecuteNonQuery();
                MessageBox.Show("Sucessfully deleted !");
                string SQL = "SELECT*FROM PATIENT_TB";
                SqlDataAdapter ada = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgv_patient_delete.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT*FROM PATIENT_TB";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_patient_delete.DataSource = dt;
        }

        private void dgv_patient_delete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_patient_delete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_patient_delete_id.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Patient_ID"].Value.ToString();
                dtp_patient_delete.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Admit_Date"].Value.ToString();
                txt_patient_delete_name.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Patients_Name"].Value.ToString();
                cmb_patient_delete_gender.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Patients_Gender"].Value.ToString();
                txt_patient_delete_age.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Patients_Age"].Value.ToString();
                txt_patient_delete_address.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Patients_Address"].Value.ToString();
                txt_patient_delete_phonenumber.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Patients_Phone_Number"].Value.ToString();
                cmb_patient_delete_bloodgroup.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Blood_Group"].Value.ToString();
                txt_patient_delete_roomno.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Patients_Room_No"].Value.ToString();
                txt_patient_delete_disease.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Disease"].Value.ToString();
                txt_patient_delete_statusofdisease.Text = dgv_patient_delete.Rows[e.RowIndex].Cells["Status_Of_Diseases"].Value.ToString();
            }

        }

        private void txt_patient_delete_id_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_patient_delete_id.Text))
            {
                e.Cancel = true;
                txt_patient_delete_id.Focus();
                errorProvider_patient_delete.SetError(txt_patient_delete_id, "Please enter patient's ID !");
            }
            else
            {
                e.Cancel = false;

                errorProvider_patient_delete.SetError(txt_patient_delete_id, "");
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from PATIENT_TB where Patient_ID='" + txt_patient_delete_id.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv_patient_delete.DataSource = dt;
            con.Close();
        }
    }
}