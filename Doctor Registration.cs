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
    public partial class Doctor_registration : Form
    {

        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);

        public Doctor_registration()
        {
            InitializeComponent();
        }

        private void btn_doctor_reg_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doctor_reg_clear_Click(object sender, EventArgs e)
        {
            txt_doctor_reg_id.Text = "";
            dtp_doc_regi_date.Text = "";
            txt_doctor_reg_name.Text = "";
            cmb_doctor_reg_gender.Text = "";
            txt_doctor_reg_age.Text = "";
            txt_doctor_reg_address.Text = "";
            txt_doctor_reg_phonenumber.Text = "";
            txt_reg_email.Text = "";
            txt_reg_specialization.Text = "";
        }

        private void btn_doctor_reg_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"INSERT INTO DOCTOR_TB(Doctors_ID,Doctors_Register_Date,Doctors_Name,Doctor_Gender,Doctor_Age,Doctor_Address,Doctor_Phone_Number,Doctor_Email,Specialization)
                              VALUES('" + txt_doctor_reg_id.Text + "', '" + dtp_doc_regi_date.Value.ToString() + "', '" + txt_doctor_reg_name.Text + "', '" + cmb_doctor_reg_gender.Text + "', '" + txt_doctor_reg_age.Text + "', '" + txt_doctor_reg_address.Text + "', '" + txt_doctor_reg_phonenumber.Text + "', '" + txt_reg_email.Text + "', '" + txt_reg_specialization.Text + "')";
                SqlCommand command = new SqlCommand(sql, con);


                command.ExecuteNonQuery();
                MessageBox.Show("Records successfully saved !");

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_doctor_reg_id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_doctor_reg_id.Text))
            {
                e.Cancel = true;
                txt_doctor_reg_id.Focus();
                errorProvider_doc_reg.SetError(txt_doctor_reg_id, "Please enter doctor's ID !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_reg.SetError(txt_doctor_reg_id, null);
            }
        }

        private void txt_doctor_reg_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_doctor_reg_name.Text))
            {
                e.Cancel = true;
                txt_doctor_reg_name.Focus();
                errorProvider_doc_reg.SetError(txt_doctor_reg_name, "Please enter doctor's name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_reg.SetError(txt_doctor_reg_name, null);
            }
        }

        private void cmb_doctor_reg_gender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_doctor_reg_gender.Text))
            {
                e.Cancel = true;
                cmb_doctor_reg_gender.Focus();
                errorProvider_doc_reg.SetError(cmb_doctor_reg_gender, "Please select gender !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_reg.SetError(cmb_doctor_reg_gender, null);
            }
        }

        private void txt_doctor_reg_address_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_doctor_reg_address.Text))
            {
                e.Cancel = true;
                txt_doctor_reg_address.Focus();
                errorProvider_doc_reg.SetError(txt_doctor_reg_address, "Please enter address !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_reg.SetError(txt_doctor_reg_address, null);
            }
        }

        private void txt_doctor_reg_phonenumber_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_doctor_reg_phonenumber.Text != string.Empty) && (txt_doctor_reg_phonenumber.TextLength == 10) && (txt_doctor_reg_phonenumber.Text.Any(char.IsDigit)))
            {
                errorProvider_doc_reg.SetError(txt_doctor_reg_phonenumber, null);
            }
            else
            {
                txt_doctor_reg_phonenumber.Focus();
                errorProvider_doc_reg.SetError(txt_doctor_reg_phonenumber, "Please enter valid phone number !");
            }
        }

        private void txt_reg_email_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_reg_email.Text != string.Empty) && (txt_reg_email.Text.Contains("@") && (txt_reg_email.Text.Contains("."))))
            {
                errorProvider_doc_reg.SetError(txt_reg_email, null);
            }
            else
            {
                txt_reg_email.Focus();
                errorProvider_doc_reg.SetError(txt_reg_email, "Please enter valid email address !");
            }
        }

        private void txt_reg_specialization_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_reg_specialization.Text))
            {
                e.Cancel = true;
                txt_reg_specialization.Focus();
                errorProvider_doc_reg.SetError(txt_reg_specialization, "Please enter specialization !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_doc_reg.SetError(txt_reg_specialization, null);
            }
        }

        private void txt_doctor_reg_age_Validating(object sender, CancelEventArgs e)
        {
            if (txt_doctor_reg_age.Text.Any(char.IsDigit))


            {
                errorProvider_doc_reg.SetError(txt_doctor_reg_age, null);
            }
            else
            {
                txt_doctor_reg_age.Focus();
                errorProvider_doc_reg.SetError(txt_doctor_reg_age, "Please enter only digits !");
            }
        }
    }
}