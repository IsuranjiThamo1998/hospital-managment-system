
namespace GUI__group_final_project
{
    partial class Patient_Info_delete
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
            this.cmb_patient_delete_bloodgroup = new System.Windows.Forms.ComboBox();
            this.lbl_patient_delete_bloodgroup = new System.Windows.Forms.Label();
            this.dgv_patient_delete = new System.Windows.Forms.DataGridView();
            this.lbl_patient_delete_admitdate = new System.Windows.Forms.Label();
            this.txt_patient_delete_statusofdisease = new System.Windows.Forms.TextBox();
            this.txt_patient_delete_disease = new System.Windows.Forms.TextBox();
            this.txt_patient_delete_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_patient_delete_address = new System.Windows.Forms.TextBox();
            this.txt_patient_delete_age = new System.Windows.Forms.TextBox();
            this.lbl_delete_statusofdisease = new System.Windows.Forms.Label();
            this.lbl_delete_diseases = new System.Windows.Forms.Label();
            this.lbl_patient_delete_address = new System.Windows.Forms.Label();
            this.lbl_patient_delete_phonenumber = new System.Windows.Forms.Label();
            this.lbl_patient_delete_age = new System.Windows.Forms.Label();
            this.cmb_patient_delete_gender = new System.Windows.Forms.ComboBox();
            this.lbl_patient_delete_gender = new System.Windows.Forms.Label();
            this.txt_patient_delete_name = new System.Windows.Forms.TextBox();
            this.lbl_patient_delete_name = new System.Windows.Forms.Label();
            this.txt_patient_delete_id = new System.Windows.Forms.TextBox();
            this.lbl_patient_delete_id = new System.Windows.Forms.Label();
            this.btn_patient_delete_exit = new System.Windows.Forms.Button();
            this.btn_patient_delete_clear = new System.Windows.Forms.Button();
            this.btn_patient__delete = new System.Windows.Forms.Button();
            this.txt_patient_delete_roomno = new System.Windows.Forms.TextBox();
            this.lbl_patient_delete__roomno = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dtp_patient_delete = new System.Windows.Forms.DateTimePicker();
            this.errorProvider_patient_delete = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_patient_delete_bloodgroup
            // 
            this.cmb_patient_delete_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient_delete_bloodgroup.FormattingEnabled = true;
            this.cmb_patient_delete_bloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmb_patient_delete_bloodgroup.Location = new System.Drawing.Point(318, 389);
            this.cmb_patient_delete_bloodgroup.Name = "cmb_patient_delete_bloodgroup";
            this.cmb_patient_delete_bloodgroup.Size = new System.Drawing.Size(216, 28);
            this.cmb_patient_delete_bloodgroup.TabIndex = 92;
            // 
            // lbl_patient_delete_bloodgroup
            // 
            this.lbl_patient_delete_bloodgroup.AutoSize = true;
            this.lbl_patient_delete_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_bloodgroup.Location = new System.Drawing.Point(74, 393);
            this.lbl_patient_delete_bloodgroup.Name = "lbl_patient_delete_bloodgroup";
            this.lbl_patient_delete_bloodgroup.Size = new System.Drawing.Size(114, 20);
            this.lbl_patient_delete_bloodgroup.TabIndex = 91;
            this.lbl_patient_delete_bloodgroup.Text = "Blood Group";
            // 
            // dgv_patient_delete
            // 
            this.dgv_patient_delete.BackgroundColor = System.Drawing.Color.White;
            this.dgv_patient_delete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_patient_delete.ColumnHeadersHeight = 30;
            this.dgv_patient_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_patient_delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_patient_delete.GridColor = System.Drawing.Color.Black;
            this.dgv_patient_delete.Location = new System.Drawing.Point(629, 123);
            this.dgv_patient_delete.Name = "dgv_patient_delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_patient_delete.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_patient_delete.RowHeadersWidth = 24;
            this.dgv_patient_delete.RowTemplate.Height = 24;
            this.dgv_patient_delete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patient_delete.Size = new System.Drawing.Size(674, 545);
            this.dgv_patient_delete.TabIndex = 98;
            this.dgv_patient_delete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patient_delete_CellClick);
            // 
            // lbl_patient_delete_admitdate
            // 
            this.lbl_patient_delete_admitdate.AutoSize = true;
            this.lbl_patient_delete_admitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_admitdate.Location = new System.Drawing.Point(74, 123);
            this.lbl_patient_delete_admitdate.Name = "lbl_patient_delete_admitdate";
            this.lbl_patient_delete_admitdate.Size = new System.Drawing.Size(103, 20);
            this.lbl_patient_delete_admitdate.TabIndex = 88;
            this.lbl_patient_delete_admitdate.Text = "Admit Date";
            // 
            // txt_patient_delete_statusofdisease
            // 
            this.txt_patient_delete_statusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_statusofdisease.Location = new System.Drawing.Point(318, 519);
            this.txt_patient_delete_statusofdisease.Name = "txt_patient_delete_statusofdisease";
            this.txt_patient_delete_statusofdisease.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_statusofdisease.TabIndex = 87;
            // 
            // txt_patient_delete_disease
            // 
            this.txt_patient_delete_disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_disease.Location = new System.Drawing.Point(318, 476);
            this.txt_patient_delete_disease.Name = "txt_patient_delete_disease";
            this.txt_patient_delete_disease.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_disease.TabIndex = 86;
            // 
            // txt_patient_delete_phonenumber
            // 
            this.txt_patient_delete_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_phonenumber.Location = new System.Drawing.Point(318, 353);
            this.txt_patient_delete_phonenumber.Name = "txt_patient_delete_phonenumber";
            this.txt_patient_delete_phonenumber.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_phonenumber.TabIndex = 85;
            // 
            // txt_patient_delete_address
            // 
            this.txt_patient_delete_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_address.Location = new System.Drawing.Point(318, 307);
            this.txt_patient_delete_address.Name = "txt_patient_delete_address";
            this.txt_patient_delete_address.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_address.TabIndex = 84;
            // 
            // txt_patient_delete_age
            // 
            this.txt_patient_delete_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_age.Location = new System.Drawing.Point(318, 261);
            this.txt_patient_delete_age.Name = "txt_patient_delete_age";
            this.txt_patient_delete_age.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_age.TabIndex = 83;
            // 
            // lbl_delete_statusofdisease
            // 
            this.lbl_delete_statusofdisease.AutoSize = true;
            this.lbl_delete_statusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete_statusofdisease.Location = new System.Drawing.Point(74, 521);
            this.lbl_delete_statusofdisease.Name = "lbl_delete_statusofdisease";
            this.lbl_delete_statusofdisease.Size = new System.Drawing.Size(164, 20);
            this.lbl_delete_statusofdisease.TabIndex = 82;
            this.lbl_delete_statusofdisease.Text = "Status Of Disease";
            // 
            // lbl_delete_diseases
            // 
            this.lbl_delete_diseases.AutoSize = true;
            this.lbl_delete_diseases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete_diseases.Location = new System.Drawing.Point(74, 478);
            this.lbl_delete_diseases.Name = "lbl_delete_diseases";
            this.lbl_delete_diseases.Size = new System.Drawing.Size(78, 20);
            this.lbl_delete_diseases.TabIndex = 81;
            this.lbl_delete_diseases.Text = "Disease";
            // 
            // lbl_patient_delete_address
            // 
            this.lbl_patient_delete_address.AutoSize = true;
            this.lbl_patient_delete_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_address.Location = new System.Drawing.Point(74, 309);
            this.lbl_patient_delete_address.Name = "lbl_patient_delete_address";
            this.lbl_patient_delete_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_patient_delete_address.TabIndex = 80;
            this.lbl_patient_delete_address.Text = "Address";
            // 
            // lbl_patient_delete_phonenumber
            // 
            this.lbl_patient_delete_phonenumber.AutoSize = true;
            this.lbl_patient_delete_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_phonenumber.Location = new System.Drawing.Point(74, 355);
            this.lbl_patient_delete_phonenumber.Name = "lbl_patient_delete_phonenumber";
            this.lbl_patient_delete_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_patient_delete_phonenumber.TabIndex = 79;
            this.lbl_patient_delete_phonenumber.Text = "Phone Number";
            // 
            // lbl_patient_delete_age
            // 
            this.lbl_patient_delete_age.AutoSize = true;
            this.lbl_patient_delete_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_age.Location = new System.Drawing.Point(74, 261);
            this.lbl_patient_delete_age.Name = "lbl_patient_delete_age";
            this.lbl_patient_delete_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_patient_delete_age.TabIndex = 78;
            this.lbl_patient_delete_age.Text = "Age";
            // 
            // cmb_patient_delete_gender
            // 
            this.cmb_patient_delete_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient_delete_gender.FormattingEnabled = true;
            this.cmb_patient_delete_gender.Location = new System.Drawing.Point(318, 215);
            this.cmb_patient_delete_gender.Name = "cmb_patient_delete_gender";
            this.cmb_patient_delete_gender.Size = new System.Drawing.Size(216, 28);
            this.cmb_patient_delete_gender.TabIndex = 77;
            // 
            // lbl_patient_delete_gender
            // 
            this.lbl_patient_delete_gender.AutoSize = true;
            this.lbl_patient_delete_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_gender.Location = new System.Drawing.Point(74, 219);
            this.lbl_patient_delete_gender.Name = "lbl_patient_delete_gender";
            this.lbl_patient_delete_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_patient_delete_gender.TabIndex = 76;
            this.lbl_patient_delete_gender.Text = "Gender";
            // 
            // txt_patient_delete_name
            // 
            this.txt_patient_delete_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_name.Location = new System.Drawing.Point(318, 169);
            this.txt_patient_delete_name.Name = "txt_patient_delete_name";
            this.txt_patient_delete_name.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_name.TabIndex = 75;
            // 
            // lbl_patient_delete_name
            // 
            this.lbl_patient_delete_name.AutoSize = true;
            this.lbl_patient_delete_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_name.Location = new System.Drawing.Point(74, 171);
            this.lbl_patient_delete_name.Name = "lbl_patient_delete_name";
            this.lbl_patient_delete_name.Size = new System.Drawing.Size(137, 20);
            this.lbl_patient_delete_name.TabIndex = 74;
            this.lbl_patient_delete_name.Text = "Patient\'s Name";
            // 
            // txt_patient_delete_id
            // 
            this.txt_patient_delete_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_id.Location = new System.Drawing.Point(318, 81);
            this.txt_patient_delete_id.Name = "txt_patient_delete_id";
            this.txt_patient_delete_id.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_id.TabIndex = 73;
            this.txt_patient_delete_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_delete_id_Validating);
            // 
            // lbl_patient_delete_id
            // 
            this.lbl_patient_delete_id.AutoSize = true;
            this.lbl_patient_delete_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete_id.Location = new System.Drawing.Point(74, 85);
            this.lbl_patient_delete_id.Name = "lbl_patient_delete_id";
            this.lbl_patient_delete_id.Size = new System.Drawing.Size(108, 20);
            this.lbl_patient_delete_id.TabIndex = 72;
            this.lbl_patient_delete_id.Text = "Patient\'s ID";
            // 
            // btn_patient_delete_exit
            // 
            this.btn_patient_delete_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_delete_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_delete_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_delete_exit.Location = new System.Drawing.Point(253, 658);
            this.btn_patient_delete_exit.Name = "btn_patient_delete_exit";
            this.btn_patient_delete_exit.Size = new System.Drawing.Size(88, 49);
            this.btn_patient_delete_exit.TabIndex = 71;
            this.btn_patient_delete_exit.Text = "Exit";
            this.btn_patient_delete_exit.UseVisualStyleBackColor = false;
            this.btn_patient_delete_exit.Click += new System.EventHandler(this.btn_patient_delete_exit_Click);
            // 
            // btn_patient_delete_clear
            // 
            this.btn_patient_delete_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_delete_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_delete_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_delete_clear.Location = new System.Drawing.Point(466, 583);
            this.btn_patient_delete_clear.Name = "btn_patient_delete_clear";
            this.btn_patient_delete_clear.Size = new System.Drawing.Size(90, 49);
            this.btn_patient_delete_clear.TabIndex = 70;
            this.btn_patient_delete_clear.Text = "Clear";
            this.btn_patient_delete_clear.UseVisualStyleBackColor = false;
            this.btn_patient_delete_clear.Click += new System.EventHandler(this.btn_patient_delete_clear_Click);
            // 
            // btn_patient__delete
            // 
            this.btn_patient__delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient__delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient__delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient__delete.Location = new System.Drawing.Point(60, 583);
            this.btn_patient__delete.Name = "btn_patient__delete";
            this.btn_patient__delete.Size = new System.Drawing.Size(92, 49);
            this.btn_patient__delete.TabIndex = 69;
            this.btn_patient__delete.Text = "Delete";
            this.btn_patient__delete.UseVisualStyleBackColor = false;
            this.btn_patient__delete.Click += new System.EventHandler(this.btn_patient__delete_Click);
            // 
            // txt_patient_delete_roomno
            // 
            this.txt_patient_delete_roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_delete_roomno.Location = new System.Drawing.Point(318, 437);
            this.txt_patient_delete_roomno.Name = "txt_patient_delete_roomno";
            this.txt_patient_delete_roomno.Size = new System.Drawing.Size(216, 27);
            this.txt_patient_delete_roomno.TabIndex = 94;
            // 
            // lbl_patient_delete__roomno
            // 
            this.lbl_patient_delete__roomno.AutoSize = true;
            this.lbl_patient_delete__roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_delete__roomno.Location = new System.Drawing.Point(74, 439);
            this.lbl_patient_delete__roomno.Name = "lbl_patient_delete__roomno";
            this.lbl_patient_delete__roomno.Size = new System.Drawing.Size(86, 20);
            this.lbl_patient_delete__roomno.TabIndex = 93;
            this.lbl_patient_delete__roomno.Text = "Room No";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Location = new System.Drawing.Point(27, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1291, 55);
            this.textBox5.TabIndex = 95;
            this.textBox5.Text = "Patient Info Delete";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(333, 583);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 49);
            this.btnView.TabIndex = 96;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dtp_patient_delete
            // 
            this.dtp_patient_delete.CustomFormat = "dd-MM-yyyy";
            this.dtp_patient_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_patient_delete.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_patient_delete.Location = new System.Drawing.Point(318, 123);
            this.dtp_patient_delete.Name = "dtp_patient_delete";
            this.dtp_patient_delete.Size = new System.Drawing.Size(216, 27);
            this.dtp_patient_delete.TabIndex = 97;
            this.dtp_patient_delete.Value = new System.DateTime(2021, 5, 19, 3, 8, 4, 0);
            // 
            // errorProvider_patient_delete
            // 
            this.errorProvider_patient_delete.ContainerControl = this;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(196, 583);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 49);
            this.btn_search.TabIndex = 99;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Patient_Info_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 743);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_patient_delete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txt_patient_delete_roomno);
            this.Controls.Add(this.lbl_patient_delete__roomno);
            this.Controls.Add(this.cmb_patient_delete_bloodgroup);
            this.Controls.Add(this.lbl_patient_delete_bloodgroup);
            this.Controls.Add(this.dgv_patient_delete);
            this.Controls.Add(this.lbl_patient_delete_admitdate);
            this.Controls.Add(this.txt_patient_delete_statusofdisease);
            this.Controls.Add(this.txt_patient_delete_disease);
            this.Controls.Add(this.txt_patient_delete_phonenumber);
            this.Controls.Add(this.txt_patient_delete_address);
            this.Controls.Add(this.txt_patient_delete_age);
            this.Controls.Add(this.lbl_delete_statusofdisease);
            this.Controls.Add(this.lbl_delete_diseases);
            this.Controls.Add(this.lbl_patient_delete_address);
            this.Controls.Add(this.lbl_patient_delete_phonenumber);
            this.Controls.Add(this.lbl_patient_delete_age);
            this.Controls.Add(this.cmb_patient_delete_gender);
            this.Controls.Add(this.lbl_patient_delete_gender);
            this.Controls.Add(this.txt_patient_delete_name);
            this.Controls.Add(this.lbl_patient_delete_name);
            this.Controls.Add(this.txt_patient_delete_id);
            this.Controls.Add(this.lbl_patient_delete_id);
            this.Controls.Add(this.btn_patient_delete_exit);
            this.Controls.Add(this.btn_patient_delete_clear);
            this.Controls.Add(this.btn_patient__delete);
            this.Name = "Patient_Info_delete";
            this.Text = "Patient Info Delete";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_patient_delete_bloodgroup;
        private System.Windows.Forms.Label lbl_patient_delete_bloodgroup;
        private System.Windows.Forms.DataGridView dgv_patient_delete;
        private System.Windows.Forms.Label lbl_patient_delete_admitdate;
        private System.Windows.Forms.TextBox txt_patient_delete_statusofdisease;
        private System.Windows.Forms.TextBox txt_patient_delete_disease;
        private System.Windows.Forms.TextBox txt_patient_delete_phonenumber;
        private System.Windows.Forms.TextBox txt_patient_delete_address;
        private System.Windows.Forms.TextBox txt_patient_delete_age;
        private System.Windows.Forms.Label lbl_delete_statusofdisease;
        private System.Windows.Forms.Label lbl_delete_diseases;
        private System.Windows.Forms.Label lbl_patient_delete_address;
        private System.Windows.Forms.Label lbl_patient_delete_phonenumber;
        private System.Windows.Forms.Label lbl_patient_delete_age;
        private System.Windows.Forms.ComboBox cmb_patient_delete_gender;
        private System.Windows.Forms.Label lbl_patient_delete_gender;
        private System.Windows.Forms.TextBox txt_patient_delete_name;
        private System.Windows.Forms.Label lbl_patient_delete_name;
        private System.Windows.Forms.TextBox txt_patient_delete_id;
        private System.Windows.Forms.Label lbl_patient_delete_id;
        private System.Windows.Forms.Button btn_patient_delete_exit;
        private System.Windows.Forms.Button btn_patient_delete_clear;
        private System.Windows.Forms.Button btn_patient__delete;
        private System.Windows.Forms.TextBox txt_patient_delete_roomno;
        private System.Windows.Forms.Label lbl_patient_delete__roomno;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtp_patient_delete;
        private System.Windows.Forms.ErrorProvider errorProvider_patient_delete;
        private System.Windows.Forms.Button btn_search;
    }
}