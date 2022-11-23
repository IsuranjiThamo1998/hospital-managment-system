
namespace GUI__group_final_project
{
    partial class Patient_registration
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
            this.cmb_patient_reg_bloodgroup = new System.Windows.Forms.ComboBox();
            this.lbl_patient_reg_bloodgroup = new System.Windows.Forms.Label();
            this.lbl_patient_reg_admitdate = new System.Windows.Forms.Label();
            this.txt_patient_reg_ststusofdisease = new System.Windows.Forms.TextBox();
            this.txt_patient_reg_disease = new System.Windows.Forms.TextBox();
            this.txt_patient_reg_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_patient_reg_address = new System.Windows.Forms.TextBox();
            this.txt_patient_reg_age = new System.Windows.Forms.TextBox();
            this.txt_patient_reg_name = new System.Windows.Forms.TextBox();
            this.lbl_reg_statusofdisease = new System.Windows.Forms.Label();
            this.txt_patient_reg_id = new System.Windows.Forms.TextBox();
            this.lbl_reg_diseases = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_patient_reg_exit = new System.Windows.Forms.Button();
            this.btn_patient_reg_clear = new System.Windows.Forms.Button();
            this.btn_patient_save = new System.Windows.Forms.Button();
            this.lbl_patient_reg_address = new System.Windows.Forms.Label();
            this.lbl_patient_reg_phonenumber = new System.Windows.Forms.Label();
            this.lbl_patient_reg_age = new System.Windows.Forms.Label();
            this.lbl_patient_reg_gender = new System.Windows.Forms.Label();
            this.lbl_patient_reg_name = new System.Windows.Forms.Label();
            this.lbl_patient_reg_id = new System.Windows.Forms.Label();
            this.cmb_patient_reg_gender = new System.Windows.Forms.ComboBox();
            this.lbl_patient_reg_roomno = new System.Windows.Forms.Label();
            this.txt_patient_reg_roomno = new System.Windows.Forms.TextBox();
            this.dtp_patient_reg = new System.Windows.Forms.DateTimePicker();
            this.errorProvider_patient_reg = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_patient_reg_bloodgroup
            // 
            this.cmb_patient_reg_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient_reg_bloodgroup.FormattingEnabled = true;
            this.cmb_patient_reg_bloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmb_patient_reg_bloodgroup.Location = new System.Drawing.Point(638, 409);
            this.cmb_patient_reg_bloodgroup.Name = "cmb_patient_reg_bloodgroup";
            this.cmb_patient_reg_bloodgroup.Size = new System.Drawing.Size(281, 28);
            this.cmb_patient_reg_bloodgroup.TabIndex = 56;
            this.cmb_patient_reg_bloodgroup.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_patient_reg_bloodgroup_Validating);
            // 
            // lbl_patient_reg_bloodgroup
            // 
            this.lbl_patient_reg_bloodgroup.AutoSize = true;
            this.lbl_patient_reg_bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_bloodgroup.Location = new System.Drawing.Point(389, 413);
            this.lbl_patient_reg_bloodgroup.Name = "lbl_patient_reg_bloodgroup";
            this.lbl_patient_reg_bloodgroup.Size = new System.Drawing.Size(114, 20);
            this.lbl_patient_reg_bloodgroup.TabIndex = 55;
            this.lbl_patient_reg_bloodgroup.Text = "Blood Group";
            // 
            // lbl_patient_reg_admitdate
            // 
            this.lbl_patient_reg_admitdate.AutoSize = true;
            this.lbl_patient_reg_admitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_admitdate.Location = new System.Drawing.Point(389, 133);
            this.lbl_patient_reg_admitdate.Name = "lbl_patient_reg_admitdate";
            this.lbl_patient_reg_admitdate.Size = new System.Drawing.Size(103, 20);
            this.lbl_patient_reg_admitdate.TabIndex = 52;
            this.lbl_patient_reg_admitdate.Text = "Admit Date";
            // 
            // txt_patient_reg_ststusofdisease
            // 
            this.txt_patient_reg_ststusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_ststusofdisease.Location = new System.Drawing.Point(638, 527);
            this.txt_patient_reg_ststusofdisease.Name = "txt_patient_reg_ststusofdisease";
            this.txt_patient_reg_ststusofdisease.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_ststusofdisease.TabIndex = 50;
            // 
            // txt_patient_reg_disease
            // 
            this.txt_patient_reg_disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_disease.Location = new System.Drawing.Point(638, 486);
            this.txt_patient_reg_disease.Name = "txt_patient_reg_disease";
            this.txt_patient_reg_disease.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_disease.TabIndex = 49;
            // 
            // txt_patient_reg_phonenumber
            // 
            this.txt_patient_reg_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_phonenumber.Location = new System.Drawing.Point(638, 365);
            this.txt_patient_reg_phonenumber.Name = "txt_patient_reg_phonenumber";
            this.txt_patient_reg_phonenumber.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_phonenumber.TabIndex = 48;
            this.txt_patient_reg_phonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_reg_phonenumber_Validating);
            // 
            // txt_patient_reg_address
            // 
            this.txt_patient_reg_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_address.Location = new System.Drawing.Point(638, 317);
            this.txt_patient_reg_address.Name = "txt_patient_reg_address";
            this.txt_patient_reg_address.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_address.TabIndex = 47;
            // 
            // txt_patient_reg_age
            // 
            this.txt_patient_reg_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_age.Location = new System.Drawing.Point(638, 270);
            this.txt_patient_reg_age.Name = "txt_patient_reg_age";
            this.txt_patient_reg_age.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_age.TabIndex = 46;
            this.txt_patient_reg_age.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_reg_age_Validating);
            // 
            // txt_patient_reg_name
            // 
            this.txt_patient_reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_name.Location = new System.Drawing.Point(638, 178);
            this.txt_patient_reg_name.Name = "txt_patient_reg_name";
            this.txt_patient_reg_name.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_name.TabIndex = 45;
            this.txt_patient_reg_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_reg_name_Validating);
            // 
            // lbl_reg_statusofdisease
            // 
            this.lbl_reg_statusofdisease.AutoSize = true;
            this.lbl_reg_statusofdisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_statusofdisease.Location = new System.Drawing.Point(389, 529);
            this.lbl_reg_statusofdisease.Name = "lbl_reg_statusofdisease";
            this.lbl_reg_statusofdisease.Size = new System.Drawing.Size(164, 20);
            this.lbl_reg_statusofdisease.TabIndex = 44;
            this.lbl_reg_statusofdisease.Text = "Status Of Disease";
            // 
            // txt_patient_reg_id
            // 
            this.txt_patient_reg_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_id.Location = new System.Drawing.Point(638, 90);
            this.txt_patient_reg_id.Name = "txt_patient_reg_id";
            this.txt_patient_reg_id.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_id.TabIndex = 43;
            this.txt_patient_reg_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_reg_id_Validating);
            // 
            // lbl_reg_diseases
            // 
            this.lbl_reg_diseases.AutoSize = true;
            this.lbl_reg_diseases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_diseases.Location = new System.Drawing.Point(389, 486);
            this.lbl_reg_diseases.Name = "lbl_reg_diseases";
            this.lbl_reg_diseases.Size = new System.Drawing.Size(78, 20);
            this.lbl_reg_diseases.TabIndex = 42;
            this.lbl_reg_diseases.Text = "Disease";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Location = new System.Drawing.Point(12, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1203, 55);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "Patient Registration";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_patient_reg_exit
            // 
            this.btn_patient_reg_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_reg_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_reg_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_reg_exit.Location = new System.Drawing.Point(793, 612);
            this.btn_patient_reg_exit.Name = "btn_patient_reg_exit";
            this.btn_patient_reg_exit.Size = new System.Drawing.Size(88, 49);
            this.btn_patient_reg_exit.TabIndex = 40;
            this.btn_patient_reg_exit.Text = "Exit";
            this.btn_patient_reg_exit.UseVisualStyleBackColor = false;
            this.btn_patient_reg_exit.Click += new System.EventHandler(this.btn_patient_reg_exit_Click);
            // 
            // btn_patient_reg_clear
            // 
            this.btn_patient_reg_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_reg_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_reg_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_reg_clear.Location = new System.Drawing.Point(598, 612);
            this.btn_patient_reg_clear.Name = "btn_patient_reg_clear";
            this.btn_patient_reg_clear.Size = new System.Drawing.Size(90, 49);
            this.btn_patient_reg_clear.TabIndex = 39;
            this.btn_patient_reg_clear.Text = "Clear";
            this.btn_patient_reg_clear.UseVisualStyleBackColor = false;
            this.btn_patient_reg_clear.Click += new System.EventHandler(this.btn_patient_reg_clear_Click);
            // 
            // btn_patient_save
            // 
            this.btn_patient_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_patient_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_patient_save.Location = new System.Drawing.Point(416, 612);
            this.btn_patient_save.Name = "btn_patient_save";
            this.btn_patient_save.Size = new System.Drawing.Size(81, 50);
            this.btn_patient_save.TabIndex = 38;
            this.btn_patient_save.Text = "Save";
            this.btn_patient_save.UseVisualStyleBackColor = false;
            this.btn_patient_save.Click += new System.EventHandler(this.btn_patient_save_Click);
            // 
            // lbl_patient_reg_address
            // 
            this.lbl_patient_reg_address.AutoSize = true;
            this.lbl_patient_reg_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_address.Location = new System.Drawing.Point(389, 319);
            this.lbl_patient_reg_address.Name = "lbl_patient_reg_address";
            this.lbl_patient_reg_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_patient_reg_address.TabIndex = 37;
            this.lbl_patient_reg_address.Text = "Address";
            // 
            // lbl_patient_reg_phonenumber
            // 
            this.lbl_patient_reg_phonenumber.AutoSize = true;
            this.lbl_patient_reg_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_phonenumber.Location = new System.Drawing.Point(389, 367);
            this.lbl_patient_reg_phonenumber.Name = "lbl_patient_reg_phonenumber";
            this.lbl_patient_reg_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_patient_reg_phonenumber.TabIndex = 36;
            this.lbl_patient_reg_phonenumber.Text = "Phone Number";
            // 
            // lbl_patient_reg_age
            // 
            this.lbl_patient_reg_age.AutoSize = true;
            this.lbl_patient_reg_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_age.Location = new System.Drawing.Point(389, 272);
            this.lbl_patient_reg_age.Name = "lbl_patient_reg_age";
            this.lbl_patient_reg_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_patient_reg_age.TabIndex = 35;
            this.lbl_patient_reg_age.Text = "Age";
            // 
            // lbl_patient_reg_gender
            // 
            this.lbl_patient_reg_gender.AutoSize = true;
            this.lbl_patient_reg_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_gender.Location = new System.Drawing.Point(386, 224);
            this.lbl_patient_reg_gender.Name = "lbl_patient_reg_gender";
            this.lbl_patient_reg_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_patient_reg_gender.TabIndex = 34;
            this.lbl_patient_reg_gender.Text = "Gender";
            // 
            // lbl_patient_reg_name
            // 
            this.lbl_patient_reg_name.AutoSize = true;
            this.lbl_patient_reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_name.Location = new System.Drawing.Point(389, 180);
            this.lbl_patient_reg_name.Name = "lbl_patient_reg_name";
            this.lbl_patient_reg_name.Size = new System.Drawing.Size(137, 20);
            this.lbl_patient_reg_name.TabIndex = 33;
            this.lbl_patient_reg_name.Text = "Patient\'s Name";
            // 
            // lbl_patient_reg_id
            // 
            this.lbl_patient_reg_id.AutoSize = true;
            this.lbl_patient_reg_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_id.Location = new System.Drawing.Point(389, 94);
            this.lbl_patient_reg_id.Name = "lbl_patient_reg_id";
            this.lbl_patient_reg_id.Size = new System.Drawing.Size(108, 20);
            this.lbl_patient_reg_id.TabIndex = 32;
            this.lbl_patient_reg_id.Text = "Patient\'s ID";
            // 
            // cmb_patient_reg_gender
            // 
            this.cmb_patient_reg_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_patient_reg_gender.FormattingEnabled = true;
            this.cmb_patient_reg_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_patient_reg_gender.Location = new System.Drawing.Point(638, 220);
            this.cmb_patient_reg_gender.Name = "cmb_patient_reg_gender";
            this.cmb_patient_reg_gender.Size = new System.Drawing.Size(281, 28);
            this.cmb_patient_reg_gender.TabIndex = 57;
            this.cmb_patient_reg_gender.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_patient_reg_gender_Validating);
            // 
            // lbl_patient_reg_roomno
            // 
            this.lbl_patient_reg_roomno.AutoSize = true;
            this.lbl_patient_reg_roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_reg_roomno.Location = new System.Drawing.Point(389, 448);
            this.lbl_patient_reg_roomno.Name = "lbl_patient_reg_roomno";
            this.lbl_patient_reg_roomno.Size = new System.Drawing.Size(86, 20);
            this.lbl_patient_reg_roomno.TabIndex = 58;
            this.lbl_patient_reg_roomno.Text = "Room No";
            // 
            // txt_patient_reg_roomno
            // 
            this.txt_patient_reg_roomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_reg_roomno.Location = new System.Drawing.Point(638, 446);
            this.txt_patient_reg_roomno.Name = "txt_patient_reg_roomno";
            this.txt_patient_reg_roomno.Size = new System.Drawing.Size(281, 27);
            this.txt_patient_reg_roomno.TabIndex = 59;
            this.txt_patient_reg_roomno.Validating += new System.ComponentModel.CancelEventHandler(this.txt_patient_reg_roomno_Validating);
            // 
            // dtp_patient_reg
            // 
            this.dtp_patient_reg.CustomFormat = "dd-MM-yyyy";
            this.dtp_patient_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_patient_reg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_patient_reg.Location = new System.Drawing.Point(638, 133);
            this.dtp_patient_reg.Name = "dtp_patient_reg";
            this.dtp_patient_reg.Size = new System.Drawing.Size(281, 27);
            this.dtp_patient_reg.TabIndex = 63;
            this.dtp_patient_reg.Value = new System.DateTime(2021, 5, 19, 0, 0, 0, 0);
            // 
            // errorProvider_patient_reg
            // 
            this.errorProvider_patient_reg.ContainerControl = this;
            // 
            // Patient_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 697);
            this.Controls.Add(this.dtp_patient_reg);
            this.Controls.Add(this.txt_patient_reg_roomno);
            this.Controls.Add(this.lbl_patient_reg_roomno);
            this.Controls.Add(this.cmb_patient_reg_gender);
            this.Controls.Add(this.cmb_patient_reg_bloodgroup);
            this.Controls.Add(this.lbl_patient_reg_bloodgroup);
            this.Controls.Add(this.lbl_patient_reg_admitdate);
            this.Controls.Add(this.txt_patient_reg_ststusofdisease);
            this.Controls.Add(this.txt_patient_reg_disease);
            this.Controls.Add(this.txt_patient_reg_phonenumber);
            this.Controls.Add(this.txt_patient_reg_address);
            this.Controls.Add(this.txt_patient_reg_age);
            this.Controls.Add(this.txt_patient_reg_name);
            this.Controls.Add(this.lbl_reg_statusofdisease);
            this.Controls.Add(this.txt_patient_reg_id);
            this.Controls.Add(this.lbl_reg_diseases);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_patient_reg_exit);
            this.Controls.Add(this.btn_patient_reg_clear);
            this.Controls.Add(this.btn_patient_save);
            this.Controls.Add(this.lbl_patient_reg_address);
            this.Controls.Add(this.lbl_patient_reg_phonenumber);
            this.Controls.Add(this.lbl_patient_reg_age);
            this.Controls.Add(this.lbl_patient_reg_gender);
            this.Controls.Add(this.lbl_patient_reg_name);
            this.Controls.Add(this.lbl_patient_reg_id);
            this.Name = "Patient_registration";
            this.Text = "Patient Registration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_patient_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_patient_reg_bloodgroup;
        private System.Windows.Forms.Label lbl_patient_reg_bloodgroup;
        private System.Windows.Forms.Label lbl_patient_reg_admitdate;
        private System.Windows.Forms.TextBox txt_patient_reg_ststusofdisease;
        private System.Windows.Forms.TextBox txt_patient_reg_disease;
        private System.Windows.Forms.TextBox txt_patient_reg_phonenumber;
        private System.Windows.Forms.TextBox txt_patient_reg_address;
        private System.Windows.Forms.TextBox txt_patient_reg_age;
        private System.Windows.Forms.TextBox txt_patient_reg_name;
        private System.Windows.Forms.Label lbl_reg_statusofdisease;
        private System.Windows.Forms.TextBox txt_patient_reg_id;
        private System.Windows.Forms.Label lbl_reg_diseases;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_patient_reg_exit;
        private System.Windows.Forms.Button btn_patient_reg_clear;
        private System.Windows.Forms.Button btn_patient_save;
        private System.Windows.Forms.Label lbl_patient_reg_address;
        private System.Windows.Forms.Label lbl_patient_reg_phonenumber;
        private System.Windows.Forms.Label lbl_patient_reg_age;
        private System.Windows.Forms.Label lbl_patient_reg_gender;
        private System.Windows.Forms.Label lbl_patient_reg_name;
        private System.Windows.Forms.Label lbl_patient_reg_id;
        private System.Windows.Forms.ComboBox cmb_patient_reg_gender;
        private System.Windows.Forms.Label lbl_patient_reg_roomno;
        private System.Windows.Forms.TextBox txt_patient_reg_roomno;
        private System.Windows.Forms.DateTimePicker dtp_patient_reg;
        private System.Windows.Forms.ErrorProvider errorProvider_patient_reg;
    }
}