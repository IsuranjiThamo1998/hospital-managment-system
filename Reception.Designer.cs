
namespace GUI__group_final_project
{
    partial class Reception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception));
            this.btn_menu_patient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_menu_bill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_menu_patient
            // 
            this.btn_menu_patient.BackColor = System.Drawing.Color.Red;
            this.btn_menu_patient.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_patient.ForeColor = System.Drawing.Color.White;
            this.btn_menu_patient.Location = new System.Drawing.Point(337, 277);
            this.btn_menu_patient.Name = "btn_menu_patient";
            this.btn_menu_patient.Size = new System.Drawing.Size(186, 145);
            this.btn_menu_patient.TabIndex = 45;
            this.btn_menu_patient.Text = "Patient";
            this.btn_menu_patient.UseVisualStyleBackColor = false;
            this.btn_menu_patient.Click += new System.EventHandler(this.btn_menu_patient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(799, 542);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(116, 65);
            this.btn_exit.TabIndex = 49;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_menu_bill
            // 
            this.btn_menu_bill.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_menu_bill.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_bill.ForeColor = System.Drawing.Color.White;
            this.btn_menu_bill.Location = new System.Drawing.Point(613, 281);
            this.btn_menu_bill.Name = "btn_menu_bill";
            this.btn_menu_bill.Size = new System.Drawing.Size(183, 141);
            this.btn_menu_bill.TabIndex = 50;
            this.btn_menu_bill.Text = "Bill";
            this.btn_menu_bill.UseVisualStyleBackColor = false;
            this.btn_menu_bill.Click += new System.EventHandler(this.btn_menu_bill_Click_1);
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1170, 677);
            this.Controls.Add(this.btn_menu_bill);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_menu_patient);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reception";
            this.Text = "Reception";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menu_patient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_menu_bill;
    }
}