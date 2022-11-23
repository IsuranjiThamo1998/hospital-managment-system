
namespace GUI__group_final_project
{
    partial class Doctor_registration
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
            this.lbl_doctor_reg_date = new System.Windows.Forms.Label();
            this.cmb_doctor_reg_gender = new System.Windows.Forms.ComboBox();
            this.txt_reg_email = new System.Windows.Forms.TextBox();
            this.txt_reg_specialization = new System.Windows.Forms.TextBox();
            this.txt_doctor_reg_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_doctor_reg_address = new System.Windows.Forms.TextBox();
            this.txt_doctor_reg_age = new System.Windows.Forms.TextBox();
            this.txt_doctor_reg_name = new System.Windows.Forms.TextBox();
            this.lbl_reg_email = new System.Windows.Forms.Label();
            this.txt_doctor_reg_id = new System.Windows.Forms.TextBox();
            this.lbl_reg_specialization = new System.Windows.Forms.Label();
            this.lbl_doctor_reg_address = new System.Windows.Forms.Label();
            this.lbl_doctor_reg_phonenumber = new System.Windows.Forms.Label();
            this.lbl_doctor_reg_age = new System.Windows.Forms.Label();
            this.lbl_doctor_reg_gender = new System.Windows.Forms.Label();
            this.lbl_doctor_reg__id = new System.Windows.Forms.Label();
            this.btn_doctor_reg_exit = new System.Windows.Forms.Button();
            this.btn_doctor_reg_clear = new System.Windows.Forms.Button();
            this.btn_doctor_reg_save = new System.Windows.Forms.Button();
            this.lbl_doctor_reg_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_doc_regi_date = new System.Windows.Forms.DateTimePicker();
            this.errorProvider_doc_reg = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doc_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_doctor_reg_date
            // 
            this.lbl_doctor_reg_date.AutoSize = true;
            this.lbl_doctor_reg_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_reg_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_reg_date.Location = new System.Drawing.Point(371, 157);
            this.lbl_doctor_reg_date.Name = "lbl_doctor_reg_date";
            this.lbl_doctor_reg_date.Size = new System.Drawing.Size(126, 20);
            this.lbl_doctor_reg_date.TabIndex = 68;
            this.lbl_doctor_reg_date.Text = "Register Date";
            // 
            // cmb_doctor_reg_gender
            // 
            this.cmb_doctor_reg_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_doctor_reg_gender.FormattingEnabled = true;
            this.cmb_doctor_reg_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_doctor_reg_gender.Location = new System.Drawing.Point(632, 234);
            this.cmb_doctor_reg_gender.Name = "cmb_doctor_reg_gender";
            this.cmb_doctor_reg_gender.Size = new System.Drawing.Size(237, 28);
            this.cmb_doctor_reg_gender.TabIndex = 67;
            this.cmb_doctor_reg_gender.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_doctor_reg_gender_Validating);
            // 
            // txt_reg_email
            // 
            this.txt_reg_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reg_email.Location = new System.Drawing.Point(632, 413);
            this.txt_reg_email.Name = "txt_reg_email";
            this.txt_reg_email.Size = new System.Drawing.Size(237, 27);
            this.txt_reg_email.TabIndex = 66;
            this.txt_reg_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_reg_email_Validating);
            // 
            // txt_reg_specialization
            // 
            this.txt_reg_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reg_specialization.Location = new System.Drawing.Point(632, 463);
            this.txt_reg_specialization.Name = "txt_reg_specialization";
            this.txt_reg_specialization.Size = new System.Drawing.Size(237, 27);
            this.txt_reg_specialization.TabIndex = 65;
            this.txt_reg_specialization.Validating += new System.ComponentModel.CancelEventHandler(this.txt_reg_specialization_Validating);
            // 
            // txt_doctor_reg_phonenumber
            // 
            this.txt_doctor_reg_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_reg_phonenumber.Location = new System.Drawing.Point(632, 367);
            this.txt_doctor_reg_phonenumber.Name = "txt_doctor_reg_phonenumber";
            this.txt_doctor_reg_phonenumber.Size = new System.Drawing.Size(237, 27);
            this.txt_doctor_reg_phonenumber.TabIndex = 64;
            this.txt_doctor_reg_phonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_reg_phonenumber_Validating);
            // 
            // txt_doctor_reg_address
            // 
            this.txt_doctor_reg_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_reg_address.Location = new System.Drawing.Point(632, 322);
            this.txt_doctor_reg_address.Name = "txt_doctor_reg_address";
            this.txt_doctor_reg_address.Size = new System.Drawing.Size(237, 27);
            this.txt_doctor_reg_address.TabIndex = 63;
            this.txt_doctor_reg_address.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_reg_address_Validating);
            // 
            // txt_doctor_reg_age
            // 
            this.txt_doctor_reg_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_reg_age.Location = new System.Drawing.Point(632, 284);
            this.txt_doctor_reg_age.Name = "txt_doctor_reg_age";
            this.txt_doctor_reg_age.Size = new System.Drawing.Size(237, 27);
            this.txt_doctor_reg_age.TabIndex = 62;
            this.txt_doctor_reg_age.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_reg_age_Validating);
            // 
            // txt_doctor_reg_name
            // 
            this.txt_doctor_reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_reg_name.Location = new System.Drawing.Point(632, 196);
            this.txt_doctor_reg_name.Name = "txt_doctor_reg_name";
            this.txt_doctor_reg_name.Size = new System.Drawing.Size(237, 27);
            this.txt_doctor_reg_name.TabIndex = 61;
            this.txt_doctor_reg_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_reg_name_Validating);
            // 
            // lbl_reg_email
            // 
            this.lbl_reg_email.AutoSize = true;
            this.lbl_reg_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_reg_email.Location = new System.Drawing.Point(371, 420);
            this.lbl_reg_email.Name = "lbl_reg_email";
            this.lbl_reg_email.Size = new System.Drawing.Size(63, 20);
            this.lbl_reg_email.TabIndex = 60;
            this.lbl_reg_email.Text = "E-mail";
            // 
            // txt_doctor_reg_id
            // 
            this.txt_doctor_reg_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_reg_id.Location = new System.Drawing.Point(632, 104);
            this.txt_doctor_reg_id.Name = "txt_doctor_reg_id";
            this.txt_doctor_reg_id.Size = new System.Drawing.Size(237, 27);
            this.txt_doctor_reg_id.TabIndex = 59;
            this.txt_doctor_reg_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_doctor_reg_id_Validating);
            // 
            // lbl_reg_specialization
            // 
            this.lbl_reg_specialization.AutoSize = true;
            this.lbl_reg_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_specialization.ForeColor = System.Drawing.Color.Black;
            this.lbl_reg_specialization.Location = new System.Drawing.Point(371, 471);
            this.lbl_reg_specialization.Name = "lbl_reg_specialization";
            this.lbl_reg_specialization.Size = new System.Drawing.Size(127, 20);
            this.lbl_reg_specialization.TabIndex = 58;
            this.lbl_reg_specialization.Text = "Specialization";
            // 
            // lbl_doctor_reg_address
            // 
            this.lbl_doctor_reg_address.AutoSize = true;
            this.lbl_doctor_reg_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_reg_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_reg_address.Location = new System.Drawing.Point(371, 329);
            this.lbl_doctor_reg_address.Name = "lbl_doctor_reg_address";
            this.lbl_doctor_reg_address.Size = new System.Drawing.Size(78, 20);
            this.lbl_doctor_reg_address.TabIndex = 57;
            this.lbl_doctor_reg_address.Text = "Address";
            // 
            // lbl_doctor_reg_phonenumber
            // 
            this.lbl_doctor_reg_phonenumber.AutoSize = true;
            this.lbl_doctor_reg_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_reg_phonenumber.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_reg_phonenumber.Location = new System.Drawing.Point(371, 374);
            this.lbl_doctor_reg_phonenumber.Name = "lbl_doctor_reg_phonenumber";
            this.lbl_doctor_reg_phonenumber.Size = new System.Drawing.Size(132, 20);
            this.lbl_doctor_reg_phonenumber.TabIndex = 56;
            this.lbl_doctor_reg_phonenumber.Text = "Phone Number";
            // 
            // lbl_doctor_reg_age
            // 
            this.lbl_doctor_reg_age.AutoSize = true;
            this.lbl_doctor_reg_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_reg_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_reg_age.Location = new System.Drawing.Point(371, 291);
            this.lbl_doctor_reg_age.Name = "lbl_doctor_reg_age";
            this.lbl_doctor_reg_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_doctor_reg_age.TabIndex = 55;
            this.lbl_doctor_reg_age.Text = "Age";
            // 
            // lbl_doctor_reg_gender
            // 
            this.lbl_doctor_reg_gender.AutoSize = true;
            this.lbl_doctor_reg_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_reg_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_reg_gender.Location = new System.Drawing.Point(371, 243);
            this.lbl_doctor_reg_gender.Name = "lbl_doctor_reg_gender";
            this.lbl_doctor_reg_gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_doctor_reg_gender.TabIndex = 54;
            this.lbl_doctor_reg_gender.Text = "Gender";
            // 
            // lbl_doctor_reg__id
            // 
            this.lbl_doctor_reg__id.AutoSize = true;
            this.lbl_doctor_reg__id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_reg__id.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_reg__id.Location = new System.Drawing.Point(371, 113);
            this.lbl_doctor_reg__id.Name = "lbl_doctor_reg__id";
            this.lbl_doctor_reg__id.Size = new System.Drawing.Size(106, 20);
            this.lbl_doctor_reg__id.TabIndex = 52;
            this.lbl_doctor_reg__id.Text = "Doctor\'s ID";
            // 
            // btn_doctor_reg_exit
            // 
            this.btn_doctor_reg_exit.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_reg_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_reg_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_reg_exit.Location = new System.Drawing.Point(781, 565);
            this.btn_doctor_reg_exit.Name = "btn_doctor_reg_exit";
            this.btn_doctor_reg_exit.Size = new System.Drawing.Size(88, 49);
            this.btn_doctor_reg_exit.TabIndex = 51;
            this.btn_doctor_reg_exit.Text = "Exit";
            this.btn_doctor_reg_exit.UseVisualStyleBackColor = false;
            this.btn_doctor_reg_exit.Click += new System.EventHandler(this.btn_doctor_reg_exit_Click);
            // 
            // btn_doctor_reg_clear
            // 
            this.btn_doctor_reg_clear.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_reg_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_reg_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_reg_clear.Location = new System.Drawing.Point(574, 565);
            this.btn_doctor_reg_clear.Name = "btn_doctor_reg_clear";
            this.btn_doctor_reg_clear.Size = new System.Drawing.Size(90, 49);
            this.btn_doctor_reg_clear.TabIndex = 50;
            this.btn_doctor_reg_clear.Text = "Clear";
            this.btn_doctor_reg_clear.UseVisualStyleBackColor = false;
            this.btn_doctor_reg_clear.Click += new System.EventHandler(this.btn_doctor_reg_clear_Click);
            // 
            // btn_doctor_reg_save
            // 
            this.btn_doctor_reg_save.BackColor = System.Drawing.Color.Purple;
            this.btn_doctor_reg_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_reg_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_reg_save.Location = new System.Drawing.Point(375, 565);
            this.btn_doctor_reg_save.Name = "btn_doctor_reg_save";
            this.btn_doctor_reg_save.Size = new System.Drawing.Size(87, 49);
            this.btn_doctor_reg_save.TabIndex = 49;
            this.btn_doctor_reg_save.Text = "Save";
            this.btn_doctor_reg_save.UseVisualStyleBackColor = false;
            this.btn_doctor_reg_save.Click += new System.EventHandler(this.btn_doctor_reg_save_Click);
            // 
            // lbl_doctor_reg_name
            // 
            this.lbl_doctor_reg_name.AutoSize = true;
            this.lbl_doctor_reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_reg_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_doctor_reg_name.Location = new System.Drawing.Point(371, 201);
            this.lbl_doctor_reg_name.Name = "lbl_doctor_reg_name";
            this.lbl_doctor_reg_name.Size = new System.Drawing.Size(135, 20);
            this.lbl_doctor_reg_name.TabIndex = 71;
            this.lbl_doctor_reg_name.Text = "Doctor\'s Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(26, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1164, 61);
            this.button1.TabIndex = 135;
            this.button1.Text = "Doctor Registration";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtp_doc_regi_date
            // 
            this.dtp_doc_regi_date.CustomFormat = "dd/MM/yyyy";
            this.dtp_doc_regi_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_doc_regi_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_doc_regi_date.Location = new System.Drawing.Point(632, 150);
            this.dtp_doc_regi_date.Name = "dtp_doc_regi_date";
            this.dtp_doc_regi_date.Size = new System.Drawing.Size(237, 27);
            this.dtp_doc_regi_date.TabIndex = 156;
            // 
            // errorProvider_doc_reg
            // 
            this.errorProvider_doc_reg.ContainerControl = this;
            // 
            // Doctor_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1211, 672);
            this.Controls.Add(this.dtp_doc_regi_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_doctor_reg_name);
            this.Controls.Add(this.lbl_doctor_reg_date);
            this.Controls.Add(this.cmb_doctor_reg_gender);
            this.Controls.Add(this.txt_reg_email);
            this.Controls.Add(this.txt_reg_specialization);
            this.Controls.Add(this.txt_doctor_reg_phonenumber);
            this.Controls.Add(this.txt_doctor_reg_address);
            this.Controls.Add(this.txt_doctor_reg_age);
            this.Controls.Add(this.txt_doctor_reg_name);
            this.Controls.Add(this.lbl_reg_email);
            this.Controls.Add(this.txt_doctor_reg_id);
            this.Controls.Add(this.lbl_reg_specialization);
            this.Controls.Add(this.lbl_doctor_reg_address);
            this.Controls.Add(this.lbl_doctor_reg_phonenumber);
            this.Controls.Add(this.lbl_doctor_reg_age);
            this.Controls.Add(this.lbl_doctor_reg_gender);
            this.Controls.Add(this.lbl_doctor_reg__id);
            this.Controls.Add(this.btn_doctor_reg_exit);
            this.Controls.Add(this.btn_doctor_reg_clear);
            this.Controls.Add(this.btn_doctor_reg_save);
            this.Name = "Doctor_registration";
            this.Text = "Doctor Registration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doc_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_doctor_reg_date;
        private System.Windows.Forms.ComboBox cmb_doctor_reg_gender;
        private System.Windows.Forms.TextBox txt_reg_email;
        private System.Windows.Forms.TextBox txt_reg_specialization;
        private System.Windows.Forms.TextBox txt_doctor_reg_phonenumber;
        private System.Windows.Forms.TextBox txt_doctor_reg_address;
        private System.Windows.Forms.TextBox txt_doctor_reg_age;
        private System.Windows.Forms.TextBox txt_doctor_reg_name;
        private System.Windows.Forms.Label lbl_reg_email;
        private System.Windows.Forms.TextBox txt_doctor_reg_id;
        private System.Windows.Forms.Label lbl_reg_specialization;
        private System.Windows.Forms.Label lbl_doctor_reg_address;
        private System.Windows.Forms.Label lbl_doctor_reg_phonenumber;
        private System.Windows.Forms.Label lbl_doctor_reg_age;
        private System.Windows.Forms.Label lbl_doctor_reg_gender;
        private System.Windows.Forms.Label lbl_doctor_reg__id;
        private System.Windows.Forms.Button btn_doctor_reg_exit;
        private System.Windows.Forms.Button btn_doctor_reg_clear;
        private System.Windows.Forms.Button btn_doctor_reg_save;
        private System.Windows.Forms.Label lbl_doctor_reg_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_doc_regi_date;
        private System.Windows.Forms.ErrorProvider errorProvider_doc_reg;
    }
}