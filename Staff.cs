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
    public partial class Staff : Form
    {
        static string connectionString = @"data source=LAPTOP-99795JHL;initial catalog=HOSPITAL_DB;integrated security=yes";
        SqlConnection con = new SqlConnection(connectionString);

        public Staff()
        {
            InitializeComponent();
        }

        private void btn_staff_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_staff_clear_Click(object sender, EventArgs e)
        {
            txt_staff_id.Text = "";
            dateTimePicker_staff.Text = "";
            txt_staff_name.Text = "";
            cmb_staff_gender.Text = "";
            txt_staff_age.Text = "";
            txt_staff_address.Text = "";
            txt_staff_phonenumber.Text = "";
            txt_staff_email.Text = "";
            cmb_staff_position.Text = "";
            txt_staff_salary.Text = "";
        }

        private void btn_staff_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"INSERT INTO STAFF_TB(Staff_ID,Staff_Register_Date,Staff_Name,Staff_Gender,Staff_Age,Staff_Address,Staff_Phone_Number,Staff_Email,Position,Salary) values('" + txt_staff_id.Text + "','" + dateTimePicker_staff.Value.ToString() + "','" + txt_staff_name.Text + "','" + cmb_staff_gender.Text + "','" + txt_staff_age.Text + "','" + txt_staff_address.Text + "','" + txt_staff_phonenumber.Text + "','" + txt_staff_email.Text + "','" + cmb_staff_position.Text + "','" + txt_staff_salary.Text + "')";
                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Records  successfully saved !");
                con.Close()
 ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_staff_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"UPDATE STAFF_TB SET Staff_ID='" + txt_staff_id.Text + "',Staff_Register_Date='" + dateTimePicker_staff.Value.ToString() + "',Staff_Name='" + txt_staff_name.Text + "',Staff_Gender='" + cmb_staff_gender.Text + "',Staff_Age='" + txt_staff_age.Text + "',Staff_Address='" + txt_staff_address.Text + "',Staff_Phone_Number='" + txt_staff_phonenumber.Text + "',Staff_Email='" + txt_staff_email.Text + "',Position='" + cmb_staff_position.Text + "',Salary='" + txt_staff_salary.Text + "' where Staff_ID='" + txt_staff_id.Text + "'";
                SqlCommand command = new SqlCommand(sql, con);

                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("records Updated successfully");
                string SQL = "select * from STAFF_TB";
                SqlDataAdapter ada = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgv_staff.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_staff_display_Click(object sender, EventArgs e)
        {
            try 
            { 
            con.Open();
            string sql = "select * from STAFF_TB";
            SqlDataAdapter ada = new SqlDataAdapter(sql, con);
            DataTable dtable = new DataTable();
            ada.Fill(dtable);
            dgv_staff.DataSource = dtable;
            con.Close();
        }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_staff_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"DELETE FROM STAFF_TB where Staff_ID ='" + txt_staff_id.Text + "'";

                SqlCommand command = new SqlCommand(sql, con);


                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Records successfully Deleted !");
                string SQL = "select * from STAFF_TB";
                SqlDataAdapter ada = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgv_staff.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_staff_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from STAFF_TB where Staff_ID = '" + txt_staff_id.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv_staff.DataSource = dt;
            con.Close();
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_staff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_staff_id.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_ID"].Value.ToString();
                dateTimePicker_staff.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_Register_Date"].Value.ToString();
                txt_staff_name.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_Name"].Value.ToString();
                cmb_staff_gender.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_Gender"].Value.ToString();
                txt_staff_age.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_Age"].Value.ToString();
                txt_staff_address.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_Address"].Value.ToString();
                txt_staff_phonenumber.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_Phone_Number"].Value.ToString();
                txt_staff_email.Text = dgv_staff.Rows[e.RowIndex].Cells["Staff_Email"].Value.ToString();
                cmb_staff_position.Text = dgv_staff.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                txt_staff_salary.Text = dgv_staff.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
            }
        }

        private void txt_staff_id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_staff_id.Text))
            {
                e.Cancel = true;
                txt_staff_id.Focus();
                errorProvider_staff.SetError(txt_staff_id, "Please enter staff ID !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_staff.SetError(txt_staff_id, null);
            }
        }

        private void txt_staff_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_staff_name.Text))
            {
                e.Cancel = true;
                txt_staff_name.Focus();
                errorProvider_staff.SetError(txt_staff_name, "Please enter name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_staff.SetError(txt_staff_name, null);
            }
        }

        private void cmb_staff_gender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_staff_gender.Text))
            {
                e.Cancel = true;
                cmb_staff_gender.Focus();
                errorProvider_staff.SetError(cmb_staff_gender, "Please select gender !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_staff.SetError(cmb_staff_gender, null);
            }
        }

        private void txt_staff_age_Validating(object sender, CancelEventArgs e)
        {
            if (txt_staff_age.Text.Any(char.IsDigit))


            {
                errorProvider_staff.SetError(txt_staff_age, null);
            }
            else
            {
                txt_staff_age.Focus();
                errorProvider_staff.SetError(txt_staff_age, "Please enter only digits !");
            }
        }

        private void txt_staff_address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_staff_address.Text))
            {
                e.Cancel = true;
                txt_staff_address.Focus();
                errorProvider_staff.SetError(txt_staff_address, "Please enter address !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_staff.SetError(txt_staff_address, null);
            }
        }

        private void txt_staff_phonenumber_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_staff_phonenumber.Text != string.Empty) && (txt_staff_phonenumber.TextLength == 10) && (txt_staff_phonenumber.Text.Any(char.IsDigit)))
            {
                errorProvider_staff.SetError(txt_staff_phonenumber, null);
            }
            else
            {
                txt_staff_phonenumber.Focus();
                errorProvider_staff.SetError(txt_staff_phonenumber, "Please enter valid phone number !");
            }
        }

        private void txt_staff_email_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_staff_email.Text != string.Empty) && (txt_staff_email.Text.Contains("@") && (txt_staff_email.Text.Contains("."))))
            {
                errorProvider_staff.SetError(txt_staff_email, null);
            }
            else
            {
                txt_staff_email.Focus();
                errorProvider_staff.SetError(txt_staff_email, "Please enter valid email address !");
            }
        }

        private void cmb_staff_position_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_staff_position.Text))
            {
                e.Cancel = true;
                cmb_staff_position.Focus();
                errorProvider_staff.SetError(cmb_staff_position, "Please select position !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_staff.SetError(cmb_staff_position, null);
            }
        }
    }
}

