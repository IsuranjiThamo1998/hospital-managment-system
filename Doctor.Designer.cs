
namespace GUI__group_final_project
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_doctordetails_exit = new System.Windows.Forms.Button();
            this.btn_doctor_update = new System.Windows.Forms.Button();
            this.lbl_patient_updstecolor = new System.Windows.Forms.Label();
            this.lbl_patient_deletecolor = new System.Windows.Forms.Label();
            this.lbl_patient_infocolor = new System.Windows.Forms.Label();
            this.lbl_patient_regiscolor = new System.Windows.Forms.Label();
            this.btn_doctor_delete = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_doctor_display = new System.Windows.Forms.Button();
            this.btn_doctor_registration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1139, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_doctordetails_exit
            // 
            this.btn_doctordetails_exit.BackColor = System.Drawing.Color.Navy;
            this.btn_doctordetails_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctordetails_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctordetails_exit.Location = new System.Drawing.Point(255, 563);
            this.btn_doctordetails_exit.Name = "btn_doctordetails_exit";
            this.btn_doctordetails_exit.Size = new System.Drawing.Size(113, 65);
            this.btn_doctordetails_exit.TabIndex = 51;
            this.btn_doctordetails_exit.Text = "Exit";
            this.btn_doctordetails_exit.UseVisualStyleBackColor = false;
            this.btn_doctordetails_exit.Click += new System.EventHandler(this.btn_doctordetails_exit_Click);
            // 
            // btn_doctor_update
            // 
            this.btn_doctor_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_doctor_update.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_update.Location = new System.Drawing.Point(109, 344);
            this.btn_doctor_update.Name = "btn_doctor_update";
            this.btn_doctor_update.Size = new System.Drawing.Size(423, 70);
            this.btn_doctor_update.TabIndex = 50;
            this.btn_doctor_update.Text = "Doctor Info Update";
            this.btn_doctor_update.UseVisualStyleBackColor = false;
            this.btn_doctor_update.Click += new System.EventHandler(this.btn_doctor_infoupdate_Click);
            // 
            // lbl_patient_updstecolor
            // 
            this.lbl_patient_updstecolor.AutoSize = true;
            this.lbl_patient_updstecolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_patient_updstecolor.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_updstecolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_patient_updstecolor.Location = new System.Drawing.Point(33, 468);
            this.lbl_patient_updstecolor.Name = "lbl_patient_updstecolor";
            this.lbl_patient_updstecolor.Size = new System.Drawing.Size(55, 29);
            this.lbl_patient_updstecolor.TabIndex = 49;
            this.lbl_patient_updstecolor.Text = ">>";
            // 
            // lbl_patient_deletecolor
            // 
            this.lbl_patient_deletecolor.AutoSize = true;
            this.lbl_patient_deletecolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_patient_deletecolor.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_deletecolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_patient_deletecolor.Location = new System.Drawing.Point(33, 366);
            this.lbl_patient_deletecolor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_patient_deletecolor.Name = "lbl_patient_deletecolor";
            this.lbl_patient_deletecolor.Size = new System.Drawing.Size(55, 29);
            this.lbl_patient_deletecolor.TabIndex = 48;
            this.lbl_patient_deletecolor.Text = ">>";
            // 
            // lbl_patient_infocolor
            // 
            this.lbl_patient_infocolor.AutoSize = true;
            this.lbl_patient_infocolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_patient_infocolor.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_infocolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_patient_infocolor.Location = new System.Drawing.Point(33, 256);
            this.lbl_patient_infocolor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_patient_infocolor.Name = "lbl_patient_infocolor";
            this.lbl_patient_infocolor.Size = new System.Drawing.Size(55, 29);
            this.lbl_patient_infocolor.TabIndex = 47;
            this.lbl_patient_infocolor.Text = ">>";
            // 
            // lbl_patient_regiscolor
            // 
            this.lbl_patient_regiscolor.AutoSize = true;
            this.lbl_patient_regiscolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_patient_regiscolor.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_regiscolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_patient_regiscolor.Location = new System.Drawing.Point(33, 150);
            this.lbl_patient_regiscolor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_patient_regiscolor.Name = "lbl_patient_regiscolor";
            this.lbl_patient_regiscolor.Size = new System.Drawing.Size(55, 29);
            this.lbl_patient_regiscolor.TabIndex = 46;
            this.lbl_patient_regiscolor.Text = ">>";
            // 
            // btn_doctor_delete
            // 
            this.btn_doctor_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_doctor_delete.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_delete.Location = new System.Drawing.Point(109, 445);
            this.btn_doctor_delete.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_doctor_delete.Name = "btn_doctor_delete";
            this.btn_doctor_delete.Size = new System.Drawing.Size(423, 72);
            this.btn_doctor_delete.TabIndex = 45;
            this.btn_doctor_delete.Text = "Doctor Info Delete";
            this.btn_doctor_delete.UseVisualStyleBackColor = false;
            this.btn_doctor_delete.Click += new System.EventHandler(this.btn_doctor_delete_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Navy;
            this.textBox5.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Location = new System.Drawing.Point(12, 2);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1139, 60);
            this.textBox5.TabIndex = 44;
            this.textBox5.Text = "Doctor\'s Details";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_doctor_display
            // 
            this.btn_doctor_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_doctor_display.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_display.ForeColor = System.Drawing.Color.White;
            this.btn_doctor_display.Location = new System.Drawing.Point(109, 235);
            this.btn_doctor_display.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_doctor_display.Name = "btn_doctor_display";
            this.btn_doctor_display.Size = new System.Drawing.Size(423, 69);
            this.btn_doctor_display.TabIndex = 43;
            this.btn_doctor_display.Text = "Doctor Information";
            this.btn_doctor_display.UseVisualStyleBackColor = false;
            this.btn_doctor_display.Click += new System.EventHandler(this.btn_doctor_display_Click);
            // 
            // btn_doctor_registration
            // 
            this.btn_doctor_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_doctor_registration.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_registration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor_registration.Location = new System.Drawing.Point(109, 130);
            this.btn_doctor_registration.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_doctor_registration.Name = "btn_doctor_registration";
            this.btn_doctor_registration.Size = new System.Drawing.Size(423, 67);
            this.btn_doctor_registration.TabIndex = 42;
            this.btn_doctor_registration.Text = "Doctor Registration";
            this.btn_doctor_registration.UseVisualStyleBackColor = false;
            this.btn_doctor_registration.Click += new System.EventHandler(this.btn_doctor_registration_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 669);
            this.Controls.Add(this.btn_doctordetails_exit);
            this.Controls.Add(this.btn_doctor_update);
            this.Controls.Add(this.lbl_patient_updstecolor);
            this.Controls.Add(this.lbl_patient_deletecolor);
            this.Controls.Add(this.lbl_patient_infocolor);
            this.Controls.Add(this.lbl_patient_regiscolor);
            this.Controls.Add(this.btn_doctor_delete);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_doctor_display);
            this.Controls.Add(this.btn_doctor_registration);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_doctordetails_exit;
        private System.Windows.Forms.Button btn_doctor_update;
        private System.Windows.Forms.Label lbl_patient_updstecolor;
        private System.Windows.Forms.Label lbl_patient_deletecolor;
        private System.Windows.Forms.Label lbl_patient_infocolor;
        private System.Windows.Forms.Label lbl_patient_regiscolor;
        private System.Windows.Forms.Button btn_doctor_delete;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_doctor_display;
        private System.Windows.Forms.Button btn_doctor_registration;
    }
}