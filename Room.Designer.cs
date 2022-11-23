
namespace GUI__group_final_project
{
    partial class Room
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
            this.btn_room_display = new System.Windows.Forms.Button();
            this.btn_room_update = new System.Windows.Forms.Button();
            this.btn_room_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.dgv_room = new System.Windows.Forms.DataGridView();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.cmb_room_type = new System.Windows.Forms.ComboBox();
            this.txt_room_status = new System.Windows.Forms.TextBox();
            this.txt_room_price = new System.Windows.Forms.TextBox();
            this.txt_room_numberofbed = new System.Windows.Forms.TextBox();
            this.lbl_room_status = new System.Windows.Forms.Label();
            this.lbl_room_price = new System.Windows.Forms.Label();
            this.lbl_room_numberofbed = new System.Windows.Forms.Label();
            this.lbl_building_no = new System.Windows.Forms.Label();
            this.btn_room_exit = new System.Windows.Forms.Button();
            this.btn_room_clear = new System.Windows.Forms.Button();
            this.btn_room_save = new System.Windows.Forms.Button();
            this.txt_building_no = new System.Windows.Forms.ComboBox();
            this.errorProvider_room = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_room)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_room_display
            // 
            this.btn_room_display.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_room_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_room_display.Location = new System.Drawing.Point(232, 466);
            this.btn_room_display.Name = "btn_room_display";
            this.btn_room_display.Size = new System.Drawing.Size(92, 49);
            this.btn_room_display.TabIndex = 191;
            this.btn_room_display.Text = "Display";
            this.btn_room_display.UseVisualStyleBackColor = false;
            this.btn_room_display.Click += new System.EventHandler(this.btn_room_display_Click);
            // 
            // btn_room_update
            // 
            this.btn_room_update.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_room_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_room_update.Location = new System.Drawing.Point(371, 466);
            this.btn_room_update.Name = "btn_room_update";
            this.btn_room_update.Size = new System.Drawing.Size(90, 49);
            this.btn_room_update.TabIndex = 190;
            this.btn_room_update.Text = "Update";
            this.btn_room_update.UseVisualStyleBackColor = false;
            this.btn_room_update.Click += new System.EventHandler(this.btn_room_update_Click);
            // 
            // btn_room_delete
            // 
            this.btn_room_delete.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_room_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_room_delete.Location = new System.Drawing.Point(84, 536);
            this.btn_room_delete.Name = "btn_room_delete";
            this.btn_room_delete.Size = new System.Drawing.Size(88, 46);
            this.btn_room_delete.TabIndex = 189;
            this.btn_room_delete.Text = "Delete";
            this.btn_room_delete.UseVisualStyleBackColor = false;
            this.btn_room_delete.Click += new System.EventHandler(this.btn_room_delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1304, 61);
            this.button1.TabIndex = 186;
            this.button1.Text = "Room\'s Information";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_room_type.Location = new System.Drawing.Point(47, 241);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(103, 20);
            this.lbl_room_type.TabIndex = 185;
            this.lbl_room_type.Text = "Room Type";
            // 
            // dgv_room
            // 
            this.dgv_room.BackgroundColor = System.Drawing.Color.White;
            this.dgv_room.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_room.ColumnHeadersHeight = 30;
            this.dgv_room.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_room.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_room.GridColor = System.Drawing.Color.Black;
            this.dgv_room.Location = new System.Drawing.Point(635, 148);
            this.dgv_room.Name = "dgv_room";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_room.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_room.RowHeadersWidth = 24;
            this.dgv_room.RowTemplate.Height = 24;
            this.dgv_room.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_room.Size = new System.Drawing.Size(673, 533);
            this.dgv_room.TabIndex = 184;
            this.dgv_room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_room_CellClick);
            // 
            // txt_room_no
            // 
            this.txt_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.Location = new System.Drawing.Point(244, 146);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.Size = new System.Drawing.Size(227, 27);
            this.txt_room_no.TabIndex = 183;
            this.txt_room_no.Validating += new System.ComponentModel.CancelEventHandler(this.txt_room_no_Validating);
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_room_no.Location = new System.Drawing.Point(47, 148);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(86, 20);
            this.lbl_room_no.TabIndex = 182;
            this.lbl_room_no.Text = "Room No";
            // 
            // cmb_room_type
            // 
            this.cmb_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_room_type.FormattingEnabled = true;
            this.cmb_room_type.Items.AddRange(new object[] {
            "Normal",
            "Medium",
            "VIP"});
            this.cmb_room_type.Location = new System.Drawing.Point(244, 237);
            this.cmb_room_type.Name = "cmb_room_type";
            this.cmb_room_type.Size = new System.Drawing.Size(227, 28);
            this.cmb_room_type.TabIndex = 181;
            this.cmb_room_type.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_room_type_Validating);
            // 
            // txt_room_status
            // 
            this.txt_room_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_status.Location = new System.Drawing.Point(244, 362);
            this.txt_room_status.Name = "txt_room_status";
            this.txt_room_status.Size = new System.Drawing.Size(227, 27);
            this.txt_room_status.TabIndex = 180;
            // 
            // txt_room_price
            // 
            this.txt_room_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_price.Location = new System.Drawing.Point(244, 323);
            this.txt_room_price.Name = "txt_room_price";
            this.txt_room_price.Size = new System.Drawing.Size(227, 27);
            this.txt_room_price.TabIndex = 178;
            // 
            // txt_room_numberofbed
            // 
            this.txt_room_numberofbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_numberofbed.Location = new System.Drawing.Point(244, 282);
            this.txt_room_numberofbed.Name = "txt_room_numberofbed";
            this.txt_room_numberofbed.Size = new System.Drawing.Size(227, 27);
            this.txt_room_numberofbed.TabIndex = 177;
            // 
            // lbl_room_status
            // 
            this.lbl_room_status.AutoSize = true;
            this.lbl_room_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_status.ForeColor = System.Drawing.Color.Black;
            this.lbl_room_status.Location = new System.Drawing.Point(47, 364);
            this.lbl_room_status.Name = "lbl_room_status";
            this.lbl_room_status.Size = new System.Drawing.Size(63, 20);
            this.lbl_room_status.TabIndex = 174;
            this.lbl_room_status.Text = "Status";
            // 
            // lbl_room_price
            // 
            this.lbl_room_price.AutoSize = true;
            this.lbl_room_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_price.ForeColor = System.Drawing.Color.Black;
            this.lbl_room_price.Location = new System.Drawing.Point(47, 325);
            this.lbl_room_price.Name = "lbl_room_price";
            this.lbl_room_price.Size = new System.Drawing.Size(53, 20);
            this.lbl_room_price.TabIndex = 170;
            this.lbl_room_price.Text = "Price";
            // 
            // lbl_room_numberofbed
            // 
            this.lbl_room_numberofbed.AutoSize = true;
            this.lbl_room_numberofbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_numberofbed.ForeColor = System.Drawing.Color.Black;
            this.lbl_room_numberofbed.Location = new System.Drawing.Point(47, 284);
            this.lbl_room_numberofbed.Name = "lbl_room_numberofbed";
            this.lbl_room_numberofbed.Size = new System.Drawing.Size(139, 20);
            this.lbl_room_numberofbed.TabIndex = 169;
            this.lbl_room_numberofbed.Text = "Number Of Bed";
            // 
            // lbl_building_no
            // 
            this.lbl_building_no.AutoSize = true;
            this.lbl_building_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_building_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_building_no.Location = new System.Drawing.Point(47, 195);
            this.lbl_building_no.Name = "lbl_building_no";
            this.lbl_building_no.Size = new System.Drawing.Size(106, 20);
            this.lbl_building_no.TabIndex = 167;
            this.lbl_building_no.Text = "Building No";
            // 
            // btn_room_exit
            // 
            this.btn_room_exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_room_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_room_exit.Location = new System.Drawing.Point(367, 535);
            this.btn_room_exit.Name = "btn_room_exit";
            this.btn_room_exit.Size = new System.Drawing.Size(94, 49);
            this.btn_room_exit.TabIndex = 166;
            this.btn_room_exit.Text = "Exit";
            this.btn_room_exit.UseVisualStyleBackColor = false;
            this.btn_room_exit.Click += new System.EventHandler(this.btn_staff_exit_Click);
            // 
            // btn_room_clear
            // 
            this.btn_room_clear.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_room_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_room_clear.Location = new System.Drawing.Point(234, 534);
            this.btn_room_clear.Name = "btn_room_clear";
            this.btn_room_clear.Size = new System.Drawing.Size(90, 49);
            this.btn_room_clear.TabIndex = 165;
            this.btn_room_clear.Text = "Clear";
            this.btn_room_clear.UseVisualStyleBackColor = false;
            this.btn_room_clear.Click += new System.EventHandler(this.btn_room_clear_Click);
            // 
            // btn_room_save
            // 
            this.btn_room_save.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_room_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_room_save.Location = new System.Drawing.Point(84, 466);
            this.btn_room_save.Name = "btn_room_save";
            this.btn_room_save.Size = new System.Drawing.Size(87, 49);
            this.btn_room_save.TabIndex = 164;
            this.btn_room_save.Text = "Save";
            this.btn_room_save.UseVisualStyleBackColor = false;
            this.btn_room_save.Click += new System.EventHandler(this.btn_room_save_Click);
            // 
            // txt_building_no
            // 
            this.txt_building_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_building_no.FormattingEnabled = true;
            this.txt_building_no.Items.AddRange(new object[] {
            "B-01",
            "B-02",
            "B-03",
            "B-04",
            "B-05"});
            this.txt_building_no.Location = new System.Drawing.Point(244, 191);
            this.txt_building_no.Name = "txt_building_no";
            this.txt_building_no.Size = new System.Drawing.Size(227, 28);
            this.txt_building_no.TabIndex = 192;
            this.txt_building_no.Validating += new System.ComponentModel.CancelEventHandler(this.txt_building_no_Validating);
            // 
            // errorProvider_room
            // 
            this.errorProvider_room.ContainerControl = this;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(232, 607);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 49);
            this.btn_search.TabIndex = 193;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 693);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_building_no);
            this.Controls.Add(this.btn_room_display);
            this.Controls.Add(this.btn_room_update);
            this.Controls.Add(this.btn_room_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_room_type);
            this.Controls.Add(this.dgv_room);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.lbl_room_no);
            this.Controls.Add(this.cmb_room_type);
            this.Controls.Add(this.txt_room_status);
            this.Controls.Add(this.txt_room_price);
            this.Controls.Add(this.txt_room_numberofbed);
            this.Controls.Add(this.lbl_room_status);
            this.Controls.Add(this.lbl_room_price);
            this.Controls.Add(this.lbl_room_numberofbed);
            this.Controls.Add(this.lbl_building_no);
            this.Controls.Add(this.btn_room_exit);
            this.Controls.Add(this.btn_room_clear);
            this.Controls.Add(this.btn_room_save);
            this.Name = "Room";
            this.Text = "Room";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_room_display;
        private System.Windows.Forms.Button btn_room_update;
        private System.Windows.Forms.Button btn_room_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.DataGridView dgv_room;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.ComboBox cmb_room_type;
        private System.Windows.Forms.TextBox txt_room_status;
        private System.Windows.Forms.TextBox txt_room_price;
        private System.Windows.Forms.TextBox txt_room_numberofbed;
        private System.Windows.Forms.Label lbl_room_status;
        private System.Windows.Forms.Label lbl_room_price;
        private System.Windows.Forms.Label lbl_room_numberofbed;
        private System.Windows.Forms.Label lbl_building_no;
        private System.Windows.Forms.Button btn_room_exit;
        private System.Windows.Forms.Button btn_room_clear;
        private System.Windows.Forms.Button btn_room_save;
        private System.Windows.Forms.ComboBox txt_building_no;
        private System.Windows.Forms.ErrorProvider errorProvider_room;
        private System.Windows.Forms.Button btn_search;
    }
}