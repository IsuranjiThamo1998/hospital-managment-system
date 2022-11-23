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
    public partial class Patient_registration : Form
    {
        public static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);

        public Patient_registration()
        {
            InitializeComponent();
        }

        private void btn_patient_reg_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_patient_reg_clear_Click(object sender, EventArgs e)
        {
            txt_patient_reg_id.Text = "";
            dtp_patient_reg.Text = "";
            txt_patient_reg_name.Text = "";
            cmb_patient_reg_gender.Text = "";
            txt_patient_reg_age.Text = "";
            txt_patient_reg_address.Text = "";
            txt_patient_reg_phonenumber.Text = "";
            cmb_patient_reg_bloodgroup.Text = "";
            txt_patient_reg_roomno.Text = "";
            txt_patient_reg_disease.Text = "";
            txt_patient_reg_ststusofdisease.Text = "";
        }

        private void btn_patient_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"insert into PATIENT_TB(Patient_ID ,Admit_Date ,Patients_Name ,Patients_Gender ,Patients_Age ,Patients_Address,Patients_Phone_Number ,Blood_Group ,Patients_Room_No ,Disease ,Status_Of_Diseases)
                                        values('" + txt_patient_reg_id.Text + "','" + dtp_patient_reg.Value.ToString() + "','" + txt_patient_reg_name.Text + "','" + cmb_patient_reg_gender.Text + "','" + txt_patient_reg_age.Text + "','" + txt_patient_reg_address.Text + "','" + txt_patient_reg_phonenumber.Text + "','" + cmb_patient_reg_bloodgroup.Text + "','" + txt_patient_reg_roomno.Text + "','" + txt_patient_reg_disease.Text + "','" + txt_patient_reg_ststusofdisease.Text + "')";

                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Records successfully added");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_patient_reg_id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_patient_reg_id.Text))
            {
                e.Cancel = true;
                txt_patient_reg_id.Focus();
                errorProvider_patient_reg.SetError(txt_patient_reg_id, "Please enter patient's ID !");
            }
            else
            {
                e.Cancel = false;

                errorProvider_patient_reg.SetError(txt_patient_reg_id, "");
            }
        }

        private void txt_patient_reg_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_patient_reg_name.Text))
            {
                e.Cancel = true;
                txt_patient_reg_name.Focus();
                errorProvider_patient_reg.SetError(txt_patient_reg_name, "Please enter patient's name");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_reg.SetError(txt_patient_reg_name, "");
            }
        }

        private void cmb_patient_reg_gender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_patient_reg_gender.Text))
            {
                e.Cancel = true;
                cmb_patient_reg_gender.Focus();
                errorProvider_patient_reg.SetError(cmb_patient_reg_gender, "Please select gender !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_reg.SetError(cmb_patient_reg_gender, "");
            }
        }

        private void txt_patient_reg_phonenumber_Validating(object sender, CancelEventArgs e)
        {
            if ((txt_patient_reg_phonenumber.Text != string.Empty) && (txt_patient_reg_phonenumber.TextLength == 10) && (txt_patient_reg_phonenumber.Text.Any(char.IsDigit)))
            {
                errorProvider_patient_reg.SetError(txt_patient_reg_phonenumber, null);
            }
            else
            {
                txt_patient_reg_phonenumber.Focus();
                errorProvider_patient_reg.SetError(txt_patient_reg_phonenumber, "Please enter valid phone number !");
            }
        }

        private void cmb_patient_reg_bloodgroup_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_patient_reg_bloodgroup.Text))
            {
                e.Cancel = true;
                cmb_patient_reg_bloodgroup.Focus();
                errorProvider_patient_reg.SetError(cmb_patient_reg_bloodgroup, "Please select blood group !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_reg.SetError(cmb_patient_reg_bloodgroup, "");
            }
        }

        private void txt_patient_reg_roomno_Validating(object sender, CancelEventArgs e)
        {
            if(txt_patient_reg_roomno.Text.Any(char.IsDigit) )
            
                {
                    errorProvider_patient_reg.SetError(txt_patient_reg_roomno, null);
                }
            else
                {
                txt_patient_reg_roomno.Focus();
                    errorProvider_patient_reg.SetError(txt_patient_reg_roomno, "Please enter only digits !");
                }
            }

        private void txt_patient_reg_age_Validating(object sender, CancelEventArgs e)
        {
            if(txt_patient_reg_age.Text.Any(char.IsDigit))


                {
                errorProvider_patient_reg.SetError(txt_patient_reg_age, null);
            }
            else
            {
                txt_patient_reg_age.Focus();
                errorProvider_patient_reg.SetError(txt_patient_reg_age, "Please enter only digits !");
            }
        }
    }
}
