
namespace GUI__group_final_project
{
    partial class Doctor_information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_doctor_display_clear = new System.Windows.Forms.Button();
            this.dgv_doctor_display = new System.Windows.Forms.DataGridView();
            this.txt_doctor_display_date = new System.Windows.Forms.TextBox();
            this.lbl_doctor__display_date = new System.Windows.Forms.Label();
            this.cmb_doctor_display_gender = new System.Windows.Forms.ComboBox();
            this.txt_display_email = new System.Windows.Forms.TextBox();
            this.txt_display_specialization = new System.Windows.Forms.TextBox();
            this.txt_doctor_display_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_doctor_display_address = new System.Windows.Forms.TextBox();
            this.txt_doctor_display_age = new System.Windows.Forms.TextBox();
            this.txt_doctor_display_name = new System.Windows.Forms.TextBox();
            this.lbl_display_email = new System.Windows.Forms.Label();
            this.txt_doctor_display_id = new System.Windows.Forms.TextBox();
            this.lbl_display_specialization = new System.Windows.Forms.Label();
            this.lbl_doctor__display_address = new System.Windows.Forms.Label();
            this.lbl_doctor__display_phonenumber = new System.Windows.Forms.Label();
            this.lbl_doctor__display_age = new System.Windows.Forms.Label();
            this.lbl_doctor__display_gender = new System.Windows.Forms.Label();
            this.lbl_doctor_display_name = new System.Windows.Forms.Label();
            this.lbl_doctor_display__id = new System.Windows.Forms.Label();
            this.btn_doctor_display_exit = new System.Windows.Forms.Button();
            this.btn_doctor_display = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_display)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_doctor_display_clear
            // 
            this.btn_doctor_display_clear.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_display_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_display_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_display_clear.Location = new System.Drawing.Point(328, 571);
            this.btn_doctor_display_clear.Name = "btn_doctor_display_clear";
            this.btn_doctor_display_clear.Size = new System.Drawing.Size(88, 46);
            this.btn_doctor_display_clear.TabIndex = 109;
            this.btn_doctor_display_clear.Text = "Clear";
            this.btn_doctor_display_clear.UseVisualStyleBackColor = false;
            this.btn_doctor_display_clear.Click += new System.EventHandler(this.btn_doctor_display_clear_Click);
            // 
            // dgv_doctor_display
            // 
            this.dgv_doctor_display.BackgroundColor = System.Drawing.Color.White;
            this.dgv_doctor_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_doctor_display.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doctor_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_doctor_display.ColumnHeadersHeight = 35;
            this.dgv_doctor_display.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doctor_display.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_doctor_display.GridColor = System.Drawing.Color.Black;
            this.dgv_doctor_display.Location = new System.Drawing.Point(623, 111);
            this.dgv_doctor_display.Name = "dgv_doctor_display";
            this.dgv_doctor_display.RowHeadersWidth = 24;
            this.dgv_doctor_display.RowTemplate.Height = 24;
            this.dgv_doctor_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doctor_display.Size = new System.Drawing.Size(608, 506);
            this.dgv_doctor_display.TabIndex = 108;
            this.dgv_doctor_display.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doctor_display_CellClick);
            // 
            // txt_doctor_display_date
            // 
            this.txt_doctor_display_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_display_date.Location = new System.Drawing.Point(268, 157);
            this.txt_doctor_display_date.Name = "txt_doctor_display_date";
            this.txt_doctor_display_date.Size = new System.Drawing.Size(257, 24);
            this.txt_doctor_display_date.TabIndex = 107;
            // 
            // lbl_doctor__display_date
            // 
            this.lbl_doctor__display_date.AutoSize = true;
            this.lbl_doctor__display_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__display_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__display_date.Location = new System.Drawing.Point(64, 159);
            this.lbl_doctor__display_date.Name = "lbl_doctor__display_date";
            this.lbl_doctor__display_date.Size = new System.Drawing.Size(126, 20);
            this.lbl_doctor__display_date.TabIndex = 106;
            this.lbl_doctor__display_date.Text = "Register Date";
            // 
            // cmb_doctor_display_gender
            // 
            this.cmb_doctor_display_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_doctor_display_gender.FormattingEnabled = true;
            this.cmb_doctor_display_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_doctor_display_gender.Location = new System.Drawing.Point(268, 241);
            this.cmb_doctor_display_gender.Name = "cmb_doctor_display_gender";
            this.cmb_doctor_display_gender.Size = new System.Drawing.Size(257, 26);
            this.cmb_doctor_display_gender.TabIndex = 105;
            // 
            // txt_display_email
            // 
            this.txt_display_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display_email.Location = new System.Drawing.Point(268, 420);
            this.txt_display_email.Name = "txt_display_email";
            this.txt_display_email.Size = new System.Drawing.Size(257, 24);
            this.txt_display_email.TabIndex = 104;
            // 
            // txt_display_specialization
            // 
            this.txt_display_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display_specialization.Location = new System.Drawing.Point(268, 470);
            this.txt_display_specialization.Name = "txt_display_specialization";
            this.txt_display_specialization.Size = new System.Drawing.Size(257, 24);
            this.txt_display_specialization.TabIndex = 103;
            // 
            // txt_doctor_display_phonenumber
            // 
            this.txt_doctor_display_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_display_phonenumber.Location = new System.Drawing.Point(268, 374);
            this.txt_doctor_display_phonenumber.Name = "txt_doctor_display_phonenumber";
            this.txt_doctor_display_phonenumber.Size = new System.Drawing.Size(257, 24);
            this.txt_doctor_display_phonenumber.TabIndex = 102;
            // 
            // txt_doctor_display_address
            // 
            this.txt_doctor_display_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_display_address.Location = new System.Drawing.Point(268, 329);
            this.txt_doctor_display_address.Name = "txt_doctor_display_address";
            this.txt_doctor_display_address.Size = new System.Drawing.Size(257, 24);
            this.txt_doctor_display_address.TabIndex = 101;
            // 
            // txt_doctor_display_age
            // 
            this.txt_doctor_display_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_display_age.Location = new System.Drawing.Point(268, 291);
            this.txt_doctor_display_age.Name = "txt_doctor_display_age";
            this.txt_doctor_display_age.Size = new System.Drawing.Size(257, 24);
            this.txt_doctor_display_age.TabIndex = 100;
            // 
            // txt_doctor_display_name
            // 
            this.txt_doctor_display_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_display_name.Location = new System.Drawing.Point(268, 203);
            this.txt_doctor_display_name.Name = "txt_doctor_display_name";
            this.txt_doctor_display_name.Size = new System.Drawing.Size(257, 24);
            this.txt_doctor_display_name.TabIndex = 99;
            // 
            // lbl_display_email
            // 
            this.lbl_display_email.AutoSize = true;
            this.lbl_display_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_display_email.Location = new System.Drawing.Point(64, 422);
            this.lbl_display_email.Name = "lbl_display_email";
            this.lbl_display_email.Size = new System.Drawing.Size(63, 20);
            this.lbl_display_email.TabIndex = 98;
            this.lbl_display_email.Text = "E-mail";
            // 
            // txt_doctor_display_id
            // 
            this.txt_doctor_display_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_display_id.Location = new System.Drawing.Point(268, 111);
            this.txt_doctor_display_id.Name = "txt_doctor_display_id";
            this.txt_doctor_display_id.Size = new System.Drawing.Size(257, 24);
            this.txt_doctor_display_id.TabIndex = 97;
            // 
            // lbl_display_specialization
            // 
            this.lbl_display_specialization.AutoSize = true;
            this.lbl_display_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_specialization.ForeColor = System.Drawing.Color.Black;
            this.lbl_display_specialization.Location = new System.Drawing.Point(64, 472);
            this.lbl_display_specialization.Name = "lbl_display_specialization";
            this.lbl_display_specialization.Size = new System.Drawing.Size(127, 20);
            this.lbl_display_specialization.TabIndex = 96;
            this.lbl_display_specialization.Text = "Specialization";
            // 
            // lbl_doctor__display_address
            // 
            this.lbl_doctor__display_address.AutoSize = true;
            this.lbl_doctor__display_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__display_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__display_address.Location = new System.Drawing.Point(64, 331);
            this.lbl_doctor__display_address.Name = "lbl_doctor__display_address";
            this.lbl_doctor__display_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_doctor__display_address.TabIndex = 95;
            this.lbl_doctor__display_address.Text = "Address";
            // 
            // lbl_doctor__display_phonenumber
            // 
            this.lbl_doctor__display_phonenumber.AutoSize = true;
            this.lbl_doctor__display_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__display_phonenumber.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__display_phonenumber.Location = new System.Drawing.Point(64, 376);
            this.lbl_doctor__display_phonenumber.Name = "lbl_doctor__display_phonenumber";
            this.lbl_doctor__display_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_doctor__display_phonenumber.TabIndex = 94;
            this.lbl_doctor__display_phonenumber.Text = "Phone Number";
            // 
            // lbl_doctor__display_age
            // 
            this.lbl_doctor__display_age.AutoSize = true;
            this.lbl_doctor__display_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__display_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__display_age.Location = new System.Drawing.Point(64, 293);
            this.lbl_doctor__display_age.Name = "lbl_doctor__display_age";
            this.lbl_doctor__display_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_doctor__display_age.TabIndex = 93;
            this.lbl_doctor__display_age.Text = "Age";
            // 
            // lbl_doctor__display_gender
            // 
            this.lbl_doctor__display_gender.AutoSize = true;
            this.lbl_doctor__display_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__display_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__display_gender.Location = new System.Drawing.Point(64, 245);
            this.lbl_doctor__display_gender.Name = "lbl_doctor__display_gender";
            this.lbl_doctor__display_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_doctor__display_gender.TabIndex = 92;
            this.lbl_doctor__display_gender.Text = "Gender";
            // 
            // lbl_doctor_display_name
            // 
            this.lbl_doctor_display_name.AutoSize = true;
            this.lbl_doctor_display_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_display_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_display_name.Location = new System.Drawing.Point(64, 205);
            this.lbl_doctor_display_name.Name = "lbl_doctor_display_name";
            this.lbl_doctor_display_name.Size = new System.Drawing.Size(135, 20);
            this.lbl_doctor_display_name.TabIndex = 91;
            this.lbl_doctor_display_name.Text = "Doctor\'s Name";
            // 
            // lbl_doctor_display__id
            // 
            this.lbl_doctor_display__id.AutoSize = true;
            this.lbl_doctor_display__id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_display__id.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_display__id.Location = new System.Drawing.Point(64, 115);
            this.lbl_doctor_display__id.Name = "lbl_doctor_display__id";
            this.lbl_doctor_display__id.Size = new System.Drawing.Size(106, 20);
            this.lbl_doctor_display__id.TabIndex = 90;
            this.lbl_doctor_display__id.Text = "Doctor\'s ID";
            // 
            // btn_doctor_display_exit
            // 
            this.btn_doctor_display_exit.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_display_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_display_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_display_exit.Location = new System.Drawing.Point(463, 571);
            this.btn_doctor_display_exit.Name = "btn_doctor_display_exit";
            this.btn_doctor_display_exit.Size = new System.Drawing.Size(88, 46);
            this.btn_doctor_display_exit.TabIndex = 89;
            this.btn_doctor_display_exit.Text = "Exit";
            this.btn_doctor_display_exit.UseVisualStyleBackColor = false;
            this.btn_doctor_display_exit.Click += new System.EventHandler(this.btn_doctor_display_exit_Click);
            // 
            // btn_doctor_display
            // 
            this.btn_doctor_display.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_display.Location = new System.Drawing.Point(68, 571);
            this.btn_doctor_display.Name = "btn_doctor_display";
            this.btn_doctor_display.Size = new System.Drawing.Size(88, 46);
            this.btn_doctor_display.TabIndex = 88;
            this.btn_doctor_display.Text = "Display";
            this.btn_doctor_display.UseVisualStyleBackColor = false;
            this.btn_doctor_display.Click += new System.EventHandler(this.btn_doctor_display_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1199, 61);
            this.button1.TabIndex = 135;
            this.button1.Text = "Doctor Information";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Purple;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(197, 571);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 46);
            this.btn_search.TabIndex = 136;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Doctor_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 679);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_doctor_display_clear);
            this.Controls.Add(this.dgv_doctor_display);
            this.Controls.Add(this.txt_doctor_display_date);
            this.Controls.Add(this.lbl_doctor__display_date);
            this.Controls.Add(this.cmb_doctor_display_gender);
            this.Controls.Add(this.txt_display_email);
            this.Controls.Add(this.txt_display_specialization);
            this.Controls.Add(this.txt_doctor_display_phonenumber);
            this.Controls.Add(this.txt_doctor_display_address);
            this.Controls.Add(this.txt_doctor_display_age);
            this.Controls.Add(this.txt_doctor_display_name);
            this.Controls.Add(this.lbl_display_email);
            this.Controls.Add(this.txt_doctor_display_id);
            this.Controls.Add(this.lbl_display_specialization);
            this.Controls.Add(this.lbl_doctor__display_address);
            this.Controls.Add(this.lbl_doctor__display_phonenumber);
            this.Controls.Add(this.lbl_doctor__display_age);
            this.Controls.Add(this.lbl_doctor__display_gender);
            this.Controls.Add(this.lbl_doctor_display_name);
            this.Controls.Add(this.lbl_doctor_display__id);
            this.Controls.Add(this.btn_doctor_display_exit);
            this.Controls.Add(this.btn_doctor_display);
            this.Name = "Doctor_information";
            this.Text = "Doctor Information";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doctor_display_clear;
        private System.Windows.Forms.DataGridView dgv_doctor_display;
        private System.Windows.Forms.TextBox txt_doctor_display_date;
        private System.Windows.Forms.Label lbl_doctor__display_date;
        private System.Windows.Forms.ComboBox cmb_doctor_display_gender;
        private System.Windows.Forms.TextBox txt_display_email;
        private System.Windows.Forms.TextBox txt_display_specialization;
        private System.Windows.Forms.TextBox txt_doctor_display_phonenumber;
        private System.Windows.Forms.TextBox txt_doctor_display_address;
        private System.Windows.Forms.TextBox txt_doctor_display_age;
        private System.Windows.Forms.TextBox txt_doctor_display_name;
        private System.Windows.Forms.Label lbl_display_email;
        private System.Windows.Forms.TextBox txt_doctor_display_id;
        private System.Windows.Forms.Label lbl_display_specialization;
        private System.Windows.Forms.Label lbl_doctor__display_address;
        private System.Windows.Forms.Label lbl_doctor__display_phonenumber;
        private System.Windows.Forms.Label lbl_doctor__display_age;
        private System.Windows.Forms.Label lbl_doctor__display_gender;
        private System.Windows.Forms.Label lbl_doctor_display_name;
        private System.Windows.Forms.Label lbl_doctor_display__id;
        private System.Windows.Forms.Button btn_doctor_display_exit;
        private System.Windows.Forms.Button btn_doctor_display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
    }
}