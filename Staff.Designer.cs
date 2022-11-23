
namespace GUI__group_final_project
{
    partial class Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_staff_name = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.lbl_staff__date = new System.Windows.Forms.Label();
            this.cmb_staff_gender = new System.Windows.Forms.ComboBox();
            this.txt_staff_email = new System.Windows.Forms.TextBox();
            this.txt_staff_salary = new System.Windows.Forms.TextBox();
            this.txt_staff_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_staff_address = new System.Windows.Forms.TextBox();
            this.txt_staff_age = new System.Windows.Forms.TextBox();
            this.txt_staff_name = new System.Windows.Forms.TextBox();
            this.lbl_staff_email = new System.Windows.Forms.Label();
            this.txt_staff_id = new System.Windows.Forms.TextBox();
            this.lbl_staff_position = new System.Windows.Forms.Label();
            this.lbl_staff_address = new System.Windows.Forms.Label();
            this.lbl_staff_phonenumber = new System.Windows.Forms.Label();
            this.lbl_staff_age = new System.Windows.Forms.Label();
            this.lbl_staff_gender = new System.Windows.Forms.Label();
            this.lbl_staff_id = new System.Windows.Forms.Label();
            this.btn_staff_exit = new System.Windows.Forms.Button();
            this.btn_staff_clear = new System.Windows.Forms.Button();
            this.btn_staff_save = new System.Windows.Forms.Button();
            this.lbl_staff_salary = new System.Windows.Forms.Label();
            this.cmb_staff_position = new System.Windows.Forms.ComboBox();
            this.btn_staff_delete = new System.Windows.Forms.Button();
            this.btn_staff_update = new System.Windows.Forms.Button();
            this.btn_staff_display = new System.Windows.Forms.Button();
            this.dateTimePicker_staff = new System.Windows.Forms.DateTimePicker();
            this.btn_staff_search = new System.Windows.Forms.Button();
            this.errorProvider_staff = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(17, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1244, 61);
            this.button1.TabIndex = 158;
            this.button1.Text = "Staff Information";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_staff_name
            // 
            this.lbl_staff_name.AutoSize = true;
            this.lbl_staff_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_name.Location = new System.Drawing.Point(72, 176);
            this.lbl_staff_name.Name = "lbl_staff_name";
            this.lbl_staff_name.Size = new System.Drawing.Size(57, 20);
            this.lbl_staff_name.TabIndex = 157;
            this.lbl_staff_name.Text = "Name";
            // 
            // dgv_staff
            // 
            this.dgv_staff.BackgroundColor = System.Drawing.Color.White;
            this.dgv_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_staff.ColumnHeadersHeight = 30;
            this.dgv_staff.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_staff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_staff.GridColor = System.Drawing.Color.Black;
            this.dgv_staff.Location = new System.Drawing.Point(625, 127);
            this.dgv_staff.Name = "dgv_staff";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_staff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_staff.RowHeadersWidth = 30;
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staff.Size = new System.Drawing.Size(636, 534);
            this.dgv_staff.TabIndex = 156;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            // 
            // lbl_staff__date
            // 
            this.lbl_staff__date.AutoSize = true;
            this.lbl_staff__date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff__date.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff__date.Location = new System.Drawing.Point(72, 132);
            this.lbl_staff__date.Name = "lbl_staff__date";
            this.lbl_staff__date.Size = new System.Drawing.Size(126, 20);
            this.lbl_staff__date.TabIndex = 154;
            this.lbl_staff__date.Text = "Register Date";
            // 
            // cmb_staff_gender
            // 
            this.cmb_staff_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_staff_gender.FormattingEnabled = true;
            this.cmb_staff_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_staff_gender.Location = new System.Drawing.Point(266, 210);
            this.cmb_staff_gender.Name = "cmb_staff_gender";
            this.cmb_staff_gender.Size = new System.Drawing.Size(232, 28);
            this.cmb_staff_gender.TabIndex = 153;
            this.cmb_staff_gender.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_staff_gender_Validating);
            // 
            // txt_staff_email
            // 
            this.txt_staff_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_email.Location = new System.Drawing.Point(266, 388);
            this.txt_staff_email.Name = "txt_staff_email";
            this.txt_staff_email.Size = new System.Drawing.Size(232, 27);
            this.txt_staff_email.TabIndex = 152;
            this.txt_staff_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staff_email_Validating);
            // 
            // txt_staff_salary
            // 
            this.txt_staff_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_salary.Location = new System.Drawing.Point(266, 468);
            this.txt_staff_salary.Name = "txt_staff_salary";
            this.txt_staff_salary.Size = new System.Drawing.Size(232, 27);
            this.txt_staff_salary.TabIndex = 151;
            // 
            // txt_staff_phonenumber
            // 
            this.txt_staff_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_phonenumber.Location = new System.Drawing.Point(266, 342);
            this.txt_staff_phonenumber.Name = "txt_staff_phonenumber";
            this.txt_staff_phonenumber.Size = new System.Drawing.Size(232, 27);
            this.txt_staff_phonenumber.TabIndex = 150;
            this.txt_staff_phonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staff_phonenumber_Validating);
            // 
            // txt_staff_address
            // 
            this.txt_staff_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_address.Location = new System.Drawing.Point(266, 297);
            this.txt_staff_address.Name = "txt_staff_address";
            this.txt_staff_address.Size = new System.Drawing.Size(232, 27);
            this.txt_staff_address.TabIndex = 149;
            this.txt_staff_address.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staff_address_Validating);
            // 
            // txt_staff_age
            // 
            this.txt_staff_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_age.Location = new System.Drawing.Point(266, 259);
            this.txt_staff_age.Name = "txt_staff_age";
            this.txt_staff_age.Size = new System.Drawing.Size(232, 27);
            this.txt_staff_age.TabIndex = 148;
            this.txt_staff_age.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staff_age_Validating);
            // 
            // txt_staff_name
            // 
            this.txt_staff_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_name.Location = new System.Drawing.Point(266, 169);
            this.txt_staff_name.Name = "txt_staff_name";
            this.txt_staff_name.Size = new System.Drawing.Size(232, 27);
            this.txt_staff_name.TabIndex = 147;
            this.txt_staff_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staff_name_Validating);
            // 
            // lbl_staff_email
            // 
            this.lbl_staff_email.AutoSize = true;
            this.lbl_staff_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_email.Location = new System.Drawing.Point(72, 395);
            this.lbl_staff_email.Name = "lbl_staff_email";
            this.lbl_staff_email.Size = new System.Drawing.Size(63, 20);
            this.lbl_staff_email.TabIndex = 146;
            this.lbl_staff_email.Text = "E-mail";
            // 
            // txt_staff_id
            // 
            this.txt_staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_id.Location = new System.Drawing.Point(266, 81);
            this.txt_staff_id.Name = "txt_staff_id";
            this.txt_staff_id.Size = new System.Drawing.Size(232, 27);
            this.txt_staff_id.TabIndex = 145;
            this.txt_staff_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staff_id_Validating);
            // 
            // lbl_staff_position
            // 
            this.lbl_staff_position.AutoSize = true;
            this.lbl_staff_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_position.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_position.Location = new System.Drawing.Point(73, 434);
            this.lbl_staff_position.Name = "lbl_staff_position";
            this.lbl_staff_position.Size = new System.Drawing.Size(77, 20);
            this.lbl_staff_position.TabIndex = 144;
            this.lbl_staff_position.Text = "Position";
            // 
            // lbl_staff_address
            // 
            this.lbl_staff_address.AutoSize = true;
            this.lbl_staff_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_address.Location = new System.Drawing.Point(72, 304);
            this.lbl_staff_address.Name = "lbl_staff_address";
            this.lbl_staff_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_staff_address.TabIndex = 143;
            this.lbl_staff_address.Text = "Address";
            // 
            // lbl_staff_phonenumber
            // 
            this.lbl_staff_phonenumber.AutoSize = true;
            this.lbl_staff_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_phonenumber.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_phonenumber.Location = new System.Drawing.Point(72, 349);
            this.lbl_staff_phonenumber.Name = "lbl_staff_phonenumber";
            this.lbl_staff_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_staff_phonenumber.TabIndex = 142;
            this.lbl_staff_phonenumber.Text = "Phone Number";
            // 
            // lbl_staff_age
            // 
            this.lbl_staff_age.AutoSize = true;
            this.lbl_staff_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_age.Location = new System.Drawing.Point(72, 266);
            this.lbl_staff_age.Name = "lbl_staff_age";
            this.lbl_staff_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_staff_age.TabIndex = 141;
            this.lbl_staff_age.Text = "Age";
            // 
            // lbl_staff_gender
            // 
            this.lbl_staff_gender.AutoSize = true;
            this.lbl_staff_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_gender.Location = new System.Drawing.Point(72, 218);
            this.lbl_staff_gender.Name = "lbl_staff_gender";
            this.lbl_staff_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_staff_gender.TabIndex = 140;
            this.lbl_staff_gender.Text = "Gender";
            // 
            // lbl_staff_id
            // 
            this.lbl_staff_id.AutoSize = true;
            this.lbl_staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_id.Location = new System.Drawing.Point(72, 88);
            this.lbl_staff_id.Name = "lbl_staff_id";
            this.lbl_staff_id.Size = new System.Drawing.Size(74, 20);
            this.lbl_staff_id.TabIndex = 139;
            this.lbl_staff_id.Text = "Staff ID";
            // 
            // btn_staff_exit
            // 
            this.btn_staff_exit.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_staff_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff_exit.Location = new System.Drawing.Point(236, 665);
            this.btn_staff_exit.Name = "btn_staff_exit";
            this.btn_staff_exit.Size = new System.Drawing.Size(94, 49);
            this.btn_staff_exit.TabIndex = 138;
            this.btn_staff_exit.Text = "Exit";
            this.btn_staff_exit.UseVisualStyleBackColor = false;
            this.btn_staff_exit.Click += new System.EventHandler(this.btn_staff_exit_Click);
            // 
            // btn_staff_clear
            // 
            this.btn_staff_clear.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_staff_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff_clear.Location = new System.Drawing.Point(395, 593);
            this.btn_staff_clear.Name = "btn_staff_clear";
            this.btn_staff_clear.Size = new System.Drawing.Size(90, 49);
            this.btn_staff_clear.TabIndex = 137;
            this.btn_staff_clear.Text = "Clear";
            this.btn_staff_clear.UseVisualStyleBackColor = false;
            this.btn_staff_clear.Click += new System.EventHandler(this.btn_staff_clear_Click);
            // 
            // btn_staff_save
            // 
            this.btn_staff_save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_staff_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff_save.Location = new System.Drawing.Point(78, 524);
            this.btn_staff_save.Name = "btn_staff_save";
            this.btn_staff_save.Size = new System.Drawing.Size(87, 49);
            this.btn_staff_save.TabIndex = 136;
            this.btn_staff_save.Text = "Save";
            this.btn_staff_save.UseVisualStyleBackColor = false;
            this.btn_staff_save.Click += new System.EventHandler(this.btn_staff_save_Click);
            // 
            // lbl_staff_salary
            // 
            this.lbl_staff_salary.AutoSize = true;
            this.lbl_staff_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_salary.ForeColor = System.Drawing.Color.Black;
            this.lbl_staff_salary.Location = new System.Drawing.Point(73, 475);
            this.lbl_staff_salary.Name = "lbl_staff_salary";
            this.lbl_staff_salary.Size = new System.Drawing.Size(62, 20);
            this.lbl_staff_salary.TabIndex = 159;
            this.lbl_staff_salary.Text = "Salary";
            // 
            // cmb_staff_position
            // 
            this.cmb_staff_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_staff_position.FormattingEnabled = true;
            this.cmb_staff_position.Items.AddRange(new object[] {
            "Nurse",
            "Attendant",
            "Pharmacist",
            "Therapist",
            "Technicians",
            "Clerk",
            "labour"});
            this.cmb_staff_position.Location = new System.Drawing.Point(266, 426);
            this.cmb_staff_position.Name = "cmb_staff_position";
            this.cmb_staff_position.Size = new System.Drawing.Size(232, 28);
            this.cmb_staff_position.TabIndex = 160;
            this.cmb_staff_position.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_staff_position_Validating);
            // 
            // btn_staff_delete
            // 
            this.btn_staff_delete.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_staff_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff_delete.Location = new System.Drawing.Point(238, 593);
            this.btn_staff_delete.Name = "btn_staff_delete";
            this.btn_staff_delete.Size = new System.Drawing.Size(94, 49);
            this.btn_staff_delete.TabIndex = 161;
            this.btn_staff_delete.Text = "Delete";
            this.btn_staff_delete.UseVisualStyleBackColor = false;
            this.btn_staff_delete.Click += new System.EventHandler(this.btn_staff_delete_Click);
            // 
            // btn_staff_update
            // 
            this.btn_staff_update.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_staff_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff_update.Location = new System.Drawing.Point(395, 524);
            this.btn_staff_update.Name = "btn_staff_update";
            this.btn_staff_update.Size = new System.Drawing.Size(90, 49);
            this.btn_staff_update.TabIndex = 162;
            this.btn_staff_update.Text = "Update";
            this.btn_staff_update.UseVisualStyleBackColor = false;
            this.btn_staff_update.Click += new System.EventHandler(this.btn_staff_update_Click);
            // 
            // btn_staff_display
            // 
            this.btn_staff_display.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_staff_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff_display.Location = new System.Drawing.Point(238, 524);
            this.btn_staff_display.Name = "btn_staff_display";
            this.btn_staff_display.Size = new System.Drawing.Size(92, 49);
            this.btn_staff_display.TabIndex = 163;
            this.btn_staff_display.Text = "Display";
            this.btn_staff_display.UseVisualStyleBackColor = false;
            this.btn_staff_display.Click += new System.EventHandler(this.btn_staff_display_Click);
            // 
            // dateTimePicker_staff
            // 
            this.dateTimePicker_staff.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_staff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_staff.Location = new System.Drawing.Point(266, 125);
            this.dateTimePicker_staff.Name = "dateTimePicker_staff";
            this.dateTimePicker_staff.Size = new System.Drawing.Size(232, 27);
            this.dateTimePicker_staff.TabIndex = 166;
            // 
            // btn_staff_search
            // 
            this.btn_staff_search.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_staff_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff_search.Location = new System.Drawing.Point(79, 593);
            this.btn_staff_search.Name = "btn_staff_search";
            this.btn_staff_search.Size = new System.Drawing.Size(86, 49);
            this.btn_staff_search.TabIndex = 167;
            this.btn_staff_search.Text = "Search";
            this.btn_staff_search.UseVisualStyleBackColor = false;
            this.btn_staff_search.Click += new System.EventHandler(this.btn_staff_search_Click);
            // 
            // errorProvider_staff
            // 
            this.errorProvider_staff.ContainerControl = this;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 726);
            this.Controls.Add(this.btn_staff_search);
            this.Controls.Add(this.dateTimePicker_staff);
            this.Controls.Add(this.btn_staff_display);
            this.Controls.Add(this.btn_staff_update);
            this.Controls.Add(this.btn_staff_delete);
            this.Controls.Add(this.cmb_staff_position);
            this.Controls.Add(this.lbl_staff_salary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_staff_name);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.lbl_staff__date);
            this.Controls.Add(this.cmb_staff_gender);
            this.Controls.Add(this.txt_staff_email);
            this.Controls.Add(this.txt_staff_salary);
            this.Controls.Add(this.txt_staff_phonenumber);
            this.Controls.Add(this.txt_staff_address);
            this.Controls.Add(this.txt_staff_age);
            this.Controls.Add(this.txt_staff_name);
            this.Controls.Add(this.lbl_staff_email);
            this.Controls.Add(this.txt_staff_id);
            this.Controls.Add(this.lbl_staff_position);
            this.Controls.Add(this.lbl_staff_address);
            this.Controls.Add(this.lbl_staff_phonenumber);
            this.Controls.Add(this.lbl_staff_age);
            this.Controls.Add(this.lbl_staff_gender);
            this.Controls.Add(this.lbl_staff_id);
            this.Controls.Add(this.btn_staff_exit);
            this.Controls.Add(this.btn_staff_clear);
            this.Controls.Add(this.btn_staff_save);
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_staff_name;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Label lbl_staff__date;
        private System.Windows.Forms.ComboBox cmb_staff_gender;
        private System.Windows.Forms.TextBox txt_staff_email;
        private System.Windows.Forms.TextBox txt_staff_salary;
        private System.Windows.Forms.TextBox txt_staff_phonenumber;
        private System.Windows.Forms.TextBox txt_staff_address;
        private System.Windows.Forms.TextBox txt_staff_age;
        private System.Windows.Forms.TextBox txt_staff_name;
        private System.Windows.Forms.Label lbl_staff_email;
        private System.Windows.Forms.TextBox txt_staff_id;
        private System.Windows.Forms.Label lbl_staff_position;
        private System.Windows.Forms.Label lbl_staff_address;
        private System.Windows.Forms.Label lbl_staff_phonenumber;
        private System.Windows.Forms.Label lbl_staff_age;
        private System.Windows.Forms.Label lbl_staff_gender;
        private System.Windows.Forms.Label lbl_staff_id;
        private System.Windows.Forms.Button btn_staff_exit;
        private System.Windows.Forms.Button btn_staff_clear;
        private System.Windows.Forms.Button btn_staff_save;
        private System.Windows.Forms.Label lbl_staff_salary;
        private System.Windows.Forms.ComboBox cmb_staff_position;
        private System.Windows.Forms.Button btn_staff_delete;
        private System.Windows.Forms.Button btn_staff_update;
        private System.Windows.Forms.Button btn_staff_display;
        private System.Windows.Forms.DateTimePicker dateTimePicker_staff;
        private System.Windows.Forms.Button btn_staff_search;
        private System.Windows.Forms.ErrorProvider errorProvider_staff;
    }
}