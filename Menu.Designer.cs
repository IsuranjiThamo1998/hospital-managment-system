
namespace GUI__group_final_project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu_bill = new System.Windows.Forms.Button();
            this.btn_menu_room = new System.Windows.Forms.Button();
            this.btn_menu_staff = new System.Windows.Forms.Button();
            this.btn_menu_patient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_menu_exit = new System.Windows.Forms.Button();
            this.btn_menu_doctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1126, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_menu_bill
            // 
            this.btn_menu_bill.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_menu_bill.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_bill.ForeColor = System.Drawing.Color.White;
            this.btn_menu_bill.Location = new System.Drawing.Point(850, 512);
            this.btn_menu_bill.Name = "btn_menu_bill";
            this.btn_menu_bill.Size = new System.Drawing.Size(183, 141);
            this.btn_menu_bill.TabIndex = 37;
            this.btn_menu_bill.Text = "Bill";
            this.btn_menu_bill.UseVisualStyleBackColor = false;
            this.btn_menu_bill.Click += new System.EventHandler(this.btn_menu_bill_Click);
            // 
            // btn_menu_room
            // 
            this.btn_menu_room.BackColor = System.Drawing.Color.DeepPink;
            this.btn_menu_room.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_room.ForeColor = System.Drawing.Color.White;
            this.btn_menu_room.Location = new System.Drawing.Point(649, 510);
            this.btn_menu_room.Name = "btn_menu_room";
            this.btn_menu_room.Size = new System.Drawing.Size(180, 141);
            this.btn_menu_room.TabIndex = 36;
            this.btn_menu_room.Text = "Room";
            this.btn_menu_room.UseVisualStyleBackColor = false;
            this.btn_menu_room.Click += new System.EventHandler(this.btn_menu_room_Click);
            // 
            // btn_menu_staff
            // 
            this.btn_menu_staff.BackColor = System.Drawing.Color.Green;
            this.btn_menu_staff.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_staff.ForeColor = System.Drawing.Color.White;
            this.btn_menu_staff.Location = new System.Drawing.Point(438, 510);
            this.btn_menu_staff.Name = "btn_menu_staff";
            this.btn_menu_staff.Size = new System.Drawing.Size(186, 144);
            this.btn_menu_staff.TabIndex = 35;
            this.btn_menu_staff.Text = "Staff";
            this.btn_menu_staff.UseVisualStyleBackColor = false;
            this.btn_menu_staff.Click += new System.EventHandler(this.btn_menu_staff_Click);
            // 
            // btn_menu_patient
            // 
            this.btn_menu_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_menu_patient.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_patient.ForeColor = System.Drawing.Color.White;
            this.btn_menu_patient.Location = new System.Drawing.Point(229, 510);
            this.btn_menu_patient.Name = "btn_menu_patient";
            this.btn_menu_patient.Size = new System.Drawing.Size(186, 145);
            this.btn_menu_patient.TabIndex = 34;
            this.btn_menu_patient.Text = "Patient";
            this.btn_menu_patient.UseVisualStyleBackColor = false;
            this.btn_menu_patient.Click += new System.EventHandler(this.btn_menu_patient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 69);
            this.panel1.TabIndex = 41;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Navy;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Palatino Linotype", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(586, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(449, 75);
            this.textBox3.TabIndex = 47;
            this.textBox3.Text = "City Hospital";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Navy;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Palatino Linotype", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(388, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 72);
            this.textBox4.TabIndex = 46;
            this.textBox4.Text = "To The";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(127, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 72);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "Welcome";
            // 
            // btn_menu_exit
            // 
            this.btn_menu_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_menu_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu_exit.Location = new System.Drawing.Point(1051, 546);
            this.btn_menu_exit.Name = "btn_menu_exit";
            this.btn_menu_exit.Size = new System.Drawing.Size(87, 53);
            this.btn_menu_exit.TabIndex = 42;
            this.btn_menu_exit.Text = "Exit";
            this.btn_menu_exit.UseVisualStyleBackColor = false;
            this.btn_menu_exit.Click += new System.EventHandler(this.btn_menu_exit_Click);
            // 
            // btn_menu_doctor
            // 
            this.btn_menu_doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_menu_doctor.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_doctor.ForeColor = System.Drawing.Color.White;
            this.btn_menu_doctor.Location = new System.Drawing.Point(22, 508);
            this.btn_menu_doctor.Name = "btn_menu_doctor";
            this.btn_menu_doctor.Size = new System.Drawing.Size(181, 149);
            this.btn_menu_doctor.TabIndex = 43;
            this.btn_menu_doctor.Text = "Doctor";
            this.btn_menu_doctor.UseVisualStyleBackColor = false;
            this.btn_menu_doctor.Click += new System.EventHandler(this.btn_menu_doctor_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 663);
            this.Controls.Add(this.btn_menu_doctor);
            this.Controls.Add(this.btn_menu_exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_menu_bill);
            this.Controls.Add(this.btn_menu_room);
            this.Controls.Add(this.btn_menu_staff);
            this.Controls.Add(this.btn_menu_patient);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_menu_bill;
        private System.Windows.Forms.Button btn_menu_room;
        private System.Windows.Forms.Button btn_menu_staff;
        private System.Windows.Forms.Button btn_menu_patient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_menu_exit;
        private System.Windows.Forms.Button btn_menu_doctor;
    }
}