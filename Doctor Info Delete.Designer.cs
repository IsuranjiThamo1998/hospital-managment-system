
namespace GUI__group_final_project
{
    partial class Doctor_info_delete
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_doctor_delete_clear = new System.Windows.Forms.Button();
            this.dgv_doctor_delete = new System.Windows.Forms.DataGridView();
            this.lbl_doctor__delete_date = new System.Windows.Forms.Label();
            this.cmb_doctor_delete_gender = new System.Windows.Forms.ComboBox();
            this.txt_delete_email = new System.Windows.Forms.TextBox();
            this.txt_delete_specialization = new System.Windows.Forms.TextBox();
            this.txt_doctor_delete_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_doctor_delete_address = new System.Windows.Forms.TextBox();
            this.txt_doctor_delete_age = new System.Windows.Forms.TextBox();
            this.txt_doctor_delete_name = new System.Windows.Forms.TextBox();
            this.lbl_delete_email = new System.Windows.Forms.Label();
            this.txt_doctor_delete_id = new System.Windows.Forms.TextBox();
            this.lbl_delete_specialization = new System.Windows.Forms.Label();
            this.lbl_doctor__delete_address = new System.Windows.Forms.Label();
            this.lbl_doctor_delete_phonenumber = new System.Windows.Forms.Label();
            this.lbl_doctor__delete_age = new System.Windows.Forms.Label();
            this.lbl_doctor__delete_gender = new System.Windows.Forms.Label();
            this.lbl_doctor_delete_name = new System.Windows.Forms.Label();
            this.lbl_doctor_delete_id = new System.Windows.Forms.Label();
            this.btn_doctor_delete_exit = new System.Windows.Forms.Button();
            this.btn_doctor_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dtp_doctor_delete_date = new System.Windows.Forms.DateTimePicker();
            this.errorProvider_doc_delete = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doc_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_doctor_delete_clear
            // 
            this.btn_doctor_delete_clear.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_delete_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_delete_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_delete_clear.Location = new System.Drawing.Point(444, 547);
            this.btn_doctor_delete_clear.Name = "btn_doctor_delete_clear";
            this.btn_doctor_delete_clear.Size = new System.Drawing.Size(88, 46);
            this.btn_doctor_delete_clear.TabIndex = 132;
            this.btn_doctor_delete_clear.Text = "Clear";
            this.btn_doctor_delete_clear.UseVisualStyleBackColor = false;
            this.btn_doctor_delete_clear.Click += new System.EventHandler(this.btn_doctor_delete_clear_Click);
            // 
            // dgv_doctor_delete
            // 
            this.dgv_doctor_delete.BackgroundColor = System.Drawing.Color.White;
            this.dgv_doctor_delete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_doctor_delete.ColumnHeadersHeight = 30;
            this.dgv_doctor_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doctor_delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_doctor_delete.GridColor = System.Drawing.Color.Black;
            this.dgv_doctor_delete.Location = new System.Drawing.Point(558, 122);
            this.dgv_doctor_delete.Name = "dgv_doctor_delete";
            this.dgv_doctor_delete.RowHeadersWidth = 24;
            this.dgv_doctor_delete.RowTemplate.Height = 24;
            this.dgv_doctor_delete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doctor_delete.Size = new System.Drawing.Size(643, 552);
            this.dgv_doctor_delete.TabIndex = 131;
            this.dgv_doctor_delete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doctor_delete_CellClick);
            // 
            // lbl_doctor__delete_date
            // 
            this.lbl_doctor__delete_date.AutoSize = true;
            this.lbl_doctor__delete_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__delete_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__delete_date.Location = new System.Drawing.Point(71, 170);
            this.lbl_doctor__delete_date.Name = "lbl_doctor__delete_date";
            this.lbl_doctor__delete_date.Size = new System.Drawing.Size(126, 20);
            this.lbl_doctor__delete_date.TabIndex = 129;
            this.lbl_doctor__delete_date.Text = "Register Date";
            // 
            // cmb_doctor_delete_gender
            // 
            this.cmb_doctor_delete_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_doctor_delete_gender.FormattingEnabled = true;
            this.cmb_doctor_delete_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_doctor_delete_gender.Location = new System.Drawing.Point(294, 252);
            this.cmb_doctor_delete_gender.Name = "cmb_doctor_delete_gender";
            this.cmb_doctor_delete_gender.Size = new System.Drawing.Size(224, 26);
            this.cmb_doctor_delete_gender.TabIndex = 128;
            // 
            // txt_delete_email
            // 
            this.txt_delete_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_delete_email.Location = new System.Drawing.Point(294, 431);
            this.txt_delete_email.Name = "txt_delete_email";
            this.txt_delete_email.Size = new System.Drawing.Size(224, 24);
            this.txt_delete_email.TabIndex = 127;
            // 
            // txt_delete_specialization
            // 
            this.txt_delete_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_delete_specialization.Location = new System.Drawing.Point(294, 481);
            this.txt_delete_specialization.Name = "txt_delete_specialization";
            this.txt_delete_specialization.Size = new System.Drawing.Size(224, 24);
            this.txt_delete_specialization.TabIndex = 126;
            // 
            // txt_doctor_delete_phonenumber
            // 
            this.txt_doctor_delete_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_delete_phonenumber.Location = new System.Drawing.Point(294, 385);
            this.txt_doctor_delete_phonenumber.Name = "txt_doctor_delete_phonenumber";
            this.txt_doctor_delete_phonenumber.Size = new System.Drawing.Size(224, 24);
            this.txt_doctor_delete_phonenumber.TabIndex = 125;
            // 
            // txt_doctor_delete_address
            // 
            this.txt_doctor_delete_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_delete_address.Location = new System.Drawing.Point(294, 340);
            this.txt_doctor_delete_address.Name = "txt_doctor_delete_address";
            this.txt_doctor_delete_address.Size = new System.Drawing.Size(224, 24);
            this.txt_doctor_delete_address.TabIndex = 124;
            // 
            // txt_doctor_delete_age
            // 
            this.txt_doctor_delete_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_delete_age.Location = new System.Drawing.Point(294, 302);
            this.txt_doctor_delete_age.Name = "txt_doctor_delete_age";
            this.txt_doctor_delete_age.Size = new System.Drawing.Size(224, 24);
            this.txt_doctor_delete_age.TabIndex = 123;
            // 
            // txt_doctor_delete_name
            // 
            this.txt_doctor_delete_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_delete_name.Location = new System.Drawing.Point(294, 214);
            this.txt_doctor_delete_name.Name = "txt_doctor_delete_name";
            this.txt_doctor_delete_name.Size = new System.Drawing.Size(224, 24);
            this.txt_doctor_delete_name.TabIndex = 122;
            // 
            // lbl_delete_email
            // 
            this.lbl_delete_email.AutoSize = true;
            this.lbl_delete_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_delete_email.Location = new System.Drawing.Point(71, 433);
            this.lbl_delete_email.Name = "lbl_delete_email";
            this.lbl_delete_email.Size = new System.Drawing.Size(63, 20);
            this.lbl_delete_email.TabIndex = 121;
            this.lbl_delete_email.Text = "E-mail";
            // 
            // txt_doctor_delete_id
            // 
            this.txt_doctor_delete_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_delete_id.Location = new System.Drawing.Point(294, 122);
            this.txt_doctor_delete_id.Name = "txt_doctor_delete_id";
            this.txt_doctor_delete_id.Size = new System.Drawing.Size(224, 24);
            this.txt_doctor_delete_id.TabIndex = 120;
            this.txt_doctor_delete_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_delete_id_Validating);
            // 
            // lbl_delete_specialization
            // 
            this.lbl_delete_specialization.AutoSize = true;
            this.lbl_delete_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete_specialization.ForeColor = System.Drawing.Color.Black;
            this.lbl_delete_specialization.Location = new System.Drawing.Point(71, 483);
            this.lbl_delete_specialization.Name = "lbl_delete_specialization";
            this.lbl_delete_specialization.Size = new System.Drawing.Size(127, 20);
            this.lbl_delete_specialization.TabIndex = 119;
            this.lbl_delete_specialization.Text = "Specialization";
            // 
            // lbl_doctor__delete_address
            // 
            this.lbl_doctor__delete_address.AutoSize = true;
            this.lbl_doctor__delete_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__delete_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__delete_address.Location = new System.Drawing.Point(71, 342);
            this.lbl_doctor__delete_address.Name = "lbl_doctor__delete_address";
            this.lbl_doctor__delete_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_doctor__delete_address.TabIndex = 118;
            this.lbl_doctor__delete_address.Text = "Address";
            // 
            // lbl_doctor_delete_phonenumber
            // 
            this.lbl_doctor_delete_phonenumber.AutoSize = true;
            this.lbl_doctor_delete_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_delete_phonenumber.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_delete_phonenumber.Location = new System.Drawing.Point(71, 387);
            this.lbl_doctor_delete_phonenumber.Name = "lbl_doctor_delete_phonenumber";
            this.lbl_doctor_delete_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_doctor_delete_phonenumber.TabIndex = 117;
            this.lbl_doctor_delete_phonenumber.Text = "Phone Number";
            // 
            // lbl_doctor__delete_age
            // 
            this.lbl_doctor__delete_age.AutoSize = true;
            this.lbl_doctor__delete_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__delete_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__delete_age.Location = new System.Drawing.Point(71, 304);
            this.lbl_doctor__delete_age.Name = "lbl_doctor__delete_age";
            this.lbl_doctor__delete_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_doctor__delete_age.TabIndex = 116;
            this.lbl_doctor__delete_age.Text = "Age";
            // 
            // lbl_doctor__delete_gender
            // 
            this.lbl_doctor__delete_gender.AutoSize = true;
            this.lbl_doctor__delete_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor__delete_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor__delete_gender.Location = new System.Drawing.Point(71, 256);
            this.lbl_doctor__delete_gender.Name = "lbl_doctor__delete_gender";
            this.lbl_doctor__delete_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_doctor__delete_gender.TabIndex = 115;
            this.lbl_doctor__delete_gender.Text = "Gender";
            // 
            // lbl_doctor_delete_name
            // 
            this.lbl_doctor_delete_name.AutoSize = true;
            this.lbl_doctor_delete_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_delete_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_delete_name.Location = new System.Drawing.Point(71, 216);
            this.lbl_doctor_delete_name.Name = "lbl_doctor_delete_name";
            this.lbl_doctor_delete_name.Size = new System.Drawing.Size(135, 20);
            this.lbl_doctor_delete_name.TabIndex = 114;
            this.lbl_doctor_delete_name.Text = "Doctor\'s Name";
            // 
            // lbl_doctor_delete_id
            // 
            this.lbl_doctor_delete_id.AutoSize = true;
            this.lbl_doctor_delete_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_delete_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_delete_id.Location = new System.Drawing.Point(71, 126);
            this.lbl_doctor_delete_id.Name = "lbl_doctor_delete_id";
            this.lbl_doctor_delete_id.Size = new System.Drawing.Size(106, 20);
            this.lbl_doctor_delete_id.TabIndex = 113;
            this.lbl_doctor_delete_id.Text = "Doctor\'s ID";
            // 
            // btn_doctor_delete_exit
            // 
            this.btn_doctor_delete_exit.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_delete_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_delete_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_delete_exit.Location = new System.Drawing.Point(249, 627);
            this.btn_doctor_delete_exit.Name = "btn_doctor_delete_exit";
            this.btn_doctor_delete_exit.Size = new System.Drawing.Size(88, 47);
            this.btn_doctor_delete_exit.TabIndex = 112;
            this.btn_doctor_delete_exit.Text = "Exit";
            this.btn_doctor_delete_exit.UseVisualStyleBackColor = false;
            this.btn_doctor_delete_exit.Click += new System.EventHandler(this.btn_doctor_delete_exit_Click);
            // 
            // btn_doctor_delete
            // 
            this.btn_doctor_delete.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_delete.Location = new System.Drawing.Point(75, 545);
            this.btn_doctor_delete.Name = "btn_doctor_delete";
            this.btn_doctor_delete.Size = new System.Drawing.Size(88, 50);
            this.btn_doctor_delete.TabIndex = 111;
            this.btn_doctor_delete.Text = "Delete";
            this.btn_doctor_delete.UseVisualStyleBackColor = false;
            this.btn_doctor_delete.Click += new System.EventHandler(this.btn_doctor_delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1178, 61);
            this.button1.TabIndex = 134;
            this.button1.Text = "Doctor Info Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Purple;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_view.Location = new System.Drawing.Point(318, 546);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(88, 49);
            this.btn_view.TabIndex = 135;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dtp_doctor_delete_date
            // 
            this.dtp_doctor_delete_date.CustomFormat = "dd-MM-yyyy";
            this.dtp_doctor_delete_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_doctor_delete_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_doctor_delete_date.Location = new System.Drawing.Point(294, 170);
            this.dtp_doctor_delete_date.Name = "dtp_doctor_delete_date";
            this.dtp_doctor_delete_date.Size = new System.Drawing.Size(224, 24);
            this.dtp_doctor_delete_date.TabIndex = 136;
            // 
            // errorProvider_doc_delete
            // 
            this.errorProvider_doc_delete.ContainerControl = this;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Purple;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(201, 549);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 46);
            this.btn_search.TabIndex = 138;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Doctor_info_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 686);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_doctor_delete_date);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_doctor_delete_clear);
            this.Controls.Add(this.dgv_doctor_delete);
            this.Controls.Add(this.lbl_doctor__delete_date);
            this.Controls.Add(this.cmb_doctor_delete_gender);
            this.Controls.Add(this.txt_delete_email);
            this.Controls.Add(this.txt_delete_specialization);
            this.Controls.Add(this.txt_doctor_delete_phonenumber);
            this.Controls.Add(this.txt_doctor_delete_address);
            this.Controls.Add(this.txt_doctor_delete_age);
            this.Controls.Add(this.txt_doctor_delete_name);
            this.Controls.Add(this.lbl_delete_email);
            this.Controls.Add(this.txt_doctor_delete_id);
            this.Controls.Add(this.lbl_delete_specialization);
            this.Controls.Add(this.lbl_doctor__delete_address);
            this.Controls.Add(this.lbl_doctor_delete_phonenumber);
            this.Controls.Add(this.lbl_doctor__delete_age);
            this.Controls.Add(this.lbl_doctor__delete_gender);
            this.Controls.Add(this.lbl_doctor_delete_name);
            this.Controls.Add(this.lbl_doctor_delete_id);
            this.Controls.Add(this.btn_doctor_delete_exit);
            this.Controls.Add(this.btn_doctor_delete);
            this.Name = "Doctor_info_delete";
            this.Text = "Doctor Info Delete";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doc_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doctor_delete_clear;
        private System.Windows.Forms.DataGridView dgv_doctor_delete;
        private System.Windows.Forms.Label lbl_doctor__delete_date;
        private System.Windows.Forms.ComboBox cmb_doctor_delete_gender;
        private System.Windows.Forms.TextBox txt_delete_email;
        private System.Windows.Forms.TextBox txt_delete_specialization;
        private System.Windows.Forms.TextBox txt_doctor_delete_phonenumber;
        private System.Windows.Forms.TextBox txt_doctor_delete_address;
        private System.Windows.Forms.TextBox txt_doctor_delete_age;
        private System.Windows.Forms.TextBox txt_doctor_delete_name;
        private System.Windows.Forms.Label lbl_delete_email;
        private System.Windows.Forms.TextBox txt_doctor_delete_id;
        private System.Windows.Forms.Label lbl_delete_specialization;
        private System.Windows.Forms.Label lbl_doctor__delete_address;
        private System.Windows.Forms.Label lbl_doctor_delete_phonenumber;
        private System.Windows.Forms.Label lbl_doctor__delete_age;
        private System.Windows.Forms.Label lbl_doctor__delete_gender;
        private System.Windows.Forms.Label lbl_doctor_delete_name;
        private System.Windows.Forms.Label lbl_doctor_delete_id;
        private System.Windows.Forms.Button btn_doctor_delete_exit;
        private System.Windows.Forms.Button btn_doctor_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DateTimePicker dtp_doctor_delete_date;
        private System.Windows.Forms.ErrorProvider errorProvider_doc_delete;
        private System.Windows.Forms.Button btn_search;
    }
}