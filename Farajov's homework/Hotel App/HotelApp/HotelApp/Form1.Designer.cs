namespace HotelApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_room_number = new System.Windows.Forms.TextBox();
            this.add_room_type = new System.Windows.Forms.ComboBox();
            this.add_room_bed_count = new System.Windows.Forms.TextBox();
            this.add_room_price = new System.Windows.Forms.TextBox();
            this.add_room_reservation_status = new System.Windows.Forms.ComboBox();
            this.add_room_cleaning_status = new System.Windows.Forms.ComboBox();
            this.add_room_room_status = new System.Windows.Forms.ComboBox();
            this.add_room_btn = new System.Windows.Forms.Button();
            this.add_new_photo_btn = new System.Windows.Forms.Button();
            this.add_new_type_btn = new System.Windows.Forms.Button();
            this.add_new_detail_btn = new System.Windows.Forms.Button();
            this.bind_detail_to_room_btn = new System.Windows.Forms.Button();
            this.bind_photo_to_room_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bed Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reservation Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cleaning Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room Status";
            // 
            // add_room_number
            // 
            this.add_room_number.Location = new System.Drawing.Point(137, 6);
            this.add_room_number.Name = "add_room_number";
            this.add_room_number.Size = new System.Drawing.Size(158, 20);
            this.add_room_number.TabIndex = 7;
            // 
            // add_room_type
            // 
            this.add_room_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_room_type.FormattingEnabled = true;
            this.add_room_type.Location = new System.Drawing.Point(137, 36);
            this.add_room_type.Name = "add_room_type";
            this.add_room_type.Size = new System.Drawing.Size(158, 21);
            this.add_room_type.Sorted = true;
            this.add_room_type.TabIndex = 8;
            // 
            // add_room_bed_count
            // 
            this.add_room_bed_count.Location = new System.Drawing.Point(137, 66);
            this.add_room_bed_count.Name = "add_room_bed_count";
            this.add_room_bed_count.Size = new System.Drawing.Size(158, 20);
            this.add_room_bed_count.TabIndex = 9;
            // 
            // add_room_price
            // 
            this.add_room_price.Location = new System.Drawing.Point(137, 96);
            this.add_room_price.Name = "add_room_price";
            this.add_room_price.Size = new System.Drawing.Size(158, 20);
            this.add_room_price.TabIndex = 10;
            // 
            // add_room_reservation_status
            // 
            this.add_room_reservation_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_room_reservation_status.FormattingEnabled = true;
            this.add_room_reservation_status.Items.AddRange(new object[] {
            "False",
            "True"});
            this.add_room_reservation_status.Location = new System.Drawing.Point(137, 126);
            this.add_room_reservation_status.Name = "add_room_reservation_status";
            this.add_room_reservation_status.Size = new System.Drawing.Size(158, 21);
            this.add_room_reservation_status.Sorted = true;
            this.add_room_reservation_status.TabIndex = 11;
            // 
            // add_room_cleaning_status
            // 
            this.add_room_cleaning_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_room_cleaning_status.FormattingEnabled = true;
            this.add_room_cleaning_status.Items.AddRange(new object[] {
            "False",
            "True"});
            this.add_room_cleaning_status.Location = new System.Drawing.Point(137, 156);
            this.add_room_cleaning_status.Name = "add_room_cleaning_status";
            this.add_room_cleaning_status.Size = new System.Drawing.Size(158, 21);
            this.add_room_cleaning_status.Sorted = true;
            this.add_room_cleaning_status.TabIndex = 12;
            // 
            // add_room_room_status
            // 
            this.add_room_room_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_room_room_status.FormattingEnabled = true;
            this.add_room_room_status.Items.AddRange(new object[] {
            "False",
            "True"});
            this.add_room_room_status.Location = new System.Drawing.Point(137, 186);
            this.add_room_room_status.Name = "add_room_room_status";
            this.add_room_room_status.Size = new System.Drawing.Size(158, 21);
            this.add_room_room_status.Sorted = true;
            this.add_room_room_status.TabIndex = 13;
            // 
            // add_room_btn
            // 
            this.add_room_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.add_room_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_room_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_room_btn.Location = new System.Drawing.Point(137, 213);
            this.add_room_btn.Name = "add_room_btn";
            this.add_room_btn.Size = new System.Drawing.Size(158, 28);
            this.add_room_btn.TabIndex = 14;
            this.add_room_btn.Text = "Add Room";
            this.add_room_btn.UseVisualStyleBackColor = false;
            this.add_room_btn.Click += new System.EventHandler(this.add_room_btn_Click);
            // 
            // add_new_photo_btn
            // 
            this.add_new_photo_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.add_new_photo_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_new_photo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_photo_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_new_photo_btn.Location = new System.Drawing.Point(393, 6);
            this.add_new_photo_btn.Name = "add_new_photo_btn";
            this.add_new_photo_btn.Size = new System.Drawing.Size(158, 30);
            this.add_new_photo_btn.TabIndex = 15;
            this.add_new_photo_btn.Text = "Add New Photo";
            this.add_new_photo_btn.UseVisualStyleBackColor = false;
            this.add_new_photo_btn.Click += new System.EventHandler(this.add_new_photo_btn_Click);
            // 
            // add_new_type_btn
            // 
            this.add_new_type_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.add_new_type_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_new_type_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_type_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_new_type_btn.Location = new System.Drawing.Point(393, 86);
            this.add_new_type_btn.Name = "add_new_type_btn";
            this.add_new_type_btn.Size = new System.Drawing.Size(158, 30);
            this.add_new_type_btn.TabIndex = 17;
            this.add_new_type_btn.Text = "Add New Type";
            this.add_new_type_btn.UseVisualStyleBackColor = false;
            this.add_new_type_btn.Click += new System.EventHandler(this.add_new_type_btn_Click);
            // 
            // add_new_detail_btn
            // 
            this.add_new_detail_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.add_new_detail_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_new_detail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_detail_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_new_detail_btn.Location = new System.Drawing.Point(393, 46);
            this.add_new_detail_btn.Name = "add_new_detail_btn";
            this.add_new_detail_btn.Size = new System.Drawing.Size(158, 30);
            this.add_new_detail_btn.TabIndex = 16;
            this.add_new_detail_btn.Text = "Add New Detail";
            this.add_new_detail_btn.UseVisualStyleBackColor = false;
            this.add_new_detail_btn.Click += new System.EventHandler(this.add_new_detail_btn_Click);
            // 
            // bind_detail_to_room_btn
            // 
            this.bind_detail_to_room_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.bind_detail_to_room_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.bind_detail_to_room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bind_detail_to_room_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.bind_detail_to_room_btn.Location = new System.Drawing.Point(393, 126);
            this.bind_detail_to_room_btn.Name = "bind_detail_to_room_btn";
            this.bind_detail_to_room_btn.Size = new System.Drawing.Size(158, 30);
            this.bind_detail_to_room_btn.TabIndex = 18;
            this.bind_detail_to_room_btn.Text = "Bind Detail To Room";
            this.bind_detail_to_room_btn.UseVisualStyleBackColor = false;
            this.bind_detail_to_room_btn.Click += new System.EventHandler(this.bind_detail_to_room_btn_Click);
            // 
            // bind_photo_to_room_btn
            // 
            this.bind_photo_to_room_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.bind_photo_to_room_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.bind_photo_to_room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bind_photo_to_room_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.bind_photo_to_room_btn.Location = new System.Drawing.Point(393, 166);
            this.bind_photo_to_room_btn.Name = "bind_photo_to_room_btn";
            this.bind_photo_to_room_btn.Size = new System.Drawing.Size(158, 30);
            this.bind_photo_to_room_btn.TabIndex = 19;
            this.bind_photo_to_room_btn.Text = "Bind Photo To Room";
            this.bind_photo_to_room_btn.UseVisualStyleBackColor = false;
            this.bind_photo_to_room_btn.Click += new System.EventHandler(this.bind_photo_to_room_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 325);
            this.Controls.Add(this.bind_photo_to_room_btn);
            this.Controls.Add(this.bind_detail_to_room_btn);
            this.Controls.Add(this.add_new_detail_btn);
            this.Controls.Add(this.add_new_type_btn);
            this.Controls.Add(this.add_new_photo_btn);
            this.Controls.Add(this.add_room_btn);
            this.Controls.Add(this.add_room_room_status);
            this.Controls.Add(this.add_room_cleaning_status);
            this.Controls.Add(this.add_room_reservation_status);
            this.Controls.Add(this.add_room_price);
            this.Controls.Add(this.add_room_bed_count);
            this.Controls.Add(this.add_room_type);
            this.Controls.Add(this.add_room_number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox add_room_number;
        private System.Windows.Forms.ComboBox add_room_type;
        private System.Windows.Forms.TextBox add_room_bed_count;
        private System.Windows.Forms.TextBox add_room_price;
        private System.Windows.Forms.ComboBox add_room_reservation_status;
        private System.Windows.Forms.ComboBox add_room_cleaning_status;
        private System.Windows.Forms.ComboBox add_room_room_status;
        private System.Windows.Forms.Button add_room_btn;
        private System.Windows.Forms.Button add_new_photo_btn;
        private System.Windows.Forms.Button add_new_type_btn;
        private System.Windows.Forms.Button add_new_detail_btn;
        private System.Windows.Forms.Button bind_detail_to_room_btn;
        private System.Windows.Forms.Button bind_photo_to_room_btn;
    }
}

