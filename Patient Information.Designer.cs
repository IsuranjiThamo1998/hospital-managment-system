
namespace GUI__group_final_project
{
    partial class Patient_information
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
            this.cmb_patient_display_bloodgroup = new System.Windows.Forms.ComboBox();
            this.lbl_patient_display_bloodgroup = new System.Windows.Forms.Label();
            this.lbl_patient_display_admitdate = new System.Windows.Forms.Label();
            this.btn_patient_display_exit = new System.Windows.Forms.Button();
            this.btn_patient_display_clear = new System.Windows.Forms.Button();
            this.btn_patient_display = new System.Windows.Forms.Button();
            this.dgv_patient_display = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmb_patient_display_gender = new System.Windows.Forms.ComboBox();
            this.txt_patient_display_ststusofdisease = new System.Windows.Forms.TextBox();
            this.txt_patient_display_disease = new System.Windows.Forms.TextBox();
            this.txt_patient_display_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_patient_display_address = new System.Windows.Forms.TextBox();
            this.txt_patient_display_age = new System.Windows.Forms.TextBox();
            this.lbl_display_statusofdisease = new System.Windows.Forms.Label();
            this.lbl_display_diseases = new System.Windows.Forms.Label();
            this.lbl_patient_display_address = new System.Windows.Forms.Label();
            this.lbl_patient_display_phonenumber = new System.Windows.Forms.Label();
            this.lbl_patient_display_age = new System.Windows.Forms.Label();
            this.lbl_patient_display_gender = new System.Windows.Forms.Label();
            this.txt_patient_display_name = new System.Windows.Forms.TextBox();
            this.lbl_patient_display_name = new System.Windows.Forms.Label();
            this.txt_patient_display_id = new System.Windows.Forms.TextBox();
            this.lbl_patient_display_id = new System.Windows.Forms.Label();
            this.txt_patient_display_roomno = new System.Windows.Forms.TextBox();
            this.lbl_patient_display_roomno = new System.Windows.Forms.Label();
            this.errorProvider_patient_info = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtp_patient_info = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_info)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_patient_display_bloodgroup
            // 
            this.cmb_patient_display_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient_display_bloodgroup.FormattingEnabled = true;
            this.cmb_patient_display_bloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmb_patient_display_bloodgroup.Location = new System.Drawing.Point(297, 404);
            this.cmb_patient_display_bloodgroup.Name = "cmb_patient_display_bloodgroup";
            this.cmb_patient_display_bloodgroup.Size = new System.Drawing.Size(229, 28);
            this.cmb_patient_display_bloodgroup.TabIndex = 72;
            // 
            // lbl_patient_display_bloodgroup
            // 
            this.lbl_patient_display_bloodgroup.AutoSize = true;
            this.lbl_patient_display_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_bloodgroup.Location = new System.Drawing.Point(64, 408);
            this.lbl_patient_display_bloodgroup.Name = "lbl_patient_display_bloodgroup";
            this.lbl_patient_display_bloodgroup.Size = new System.Drawing.Size(114, 20);
            this.lbl_patient_display_bloodgroup.TabIndex = 71;
            this.lbl_patient_display_bloodgroup.Text = "Blood Group";
            // 
            // lbl_patient_display_admitdate
            // 
            this.lbl_patient_display_admitdate.AutoSize = true;
            this.lbl_patient_display_admitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_admitdate.Location = new System.Drawing.Point(64, 145);
            this.lbl_patient_display_admitdate.Name = "lbl_patient_display_admitdate";
            this.lbl_patient_display_admitdate.Size = new System.Drawing.Size(103, 20);
            this.lbl_patient_display_admitdate.TabIndex = 69;
            this.lbl_patient_display_admitdate.Text = "Admit Date";
            // 
            // btn_patient_display_exit
            // 
            this.btn_patient_display_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_display_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_display_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_display_exit.Location = new System.Drawing.Point(460, 605);
            this.btn_patient_display_exit.Name = "btn_patient_display_exit";
            this.btn_patient_display_exit.Size = new System.Drawing.Size(88, 49);
            this.btn_patient_display_exit.TabIndex = 68;
            this.btn_patient_display_exit.Text = "Exit";
            this.btn_patient_display_exit.UseVisualStyleBackColor = false;
            this.btn_patient_display_exit.Click += new System.EventHandler(this.btn_patient_display_exit_Click);
            // 
            // btn_patient_display_clear
            // 
            this.btn_patient_display_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_display_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_display_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_display_clear.Location = new System.Drawing.Point(334, 605);
            this.btn_patient_display_clear.Name = "btn_patient_display_clear";
            this.btn_patient_display_clear.Size = new System.Drawing.Size(90, 49);
            this.btn_patient_display_clear.TabIndex = 67;
            this.btn_patient_display_clear.Text = "Clear";
            this.btn_patient_display_clear.UseVisualStyleBackColor = false;
            this.btn_patient_display_clear.Click += new System.EventHandler(this.btn_patient_display_clear_Click);
            // 
            // btn_patient_display
            // 
            this.btn_patient_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_display.Location = new System.Drawing.Point(68, 605);
            this.btn_patient_display.Name = "btn_patient_display";
            this.btn_patient_display.Size = new System.Drawing.Size(92, 49);
            this.btn_patient_display.TabIndex = 66;
            this.btn_patient_display.Text = "Display";
            this.btn_patient_display.UseVisualStyleBackColor = false;
            this.btn_patient_display.Click += new System.EventHandler(this.btn_patient_display_Click);
            // 
            // dgv_patient_display
            // 
            this.dgv_patient_display.BackgroundColor = System.Drawing.Color.White;
            this.dgv_patient_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_patient_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_patient_display.ColumnHeadersHeight = 30;
            this.dgv_patient_display.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_patient_display.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_patient_display.GridColor = System.Drawing.Color.Black;
            this.dgv_patient_display.Location = new System.Drawing.Point(643, 129);
            this.dgv_patient_display.Name = "dgv_patient_display";
            this.dgv_patient_display.RowHeadersWidth = 24;
            this.dgv_patient_display.RowTemplate.Height = 24;
            this.dgv_patient_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patient_display.Size = new System.Drawing.Size(678, 511);
            this.dgv_patient_display.TabIndex = 65;
            this.dgv_patient_display.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patient_display_CellClick);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Location = new System.Drawing.Point(12, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1309, 55);
            this.textBox5.TabIndex = 64;
            this.textBox5.Text = "Patient Information";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_patient_display_gender
            // 
            this.cmb_patient_display_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient_display_gender.FormattingEnabled = true;
            this.cmb_patient_display_gender.Location = new System.Drawing.Point(297, 226);
            this.cmb_patient_display_gender.Name = "cmb_patient_display_gender";
            this.cmb_patient_display_gender.Size = new System.Drawing.Size(229, 28);
            this.cmb_patient_display_gender.TabIndex = 63;
            // 
            // txt_patient_display_ststusofdisease
            // 
            this.txt_patient_display_ststusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_ststusofdisease.Location = new System.Drawing.Point(297, 536);
            this.txt_patient_display_ststusofdisease.Name = "txt_patient_display_ststusofdisease";
            this.txt_patient_display_ststusofdisease.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_ststusofdisease.TabIndex = 62;
            // 
            // txt_patient_display_disease
            // 
            this.txt_patient_display_disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_disease.Location = new System.Drawing.Point(297, 489);
            this.txt_patient_display_disease.Name = "txt_patient_display_disease";
            this.txt_patient_display_disease.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_disease.TabIndex = 61;
            // 
            // txt_patient_display_phonenumber
            // 
            this.txt_patient_display_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_phonenumber.Location = new System.Drawing.Point(297, 365);
            this.txt_patient_display_phonenumber.Name = "txt_patient_display_phonenumber";
            this.txt_patient_display_phonenumber.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_phonenumber.TabIndex = 60;
            // 
            // txt_patient_display_address
            // 
            this.txt_patient_display_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_address.Location = new System.Drawing.Point(297, 317);
            this.txt_patient_display_address.Name = "txt_patient_display_address";
            this.txt_patient_display_address.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_address.TabIndex = 59;
            // 
            // txt_patient_display_age
            // 
            this.txt_patient_display_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_age.Location = new System.Drawing.Point(297, 271);
            this.txt_patient_display_age.Name = "txt_patient_display_age";
            this.txt_patient_display_age.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_age.TabIndex = 58;
            // 
            // lbl_display_statusofdisease
            // 
            this.lbl_display_statusofdisease.AutoSize = true;
            this.lbl_display_statusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_statusofdisease.Location = new System.Drawing.Point(64, 538);
            this.lbl_display_statusofdisease.Name = "lbl_display_statusofdisease";
            this.lbl_display_statusofdisease.Size = new System.Drawing.Size(164, 20);
            this.lbl_display_statusofdisease.TabIndex = 57;
            this.lbl_display_statusofdisease.Text = "Status Of Disease";
            // 
            // lbl_display_diseases
            // 
            this.lbl_display_diseases.AutoSize = true;
            this.lbl_display_diseases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_diseases.Location = new System.Drawing.Point(64, 491);
            this.lbl_display_diseases.Name = "lbl_display_diseases";
            this.lbl_display_diseases.Size = new System.Drawing.Size(78, 20);
            this.lbl_display_diseases.TabIndex = 56;
            this.lbl_display_diseases.Text = "Disease";
            // 
            // lbl_patient_display_address
            // 
            this.lbl_patient_display_address.AutoSize = true;
            this.lbl_patient_display_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_address.Location = new System.Drawing.Point(64, 319);
            this.lbl_patient_display_address.Name = "lbl_patient_display_address";
            this.lbl_patient_display_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_patient_display_address.TabIndex = 55;
            this.lbl_patient_display_address.Text = "Address";
            // 
            // lbl_patient_display_phonenumber
            // 
            this.lbl_patient_display_phonenumber.AutoSize = true;
            this.lbl_patient_display_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_phonenumber.Location = new System.Drawing.Point(64, 367);
            this.lbl_patient_display_phonenumber.Name = "lbl_patient_display_phonenumber";
            this.lbl_patient_display_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_patient_display_phonenumber.TabIndex = 54;
            this.lbl_patient_display_phonenumber.Text = "Phone Number";
            // 
            // lbl_patient_display_age
            // 
            this.lbl_patient_display_age.AutoSize = true;
            this.lbl_patient_display_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_age.Location = new System.Drawing.Point(64, 273);
            this.lbl_patient_display_age.Name = "lbl_patient_display_age";
            this.lbl_patient_display_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_patient_display_age.TabIndex = 53;
            this.lbl_patient_display_age.Text = "Age";
            // 
            // lbl_patient_display_gender
            // 
            this.lbl_patient_display_gender.AutoSize = true;
            this.lbl_patient_display_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_gender.Location = new System.Drawing.Point(64, 230);
            this.lbl_patient_display_gender.Name = "lbl_patient_display_gender";
            this.lbl_patient_display_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_patient_display_gender.TabIndex = 52;
            this.lbl_patient_display_gender.Text = "Gender";
            // 
            // txt_patient_display_name
            // 
            this.txt_patient_display_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_name.Location = new System.Drawing.Point(297, 186);
            this.txt_patient_display_name.Name = "txt_patient_display_name";
            this.txt_patient_display_name.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_name.TabIndex = 51;
            // 
            // lbl_patient_display_name
            // 
            this.lbl_patient_display_name.AutoSize = true;
            this.lbl_patient_display_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_name.Location = new System.Drawing.Point(64, 188);
            this.lbl_patient_display_name.Name = "lbl_patient_display_name";
            this.lbl_patient_display_name.Size = new System.Drawing.Size(137, 20);
            this.lbl_patient_display_name.TabIndex = 50;
            this.lbl_patient_display_name.Text = "Patient\'s Name";
            // 
            // txt_patient_display_id
            // 
            this.txt_patient_display_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_id.Location = new System.Drawing.Point(297, 100);
            this.txt_patient_display_id.Name = "txt_patient_display_id";
            this.txt_patient_display_id.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_id.TabIndex = 49;
            // 
            // lbl_patient_display_id
            // 
            this.lbl_patient_display_id.AutoSize = true;
            this.lbl_patient_display_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_id.Location = new System.Drawing.Point(64, 100);
            this.lbl_patient_display_id.Name = "lbl_patient_display_id";
            this.lbl_patient_display_id.Size = new System.Drawing.Size(108, 20);
            this.lbl_patient_display_id.TabIndex = 48;
            this.lbl_patient_display_id.Text = "Patient\'s ID";
            // 
            // txt_patient_display_roomno
            // 
            this.txt_patient_display_roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_display_roomno.Location = new System.Drawing.Point(297, 449);
            this.txt_patient_display_roomno.Name = "txt_patient_display_roomno";
            this.txt_patient_display_roomno.Size = new System.Drawing.Size(229, 27);
            this.txt_patient_display_roomno.TabIndex = 74;
            // 
            // lbl_patient_display_roomno
            // 
            this.lbl_patient_display_roomno.AutoSize = true;
            this.lbl_patient_display_roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_display_roomno.Location = new System.Drawing.Point(64, 451);
            this.lbl_patient_display_roomno.Name = "lbl_patient_display_roomno";
            this.lbl_patient_display_roomno.Size = new System.Drawing.Size(86, 20);
            this.lbl_patient_display_roomno.TabIndex = 73;
            this.lbl_patient_display_roomno.Text = "Room No";
            // 
            // errorProvider_patient_info
            // 
            this.errorProvider_patient_info.ContainerControl = this;
            // 
            // dtp_patient_info
            // 
            this.dtp_patient_info.CustomFormat = "dd-MM-yyyy";
            this.dtp_patient_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_patient_info.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_patient_info.Location = new System.Drawing.Point(297, 145);
            this.dtp_patient_info.Name = "dtp_patient_info";
            this.dtp_patient_info.Size = new System.Drawing.Size(229, 27);
            this.dtp_patient_info.TabIndex = 76;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(205, 605);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 49);
            this.btn_search.TabIndex = 77;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Patient_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1335, 692);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_patient_info);
            this.Controls.Add(this.txt_patient_display_roomno);
            this.Controls.Add(this.lbl_patient_display_roomno);
            this.Controls.Add(this.cmb_patient_display_bloodgroup);
            this.Controls.Add(this.lbl_patient_display_bloodgroup);
            this.Controls.Add(this.lbl_patient_display_admitdate);
            this.Controls.Add(this.btn_patient_display_exit);
            this.Controls.Add(this.btn_patient_display_clear);
            this.Controls.Add(this.btn_patient_display);
            this.Controls.Add(this.dgv_patient_display);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cmb_patient_display_gender);
            this.Controls.Add(this.txt_patient_display_ststusofdisease);
            this.Controls.Add(this.txt_patient_display_disease);
            this.Controls.Add(this.txt_patient_display_phonenumber);
            this.Controls.Add(this.txt_patient_display_address);
            this.Controls.Add(this.txt_patient_display_age);
            this.Controls.Add(this.lbl_display_statusofdisease);
            this.Controls.Add(this.lbl_display_diseases);
            this.Controls.Add(this.lbl_patient_display_address);
            this.Controls.Add(this.lbl_patient_display_phonenumber);
            this.Controls.Add(this.lbl_patient_display_age);
            this.Controls.Add(this.lbl_patient_display_gender);
            this.Controls.Add(this.txt_patient_display_name);
            this.Controls.Add(this.lbl_patient_display_name);
            this.Controls.Add(this.txt_patient_display_id);
            this.Controls.Add(this.lbl_patient_display_id);
            this.Name = "Patient_information";
            this.Text = "Patient Information";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_patient_display_bloodgroup;
        private System.Windows.Forms.Label lbl_patient_display_bloodgroup;
        private System.Windows.Forms.Label lbl_patient_display_admitdate;
        private System.Windows.Forms.Button btn_patient_display_exit;
        private System.Windows.Forms.Button btn_patient_display_clear;
        private System.Windows.Forms.Button btn_patient_display;
        private System.Windows.Forms.DataGridView dgv_patient_display;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cmb_patient_display_gender;
        private System.Windows.Forms.TextBox txt_patient_display_ststusofdisease;
        private System.Windows.Forms.TextBox txt_patient_display_disease;
        private System.Windows.Forms.TextBox txt_patient_display_phonenumber;
        private System.Windows.Forms.TextBox txt_patient_display_address;
        private System.Windows.Forms.TextBox txt_patient_display_age;
        private System.Windows.Forms.Label lbl_display_statusofdisease;
        private System.Windows.Forms.Label lbl_display_diseases;
        private System.Windows.Forms.Label lbl_patient_display_address;
        private System.Windows.Forms.Label lbl_patient_display_phonenumber;
        private System.Windows.Forms.Label lbl_patient_display_age;
        private System.Windows.Forms.Label lbl_patient_display_gender;
        private System.Windows.Forms.TextBox txt_patient_display_name;
        private System.Windows.Forms.Label lbl_patient_display_name;
        private System.Windows.Forms.TextBox txt_patient_display_id;
        private System.Windows.Forms.Label lbl_patient_display_id;
        private System.Windows.Forms.TextBox txt_patient_display_roomno;
        private System.Windows.Forms.Label lbl_patient_display_roomno;
        private System.Windows.Forms.ErrorProvider errorProvider_patient_info;
        private System.Windows.Forms.DateTimePicker dtp_patient_info;
        private System.Windows.Forms.Button btn_search;
    }
}