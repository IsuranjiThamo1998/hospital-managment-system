
namespace GUI__group_final_project
{
    partial class Doctor_info_update
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_doctor_update = new System.Windows.Forms.DataGridView();
            this.lbl_doctor_update_date = new System.Windows.Forms.Label();
            this.cmb_doctor_update_gender = new System.Windows.Forms.ComboBox();
            this.txt_update_email = new System.Windows.Forms.TextBox();
            this.txt_update_specialization = new System.Windows.Forms.TextBox();
            this.txt_doctor_update_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_doctor_update_address = new System.Windows.Forms.TextBox();
            this.txt_doctor_update_age = new System.Windows.Forms.TextBox();
            this.txt_doctor_update_name = new System.Windows.Forms.TextBox();
            this.lbl_update_email = new System.Windows.Forms.Label();
            this.txt_doctor_update_id = new System.Windows.Forms.TextBox();
            this.lbl_update_specialization = new System.Windows.Forms.Label();
            this.lbl_doctor_update_address = new System.Windows.Forms.Label();
            this.lbl_doctor_update_phonenumber = new System.Windows.Forms.Label();
            this.lbl_doctor_update_age = new System.Windows.Forms.Label();
            this.lbl_doctor_update_gender = new System.Windows.Forms.Label();
            this.lbl_doctor_update_name = new System.Windows.Forms.Label();
            this.lbl_doctor_update_id = new System.Windows.Forms.Label();
            this.btn_doctor_update_exit = new System.Windows.Forms.Button();
            this.btn_doctor__update_clear = new System.Windows.Forms.Button();
            this.btn_doctor_update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dtp_doctor_update_date = new System.Windows.Forms.DateTimePicker();
            this.errorProvider_doc_update = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doc_update)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_doctor_update
            // 
            this.dgv_doctor_update.BackgroundColor = System.Drawing.Color.White;
            this.dgv_doctor_update.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doctor_update.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_doctor_update.ColumnHeadersHeight = 30;
            this.dgv_doctor_update.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doctor_update.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_doctor_update.GridColor = System.Drawing.Color.Black;
            this.dgv_doctor_update.Location = new System.Drawing.Point(609, 135);
            this.dgv_doctor_update.Name = "dgv_doctor_update";
            this.dgv_doctor_update.RowHeadersWidth = 24;
            this.dgv_doctor_update.RowTemplate.Height = 24;
            this.dgv_doctor_update.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doctor_update.Size = new System.Drawing.Size(614, 508);
            this.dgv_doctor_update.TabIndex = 93;
            this.dgv_doctor_update.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doctor_update_CellClick);
            // 
            // lbl_doctor_update_date
            // 
            this.lbl_doctor_update_date.AutoSize = true;
            this.lbl_doctor_update_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_update_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_update_date.Location = new System.Drawing.Point(60, 189);
            this.lbl_doctor_update_date.Name = "lbl_doctor_update_date";
            this.lbl_doctor_update_date.Size = new System.Drawing.Size(126, 20);
            this.lbl_doctor_update_date.TabIndex = 91;
            this.lbl_doctor_update_date.Text = "Register Date";
            // 
            // cmb_doctor_update_gender
            // 
            this.cmb_doctor_update_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_doctor_update_gender.FormattingEnabled = true;
            this.cmb_doctor_update_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_doctor_update_gender.Location = new System.Drawing.Point(306, 271);
            this.cmb_doctor_update_gender.Name = "cmb_doctor_update_gender";
            this.cmb_doctor_update_gender.Size = new System.Drawing.Size(236, 28);
            this.cmb_doctor_update_gender.TabIndex = 90;
            this.cmb_doctor_update_gender.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // txt_update_email
            // 
            this.txt_update_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_email.Location = new System.Drawing.Point(306, 450);
            this.txt_update_email.Name = "txt_update_email";
            this.txt_update_email.Size = new System.Drawing.Size(236, 27);
            this.txt_update_email.TabIndex = 89;
            this.txt_update_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // txt_update_specialization
            // 
            this.txt_update_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_specialization.Location = new System.Drawing.Point(306, 500);
            this.txt_update_specialization.Name = "txt_update_specialization";
            this.txt_update_specialization.Size = new System.Drawing.Size(236, 27);
            this.txt_update_specialization.TabIndex = 88;
            this.txt_update_specialization.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // txt_doctor_update_phonenumber
            // 
            this.txt_doctor_update_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_update_phonenumber.Location = new System.Drawing.Point(306, 404);
            this.txt_doctor_update_phonenumber.Name = "txt_doctor_update_phonenumber";
            this.txt_doctor_update_phonenumber.Size = new System.Drawing.Size(236, 27);
            this.txt_doctor_update_phonenumber.TabIndex = 87;
            this.txt_doctor_update_phonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // txt_doctor_update_address
            // 
            this.txt_doctor_update_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_update_address.Location = new System.Drawing.Point(306, 359);
            this.txt_doctor_update_address.Name = "txt_doctor_update_address";
            this.txt_doctor_update_address.Size = new System.Drawing.Size(236, 27);
            this.txt_doctor_update_address.TabIndex = 86;
            this.txt_doctor_update_address.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // txt_doctor_update_age
            // 
            this.txt_doctor_update_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_update_age.Location = new System.Drawing.Point(306, 321);
            this.txt_doctor_update_age.Name = "txt_doctor_update_age";
            this.txt_doctor_update_age.Size = new System.Drawing.Size(236, 27);
            this.txt_doctor_update_age.TabIndex = 85;
            this.txt_doctor_update_age.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // txt_doctor_update_name
            // 
            this.txt_doctor_update_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_update_name.Location = new System.Drawing.Point(306, 233);
            this.txt_doctor_update_name.Name = "txt_doctor_update_name";
            this.txt_doctor_update_name.Size = new System.Drawing.Size(236, 27);
            this.txt_doctor_update_name.TabIndex = 84;
            this.txt_doctor_update_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // lbl_update_email
            // 
            this.lbl_update_email.AutoSize = true;
            this.lbl_update_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_update_email.Location = new System.Drawing.Point(60, 452);
            this.lbl_update_email.Name = "lbl_update_email";
            this.lbl_update_email.Size = new System.Drawing.Size(63, 20);
            this.lbl_update_email.TabIndex = 83;
            this.lbl_update_email.Text = "E-mail";
            // 
            // txt_doctor_update_id
            // 
            this.txt_doctor_update_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_update_id.Location = new System.Drawing.Point(306, 141);
            this.txt_doctor_update_id.Name = "txt_doctor_update_id";
            this.txt_doctor_update_id.Size = new System.Drawing.Size(236, 27);
            this.txt_doctor_update_id.TabIndex = 82;
            this.txt_doctor_update_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // lbl_update_specialization
            // 
            this.lbl_update_specialization.AutoSize = true;
            this.lbl_update_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update_specialization.ForeColor = System.Drawing.Color.Black;
            this.lbl_update_specialization.Location = new System.Drawing.Point(60, 502);
            this.lbl_update_specialization.Name = "lbl_update_specialization";
            this.lbl_update_specialization.Size = new System.Drawing.Size(127, 20);
            this.lbl_update_specialization.TabIndex = 81;
            this.lbl_update_specialization.Text = "Specialization";
            // 
            // lbl_doctor_update_address
            // 
            this.lbl_doctor_update_address.AutoSize = true;
            this.lbl_doctor_update_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_update_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_update_address.Location = new System.Drawing.Point(60, 361);
            this.lbl_doctor_update_address.Name = "lbl_doctor_update_address";
            this.lbl_doctor_update_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_doctor_update_address.TabIndex = 80;
            this.lbl_doctor_update_address.Text = "Address";
            // 
            // lbl_doctor_update_phonenumber
            // 
            this.lbl_doctor_update_phonenumber.AutoSize = true;
            this.lbl_doctor_update_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_update_phonenumber.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_update_phonenumber.Location = new System.Drawing.Point(60, 406);
            this.lbl_doctor_update_phonenumber.Name = "lbl_doctor_update_phonenumber";
            this.lbl_doctor_update_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_doctor_update_phonenumber.TabIndex = 79;
            this.lbl_doctor_update_phonenumber.Text = "Phone Number";
            // 
            // lbl_doctor_update_age
            // 
            this.lbl_doctor_update_age.AutoSize = true;
            this.lbl_doctor_update_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_update_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_update_age.Location = new System.Drawing.Point(60, 323);
            this.lbl_doctor_update_age.Name = "lbl_doctor_update_age";
            this.lbl_doctor_update_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_doctor_update_age.TabIndex = 78;
            this.lbl_doctor_update_age.Text = "Age";
            // 
            // lbl_doctor_update_gender
            // 
            this.lbl_doctor_update_gender.AutoSize = true;
            this.lbl_doctor_update_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_update_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_update_gender.Location = new System.Drawing.Point(60, 275);
            this.lbl_doctor_update_gender.Name = "lbl_doctor_update_gender";
            this.lbl_doctor_update_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_doctor_update_gender.TabIndex = 77;
            this.lbl_doctor_update_gender.Text = "Gender";
            // 
            // lbl_doctor_update_name
            // 
            this.lbl_doctor_update_name.AutoSize = true;
            this.lbl_doctor_update_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_update_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_update_name.Location = new System.Drawing.Point(60, 235);
            this.lbl_doctor_update_name.Name = "lbl_doctor_update_name";
            this.lbl_doctor_update_name.Size = new System.Drawing.Size(135, 20);
            this.lbl_doctor_update_name.TabIndex = 76;
            this.lbl_doctor_update_name.Text = "Doctor\'s Name";
            // 
            // lbl_doctor_update_id
            // 
            this.lbl_doctor_update_id.AutoSize = true;
            this.lbl_doctor_update_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_update_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_update_id.Location = new System.Drawing.Point(60, 145);
            this.lbl_doctor_update_id.Name = "lbl_doctor_update_id";
            this.lbl_doctor_update_id.Size = new System.Drawing.Size(106, 20);
            this.lbl_doctor_update_id.TabIndex = 75;
            this.lbl_doctor_update_id.Text = "Doctor\'s ID";
            // 
            // btn_doctor_update_exit
            // 
            this.btn_doctor_update_exit.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_update_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_update_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_update_exit.Location = new System.Drawing.Point(251, 661);
            this.btn_doctor_update_exit.Name = "btn_doctor_update_exit";
            this.btn_doctor_update_exit.Size = new System.Drawing.Size(88, 49);
            this.btn_doctor_update_exit.TabIndex = 74;
            this.btn_doctor_update_exit.Text = "Exit";
            this.btn_doctor_update_exit.UseVisualStyleBackColor = false;
            this.btn_doctor_update_exit.Click += new System.EventHandler(this.btn_doctor_update_exit_Click);
            // 
            // btn_doctor__update_clear
            // 
            this.btn_doctor__update_clear.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor__update_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor__update_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor__update_clear.Location = new System.Drawing.Point(452, 582);
            this.btn_doctor__update_clear.Name = "btn_doctor__update_clear";
            this.btn_doctor__update_clear.Size = new System.Drawing.Size(90, 49);
            this.btn_doctor__update_clear.TabIndex = 73;
            this.btn_doctor__update_clear.Text = "Clear";
            this.btn_doctor__update_clear.UseVisualStyleBackColor = false;
            this.btn_doctor__update_clear.Click += new System.EventHandler(this.btn_doctor__update_clear_Click);
            // 
            // btn_doctor_update
            // 
            this.btn_doctor_update.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_update.Location = new System.Drawing.Point(64, 581);
            this.btn_doctor_update.Name = "btn_doctor_update";
            this.btn_doctor_update.Size = new System.Drawing.Size(87, 49);
            this.btn_doctor_update.TabIndex = 72;
            this.btn_doctor_update.Text = "Update";
            this.btn_doctor_update.UseVisualStyleBackColor = false;
            this.btn_doctor_update.Click += new System.EventHandler(this.btn_doctor_update_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(33, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1190, 68);
            this.button2.TabIndex = 95;
            this.button2.Text = "Doctor Info Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Purple;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_view.Location = new System.Drawing.Point(321, 582);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(88, 49);
            this.btn_view.TabIndex = 98;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dtp_doctor_update_date
            // 
            this.dtp_doctor_update_date.CustomFormat = "dd/MM/yyyy";
            this.dtp_doctor_update_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_doctor_update_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_doctor_update_date.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_doctor_update_date.Location = new System.Drawing.Point(306, 189);
            this.dtp_doctor_update_date.Name = "dtp_doctor_update_date";
            this.dtp_doctor_update_date.Size = new System.Drawing.Size(236, 27);
            this.dtp_doctor_update_date.TabIndex = 99;
            this.dtp_doctor_update_date.Value = new System.DateTime(2021, 5, 19, 1, 17, 13, 0);
            this.dtp_doctor_update_date.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_update_age_Validating);
            // 
            // errorProvider_doc_update
            // 
            this.errorProvider_doc_update.ContainerControl = this;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Purple;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(189, 582);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 46);
            this.btn_search.TabIndex = 137;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Doctor_info_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 755);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_doctor_update_date);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_doctor_update);
            this.Controls.Add(this.lbl_doctor_update_date);
            this.Controls.Add(this.cmb_doctor_update_gender);
            this.Controls.Add(this.txt_update_email);
            this.Controls.Add(this.txt_update_specialization);
            this.Controls.Add(this.txt_doctor_update_phonenumber);
            this.Controls.Add(this.txt_doctor_update_address);
            this.Controls.Add(this.txt_doctor_update_age);
            this.Controls.Add(this.txt_doctor_update_name);
            this.Controls.Add(this.lbl_update_email);
            this.Controls.Add(this.txt_doctor_update_id);
            this.Controls.Add(this.lbl_update_specialization);
            this.Controls.Add(this.lbl_doctor_update_address);
            this.Controls.Add(this.lbl_doctor_update_phonenumber);
            this.Controls.Add(this.lbl_doctor_update_age);
            this.Controls.Add(this.lbl_doctor_update_gender);
            this.Controls.Add(this.lbl_doctor_update_name);
            this.Controls.Add(this.lbl_doctor_update_id);
            this.Controls.Add(this.btn_doctor_update_exit);
            this.Controls.Add(this.btn_doctor__update_clear);
            this.Controls.Add(this.btn_doctor_update);
            this.Name = "Doctor_info_update";
            this.Text = "Doctor Info Update";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doc_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_doctor_update;
        private System.Windows.Forms.Label lbl_doctor_update_date;
        private System.Windows.Forms.ComboBox cmb_doctor_update_gender;
        private System.Windows.Forms.TextBox txt_update_email;
        private System.Windows.Forms.TextBox txt_update_specialization;
        private System.Windows.Forms.TextBox txt_doctor_update_phonenumber;
        private System.Windows.Forms.TextBox txt_doctor_update_address;
        private System.Windows.Forms.TextBox txt_doctor_update_age;
        private System.Windows.Forms.TextBox txt_doctor_update_name;
        private System.Windows.Forms.Label lbl_update_email;
        private System.Windows.Forms.TextBox txt_doctor_update_id;
        private System.Windows.Forms.Label lbl_update_specialization;
        private System.Windows.Forms.Label lbl_doctor_update_address;
        private System.Windows.Forms.Label lbl_doctor_update_phonenumber;
        private System.Windows.Forms.Label lbl_doctor_update_age;
        private System.Windows.Forms.Label lbl_doctor_update_gender;
        private System.Windows.Forms.Label lbl_doctor_update_name;
        private System.Windows.Forms.Label lbl_doctor_update_id;
        private System.Windows.Forms.Button btn_doctor_update_exit;
        private System.Windows.Forms.Button btn_doctor__update_clear;
        private System.Windows.Forms.Button btn_doctor_update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DateTimePicker dtp_doctor_update_date;
        private System.Windows.Forms.ErrorProvider errorProvider_doc_update;
        private System.Windows.Forms.Button btn_search;
    }
}