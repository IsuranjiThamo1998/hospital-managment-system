
namespace GUI__group_final_project
{
    partial class Patient_info_update
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
            this.cmb_patient_update_bloodgroup = new System.Windows.Forms.ComboBox();
            this.lbl_patient_update_bloodgroup = new System.Windows.Forms.Label();
            this.dgv_patient_update = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_patient_update_admitdate = new System.Windows.Forms.Label();
            this.cmb_patient__update_gender = new System.Windows.Forms.ComboBox();
            this.txt_patient_update_ststusofdisease = new System.Windows.Forms.TextBox();
            this.txt_patient_update_disease = new System.Windows.Forms.TextBox();
            this.txt_patient_update_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_patient__update_address = new System.Windows.Forms.TextBox();
            this.txt_patient_update_age = new System.Windows.Forms.TextBox();
            this.txt_patient_update_name = new System.Windows.Forms.TextBox();
            this.lbl_update_statusofdisease = new System.Windows.Forms.Label();
            this.txt_patient_update_id = new System.Windows.Forms.TextBox();
            this.lbl_update_diseases = new System.Windows.Forms.Label();
            this.btn_patient_update_exit = new System.Windows.Forms.Button();
            this.btn_patient_update_clear = new System.Windows.Forms.Button();
            this.btn_patient_update = new System.Windows.Forms.Button();
            this.lbl_patient_update_address = new System.Windows.Forms.Label();
            this.lbl_patient_update_phonenumber = new System.Windows.Forms.Label();
            this.lbl_patient_update_age = new System.Windows.Forms.Label();
            this.lbl_patient_update_gender = new System.Windows.Forms.Label();
            this.lbl_patient_update_name = new System.Windows.Forms.Label();
            this.lbl_patient_update_id = new System.Windows.Forms.Label();
            this.txt_patient_update_roomno = new System.Windows.Forms.TextBox();
            this.lbl_patient_update_roomno = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dtp_patient_update = new System.Windows.Forms.DateTimePicker();
            this.errorProvider_patient_update = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_update)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_patient_update_bloodgroup
            // 
            this.cmb_patient_update_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient_update_bloodgroup.FormattingEnabled = true;
            this.cmb_patient_update_bloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmb_patient_update_bloodgroup.Location = new System.Drawing.Point(308, 391);
            this.cmb_patient_update_bloodgroup.Name = "cmb_patient_update_bloodgroup";
            this.cmb_patient_update_bloodgroup.Size = new System.Drawing.Size(231, 28);
            this.cmb_patient_update_bloodgroup.TabIndex = 78;
            this.cmb_patient_update_bloodgroup.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_patient_update_bloodgroup_Validating);
            // 
            // lbl_patient_update_bloodgroup
            // 
            this.lbl_patient_update_bloodgroup.AutoSize = true;
            this.lbl_patient_update_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_bloodgroup.Location = new System.Drawing.Point(69, 395);
            this.lbl_patient_update_bloodgroup.Name = "lbl_patient_update_bloodgroup";
            this.lbl_patient_update_bloodgroup.Size = new System.Drawing.Size(114, 20);
            this.lbl_patient_update_bloodgroup.TabIndex = 77;
            this.lbl_patient_update_bloodgroup.Text = "Blood Group";
            // 
            // dgv_patient_update
            // 
            this.dgv_patient_update.BackgroundColor = System.Drawing.Color.White;
            this.dgv_patient_update.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_patient_update.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_patient_update.ColumnHeadersHeight = 30;
            this.dgv_patient_update.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_patient_update.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_patient_update.GridColor = System.Drawing.Color.Black;
            this.dgv_patient_update.Location = new System.Drawing.Point(675, 119);
            this.dgv_patient_update.Name = "dgv_patient_update";
            this.dgv_patient_update.RowHeadersWidth = 24;
            this.dgv_patient_update.RowTemplate.Height = 24;
            this.dgv_patient_update.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patient_update.Size = new System.Drawing.Size(624, 540);
            this.dgv_patient_update.TabIndex = 76;
            this.dgv_patient_update.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patient_update_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(12, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1287, 55);
            this.textBox1.TabIndex = 75;
            this.textBox1.Text = "Patient Info Update";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_patient_update_admitdate
            // 
            this.lbl_patient_update_admitdate.AutoSize = true;
            this.lbl_patient_update_admitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_admitdate.Location = new System.Drawing.Point(69, 141);
            this.lbl_patient_update_admitdate.Name = "lbl_patient_update_admitdate";
            this.lbl_patient_update_admitdate.Size = new System.Drawing.Size(103, 20);
            this.lbl_patient_update_admitdate.TabIndex = 73;
            this.lbl_patient_update_admitdate.Text = "Admit Date";
            // 
            // cmb_patient__update_gender
            // 
            this.cmb_patient__update_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient__update_gender.FormattingEnabled = true;
            this.cmb_patient__update_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_patient__update_gender.Location = new System.Drawing.Point(308, 224);
            this.cmb_patient__update_gender.Name = "cmb_patient__update_gender";
            this.cmb_patient__update_gender.Size = new System.Drawing.Size(231, 28);
            this.cmb_patient__update_gender.TabIndex = 72;
            this.cmb_patient__update_gender.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_patient__update_gender_Validating);
            // 
            // txt_patient_update_ststusofdisease
            // 
            this.txt_patient_update_ststusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_update_ststusofdisease.Location = new System.Drawing.Point(308, 517);
            this.txt_patient_update_ststusofdisease.Name = "txt_patient_update_ststusofdisease";
            this.txt_patient_update_ststusofdisease.Size = new System.Drawing.Size(231, 27);
            this.txt_patient_update_ststusofdisease.TabIndex = 71;
            // 
            // txt_patient_update_disease
            // 
            this.txt_patient_update_disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_update_disease.Location = new System.Drawing.Point(308, 474);
            this.txt_patient_update_disease.Name = "txt_patient_update_disease";
            this.txt_patient_update_disease.Size = new System.Drawing.Size(231, 27);
            this.txt_patient_update_disease.TabIndex = 70;
            // 
            // txt_patient_update_phonenumber
            // 
            this.txt_patient_update_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_update_phonenumber.Location = new System.Drawing.Point(308, 352);
            this.txt_patient_update_phonenumber.Name = "txt_patient_update_phonenumber";
            this.txt_patient_update_phonenumber.Size = new System.Drawing.Size(231, 27);
            this.txt_patient_update_phonenumber.TabIndex = 69;
            this.txt_patient_update_phonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_update_phonenumber_Validating);
            // 
            // txt_patient__update_address
            // 
            this.txt_patient__update_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient__update_address.Location = new System.Drawing.Point(308, 307);
            this.txt_patient__update_address.Name = "txt_patient__update_address";
            this.txt_patient__update_address.Size = new System.Drawing.Size(231, 27);
            this.txt_patient__update_address.TabIndex = 68;
            // 
            // txt_patient_update_age
            // 
            this.txt_patient_update_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_update_age.Location = new System.Drawing.Point(308, 268);
            this.txt_patient_update_age.Name = "txt_patient_update_age";
            this.txt_patient_update_age.Size = new System.Drawing.Size(231, 27);
            this.txt_patient_update_age.TabIndex = 67;
            this.txt_patient_update_age.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_update_age_Validating);
            // 
            // txt_patient_update_name
            // 
            this.txt_patient_update_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_update_name.Location = new System.Drawing.Point(308, 183);
            this.txt_patient_update_name.Name = "txt_patient_update_name";
            this.txt_patient_update_name.Size = new System.Drawing.Size(231, 27);
            this.txt_patient_update_name.TabIndex = 66;
            this.txt_patient_update_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_update_name_Validating);
            // 
            // lbl_update_statusofdisease
            // 
            this.lbl_update_statusofdisease.AutoSize = true;
            this.lbl_update_statusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update_statusofdisease.Location = new System.Drawing.Point(69, 519);
            this.lbl_update_statusofdisease.Name = "lbl_update_statusofdisease";
            this.lbl_update_statusofdisease.Size = new System.Drawing.Size(164, 20);
            this.lbl_update_statusofdisease.TabIndex = 65;
            this.lbl_update_statusofdisease.Text = "Status Of Disease";
            // 
            // txt_patient_update_id
            // 
            this.txt_patient_update_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_update_id.Location = new System.Drawing.Point(308, 89);
            this.txt_patient_update_id.Name = "txt_patient_update_id";
            this.txt_patient_update_id.Size = new System.Drawing.Size(231, 27);
            this.txt_patient_update_id.TabIndex = 64;
            this.txt_patient_update_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_update_id_Validating);
            // 
            // lbl_update_diseases
            // 
            this.lbl_update_diseases.AutoSize = true;
            this.lbl_update_diseases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update_diseases.Location = new System.Drawing.Point(69, 474);
            this.lbl_update_diseases.Name = "lbl_update_diseases";
            this.lbl_update_diseases.Size = new System.Drawing.Size(78, 20);
            this.lbl_update_diseases.TabIndex = 63;
            this.lbl_update_diseases.Text = "Disease";
            // 
            // btn_patient_update_exit
            // 
            this.btn_patient_update_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_update_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_update_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_update_exit.Location = new System.Drawing.Point(266, 662);
            this.btn_patient_update_exit.Name = "btn_patient_update_exit";
            this.btn_patient_update_exit.Size = new System.Drawing.Size(89, 49);
            this.btn_patient_update_exit.TabIndex = 62;
            this.btn_patient_update_exit.Text = "Exit";
            this.btn_patient_update_exit.UseVisualStyleBackColor = false;
            this.btn_patient_update_exit.Click += new System.EventHandler(this.btn_patient_update_exit_Click);
            // 
            // btn_patient_update_clear
            // 
            this.btn_patient_update_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_update_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_update_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_update_clear.Location = new System.Drawing.Point(493, 585);
            this.btn_patient_update_clear.Name = "btn_patient_update_clear";
            this.btn_patient_update_clear.Size = new System.Drawing.Size(85, 49);
            this.btn_patient_update_clear.TabIndex = 61;
            this.btn_patient_update_clear.Text = "Clear";
            this.btn_patient_update_clear.UseVisualStyleBackColor = false;
            this.btn_patient_update_clear.Click += new System.EventHandler(this.btn_patient_update_clear_Click);
            // 
            // btn_patient_update
            // 
            this.btn_patient_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_update.Location = new System.Drawing.Point(55, 585);
            this.btn_patient_update.Name = "btn_patient_update";
            this.btn_patient_update.Size = new System.Drawing.Size(84, 49);
            this.btn_patient_update.TabIndex = 60;
            this.btn_patient_update.Text = "Update";
            this.btn_patient_update.UseVisualStyleBackColor = false;
            this.btn_patient_update.Click += new System.EventHandler(this.btn_patient_update_Click);
            // 
            // lbl_patient_update_address
            // 
            this.lbl_patient_update_address.AutoSize = true;
            this.lbl_patient_update_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_address.Location = new System.Drawing.Point(69, 309);
            this.lbl_patient_update_address.Name = "lbl_patient_update_address";
            this.lbl_patient_update_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_patient_update_address.TabIndex = 59;
            this.lbl_patient_update_address.Text = "Address";
            // 
            // lbl_patient_update_phonenumber
            // 
            this.lbl_patient_update_phonenumber.AutoSize = true;
            this.lbl_patient_update_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_phonenumber.Location = new System.Drawing.Point(69, 354);
            this.lbl_patient_update_phonenumber.Name = "lbl_patient_update_phonenumber";
            this.lbl_patient_update_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_patient_update_phonenumber.TabIndex = 58;
            this.lbl_patient_update_phonenumber.Text = "Phone Number";
            // 
            // lbl_patient_update_age
            // 
            this.lbl_patient_update_age.AutoSize = true;
            this.lbl_patient_update_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_age.Location = new System.Drawing.Point(69, 270);
            this.lbl_patient_update_age.Name = "lbl_patient_update_age";
            this.lbl_patient_update_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_patient_update_age.TabIndex = 57;
            this.lbl_patient_update_age.Text = "Age";
            // 
            // lbl_patient_update_gender
            // 
            this.lbl_patient_update_gender.AutoSize = true;
            this.lbl_patient_update_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_gender.Location = new System.Drawing.Point(69, 228);
            this.lbl_patient_update_gender.Name = "lbl_patient_update_gender";
            this.lbl_patient_update_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_patient_update_gender.TabIndex = 56;
            this.lbl_patient_update_gender.Text = "Gender";
            // 
            // lbl_patient_update_name
            // 
            this.lbl_patient_update_name.AutoSize = true;
            this.lbl_patient_update_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_name.Location = new System.Drawing.Point(69, 185);
            this.lbl_patient_update_name.Name = "lbl_patient_update_name";
            this.lbl_patient_update_name.Size = new System.Drawing.Size(137, 20);
            this.lbl_patient_update_name.TabIndex = 55;
            this.lbl_patient_update_name.Text = "Patient\'s Name";
            // 
            // lbl_patient_update_id
            // 
            this.lbl_patient_update_id.AutoSize = true;
            this.lbl_patient_update_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_id.Location = new System.Drawing.Point(69, 89);
            this.lbl_patient_update_id.Name = "lbl_patient_update_id";
            this.lbl_patient_update_id.Size = new System.Drawing.Size(108, 20);
            this.lbl_patient_update_id.TabIndex = 54;
            this.lbl_patient_update_id.Text = "Patient\'s ID";
            // 
            // txt_patient_update_roomno
            // 
            this.txt_patient_update_roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_update_roomno.Location = new System.Drawing.Point(308, 430);
            this.txt_patient_update_roomno.Name = "txt_patient_update_roomno";
            this.txt_patient_update_roomno.Size = new System.Drawing.Size(231, 27);
            this.txt_patient_update_roomno.TabIndex = 80;
            this.txt_patient_update_roomno.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_update_roomno_Validating);
            // 
            // lbl_patient_update_roomno
            // 
            this.lbl_patient_update_roomno.AutoSize = true;
            this.lbl_patient_update_roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_update_roomno.Location = new System.Drawing.Point(69, 432);
            this.lbl_patient_update_roomno.Name = "lbl_patient_update_roomno";
            this.lbl_patient_update_roomno.Size = new System.Drawing.Size(86, 20);
            this.lbl_patient_update_roomno.TabIndex = 79;
            this.lbl_patient_update_roomno.Text = "Room No";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(205, 585);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 49);
            this.btnView.TabIndex = 81;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dtp_patient_update
            // 
            this.dtp_patient_update.CustomFormat = "dd-MM-yyyy";
            this.dtp_patient_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_patient_update.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_patient_update.Location = new System.Drawing.Point(308, 139);
            this.dtp_patient_update.Name = "dtp_patient_update";
            this.dtp_patient_update.Size = new System.Drawing.Size(231, 27);
            this.dtp_patient_update.TabIndex = 82;
            this.dtp_patient_update.Value = new System.DateTime(2021, 5, 19, 2, 27, 11, 0);
            // 
            // errorProvider_patient_update
            // 
            this.errorProvider_patient_update.ContainerControl = this;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(347, 585);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 49);
            this.btn_search.TabIndex = 83;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Patient_info_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 748);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_patient_update);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txt_patient_update_roomno);
            this.Controls.Add(this.lbl_patient_update_roomno);
            this.Controls.Add(this.cmb_patient_update_bloodgroup);
            this.Controls.Add(this.lbl_patient_update_bloodgroup);
            this.Controls.Add(this.dgv_patient_update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_patient_update_admitdate);
            this.Controls.Add(this.cmb_patient__update_gender);
            this.Controls.Add(this.txt_patient_update_ststusofdisease);
            this.Controls.Add(this.txt_patient_update_disease);
            this.Controls.Add(this.txt_patient_update_phonenumber);
            this.Controls.Add(this.txt_patient__update_address);
            this.Controls.Add(this.txt_patient_update_age);
            this.Controls.Add(this.txt_patient_update_name);
            this.Controls.Add(this.lbl_update_statusofdisease);
            this.Controls.Add(this.txt_patient_update_id);
            this.Controls.Add(this.lbl_update_diseases);
            this.Controls.Add(this.btn_patient_update_exit);
            this.Controls.Add(this.btn_patient_update_clear);
            this.Controls.Add(this.btn_patient_update);
            this.Controls.Add(this.lbl_patient_update_address);
            this.Controls.Add(this.lbl_patient_update_phonenumber);
            this.Controls.Add(this.lbl_patient_update_age);
            this.Controls.Add(this.lbl_patient_update_gender);
            this.Controls.Add(this.lbl_patient_update_name);
            this.Controls.Add(this.lbl_patient_update_id);
            this.Name = "Patient_info_update";
            this.Text = "Patient Info Update";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_patient_update_bloodgroup;
        private System.Windows.Forms.Label lbl_patient_update_bloodgroup;
        private System.Windows.Forms.DataGridView dgv_patient_update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_patient_update_admitdate;
        private System.Windows.Forms.ComboBox cmb_patient__update_gender;
        private System.Windows.Forms.TextBox txt_patient_update_ststusofdisease;
        private System.Windows.Forms.TextBox txt_patient_update_disease;
        private System.Windows.Forms.TextBox txt_patient_update_phonenumber;
        private System.Windows.Forms.TextBox txt_patient__update_address;
        private System.Windows.Forms.TextBox txt_patient_update_age;
        private System.Windows.Forms.TextBox txt_patient_update_name;
        private System.Windows.Forms.Label lbl_update_statusofdisease;
        private System.Windows.Forms.TextBox txt_patient_update_id;
        private System.Windows.Forms.Label lbl_update_diseases;
        private System.Windows.Forms.Button btn_patient_update_exit;
        private System.Windows.Forms.Button btn_patient_update_clear;
        private System.Windows.Forms.Button btn_patient_update;
        private System.Windows.Forms.Label lbl_patient_update_address;
        private System.Windows.Forms.Label lbl_patient_update_phonenumber;
        private System.Windows.Forms.Label lbl_patient_update_age;
        private System.Windows.Forms.Label lbl_patient_update_gender;
        private System.Windows.Forms.Label lbl_patient_update_name;
        private System.Windows.Forms.Label lbl_patient_update_id;
        private System.Windows.Forms.TextBox txt_patient_update_roomno;
        private System.Windows.Forms.Label lbl_patient_update_roomno;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtp_patient_update;
        private System.Windows.Forms.ErrorProvider errorProvider_patient_update;
        private System.Windows.Forms.Button btn_search;
    }
}