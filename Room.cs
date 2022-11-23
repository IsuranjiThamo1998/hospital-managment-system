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
    public partial class Room : Form
    {


        static string connectionString = @"data source=LAPTOP-99795JHL;initial catalog=HOSPITAL_DB;integrated security=yes";
        SqlConnection con = new SqlConnection(connectionString);


        public Room()
        {
            InitializeComponent();
        }

       

        private void btn_staff_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_room_clear_Click(object sender, EventArgs e)
        {
            
            txt_room_no.Text = "";
            txt_building_no.Text = "";
            cmb_room_type.Text = "";
            txt_room_numberofbed.Text = "";
            txt_room_price.Text = "";
            txt_room_status.Text = "";
        }

        private void btn_room_save_Click(object sender, EventArgs e)
        {
            

            try
            {
                string sql = @"INSERT INTO ROOM_TB(Room_No,Building_No,Room_Type,Number_Of_Beds,Price,Status)values('" + txt_room_no.Text + "','" + txt_building_no.Text + "','" + cmb_room_type.Text + "','" + txt_room_numberofbed.Text + "','" + txt_room_price.Text + "','" + txt_room_status.Text + "')";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Records  successfully saved !");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_room_display_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "select * from ROOM_TB";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_room.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    private void btn_room_update_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = @"UPDATE ROOM_TB SET Room_No='" + txt_room_no.Text + "',Building_No='" + txt_building_no.Text + "',Room_Type='" + cmb_room_type.Text + "',Number_Of_Beds='" + txt_room_numberofbed.Text + "',Price='" + txt_room_price.Text + "',Status='" + txt_room_status.Text + "' WHERE Room_No='" + txt_room_no.Text + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully updated !");
                string SQL = "SELECT *FROM ROOM_TB";
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_room.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_room_delete_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string sql = @"DELETE FROM ROOM_TB WHERE Room_No='" + txt_room_no.Text + "'";
                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Record  successfully deleted !");
                string SQL = "SELECT *FROM ROOM_TB";
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_room.DataSource = dt;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void txt_building_no_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_building_no.Text))
            {
                e.Cancel = true;
                txt_building_no.Focus();
                errorProvider_room.SetError(txt_building_no, "Please select building number !");
            }
            else
            {
                e.Cancel = false;

                errorProvider_room.SetError(txt_building_no, "");
            }
        }

        private void cmb_room_type_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_room_type.Text))
            {
                e.Cancel = true;
                cmb_room_type.Focus();
                errorProvider_room.SetError(cmb_room_type, "Please select room type !");
            }
            else
            {
                e.Cancel = false;

                errorProvider_room.SetError(cmb_room_type, "");
            }
        }

        private void txt_room_no_Validating(object sender, CancelEventArgs e)
        {
            if (txt_room_no.Text.Any(char.IsDigit))


            {
                errorProvider_room.SetError(txt_room_no, null);
            }
            else
            {

                txt_room_no.Focus();
                errorProvider_room.SetError(txt_room_no, "Please enter only digits !");
            }
        }

        private void dgv_room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_room.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_room_no.Text = dgv_room.Rows[e.RowIndex].Cells["Room_NO"].Value.ToString();
                txt_building_no.Text = dgv_room.Rows[e.RowIndex].Cells["Building_No"].Value.ToString();
                cmb_room_type.Text = dgv_room.Rows[e.RowIndex].Cells["Room_Type"].Value.ToString();
                txt_room_numberofbed.Text = dgv_room.Rows[e.RowIndex].Cells["Number_Of_Beds"].Value.ToString();
                txt_room_price.Text = dgv_room.Rows[e.RowIndex].Cells["price"].Value.ToString();
                txt_room_status.Text = dgv_room.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            }
         }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from ROOM_TB where Room_No = '" + txt_room_no.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgv_room.DataSource = dt;
            con.Close();
        }
    
    }
}

