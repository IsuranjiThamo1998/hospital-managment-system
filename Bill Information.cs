using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI__group_final_project
{
    public partial class Bill_information : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=HOSPITAL_DB;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);
        public Bill_information()
        {
            InitializeComponent();
        }


      
       

       

      

        private void printDocument_print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(txt_head.Text, new Font("Book antiqua", 16, FontStyle.Bold), Brushes.MediumPurple, new Point(200, 10));
            e.Graphics.DrawString(richTextBoxReceipt.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 100));
        }

        

        private void frm_bill_information_Load(object sender, EventArgs e)
        {

        }

        

        

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double Rcharge, Mcharge, Scharge, Dcharge, billamount, tax, tot;
            Rcharge = Convert.ToDouble(txt_room_charge.Text);
            Mcharge = Convert.ToDouble(txt_medicine_charge.Text);
            Scharge = Convert.ToDouble(txt_service_charge.Text);
            Dcharge = Convert.ToDouble(txt_doctor_charge.Text);

            billamount = Rcharge + Mcharge + Scharge + Dcharge;
            txt_bill_amount.Text = Convert.ToString(billamount);

            if (50000 < billamount && 100000 > billamount)
            {
                tax = (billamount * 3) / 100;
                tot = billamount + tax;
                txt_tax_amount.Text = Convert.ToString(tax);
                txt_total_amount.Text = Convert.ToString(tot);

            }
            else if (100000 < billamount && 300000 > billamount)
            {
                tax = (billamount * 5) / 100;
                tot = billamount + tax;
                txt_tax_amount.Text = Convert.ToString(tax);
                txt_total_amount.Text = Convert.ToString(tot);
            }
            else if (billamount < 300000)
            {
                tax = (billamount * 7) / 100;
                tot = billamount + tax;
                txt_tax_amount.Text = Convert.ToString(tax);
                txt_total_amount.Text = Convert.ToString(tot);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"INSERT INTO BILL_TB(Bill_No,Room_Charge,Medicine_Charge,Service_Charge,Doctor_Charge,Bill_Amount,Tax_Amount,Total_Bill_Amount)
                              VALUES('" + txt_bill_no.Text + "', '" + txt_room_charge.Text + "', '" + txt_medicine_charge.Text + "', '" + txt_service_charge.Text + "', '" + txt_doctor_charge.Text + "','" + txt_bill_amount.Text + "','" + txt_tax_amount.Text + "','" + txt_total_amount.Text + "')";
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

        private void btnRecipt_Click(object sender, EventArgs e)
        {
            
            richTextBoxReceipt.Text += "\n\n\n\n\n\n\tDate :" + DateTime.Now + "\n";

            richTextBoxReceipt.Text += "\n\n\tBill No                        :" + txt_bill_no.Text + "\n\n";
            richTextBoxReceipt.Text += "\tRoom Charge            :" + txt_room_charge.Text + "\n\n";
            richTextBoxReceipt.Text += "\tMedicine Charge        :" + txt_medicine_charge.Text + "\n\n";
            richTextBoxReceipt.Text += "\tService Charge          :" + txt_service_charge.Text + "\n\n";
            richTextBoxReceipt.Text += "\tDoctor's Charge         :" + txt_doctor_charge.Text + "\n\n";
            richTextBoxReceipt.Text += "\tBill Amount                 :" + txt_bill_amount.Text + "\n\n";
            richTextBoxReceipt.Text += "\tTax Amount                 :" + txt_tax_amount.Text + "\n\n";
            richTextBoxReceipt.Text += "\tTotal Bill Amount         :" + txt_total_amount.Text + "\n\n";


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog_print.Document = printDocument_print;
            printPreviewDialog_print.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT*FROM BILL_TB";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvBill.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_bill_no.Text = "";
            txt_room_charge.Text = "";
            txt_medicine_charge.Text = "";
            txt_service_charge.Text = "";
            txt_doctor_charge.Text = "";
            txt_bill_amount.Text = "";
            txt_tax_amount.Text = "";
            txt_total_amount.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_bill_no.Text = dgvBill.Rows[e.RowIndex].Cells["Bill_No"].Value.ToString();
                txt_room_charge.Text = dgvBill.Rows[e.RowIndex].Cells["Room_Charge"].Value.ToString();
                txt_medicine_charge.Text = dgvBill.Rows[e.RowIndex].Cells["Medicine_Charge"].Value.ToString();
                txt_service_charge.Text = dgvBill.Rows[e.RowIndex].Cells["Service_Charge"].Value.ToString();
                txt_doctor_charge.Text = dgvBill.Rows[e.RowIndex].Cells["Doctor_Charge"].Value.ToString();
                txt_bill_amount.Text = dgvBill.Rows[e.RowIndex].Cells["Bill_Amount"].Value.ToString();
                txt_tax_amount.Text = dgvBill.Rows[e.RowIndex].Cells["Tax_Amount"].Value.ToString();
                txt_total_amount.Text = dgvBill.Rows[e.RowIndex].Cells["Total_Bill_Amount"].Value.ToString();
            }
        }
    }
}
