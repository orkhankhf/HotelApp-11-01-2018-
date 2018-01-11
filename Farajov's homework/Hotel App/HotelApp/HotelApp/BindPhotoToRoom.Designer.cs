namespace HotelApp
{
    partial class BindPhotoToRoom
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
            this.bind_btn = new System.Windows.Forms.Button();
            this.bind_room_to_photo_photo_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bind_room_to_photo_room_number = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selected_photo_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.selected_photo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // bind_btn
            // 
            this.bind_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.bind_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.bind_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bind_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.bind_btn.Location = new System.Drawing.Point(137, 60);
            this.bind_btn.Name = "bind_btn";
            this.bind_btn.Size = new System.Drawing.Size(158, 28);
            this.bind_btn.TabIndex = 20;
            this.bind_btn.Text = "Bind";
            this.bind_btn.UseVisualStyleBackColor = false;
            this.bind_btn.Click += new System.EventHandler(this.bind_btn_Click);
            // 
            // bind_room_to_photo_photo_name
            // 
            this.bind_room_to_photo_photo_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bind_room_to_photo_photo_name.FormattingEnabled = true;
            this.bind_room_to_photo_photo_name.Location = new System.Drawing.Point(137, 33);
            this.bind_room_to_photo_photo_name.Name = "bind_room_to_photo_photo_name";
            this.bind_room_to_photo_photo_name.Size = new System.Drawing.Size(158, 21);
            this.bind_room_to_photo_photo_name.Sorted = true;
            this.bind_room_to_photo_photo_name.TabIndex = 19;
            this.bind_room_to_photo_photo_name.SelectedIndexChanged += new System.EventHandler(this.bind_room_to_photo_photo_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Photo Name";
            // 
            // bind_room_to_photo_room_number
            // 
            this.bind_room_to_photo_room_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bind_room_to_photo_room_number.FormattingEnabled = true;
            this.bind_room_to_photo_room_number.Location = new System.Drawing.Point(137, 6);
            this.bind_room_to_photo_room_number.Name = "bind_room_to_photo_room_number";
            this.bind_room_to_photo_room_number.Size = new System.Drawing.Size(158, 21);
            this.bind_room_to_photo_room_number.Sorted = true;
            this.bind_room_to_photo_room_number.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Room Number";
            // 
            // selected_photo_picturebox
            // 
            this.selected_photo_picturebox.Location = new System.Drawing.Point(12, 104);
            this.selected_photo_picturebox.Name = "selected_photo_picturebox";
            this.selected_photo_picturebox.Size = new System.Drawing.Size(544, 209);
            this.selected_photo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selected_photo_picturebox.TabIndex = 21;
            this.selected_photo_picturebox.TabStop = false;
            // 
            // BindPhotoToRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 325);
            this.Controls.Add(this.selected_photo_picturebox);
            this.Controls.Add(this.bind_btn);
            this.Controls.Add(this.bind_room_to_photo_photo_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bind_room_to_photo_room_number);
            this.Controls.Add(this.label2);
            this.Name = "BindPhotoToRoom";
            this.Text = "Bind Photo To Room";
            this.Load += new System.EventHandler(this.BindPhotoToRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selected_photo_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bind_btn;
        private System.Windows.Forms.ComboBox bind_room_to_photo_photo_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bind_room_to_photo_room_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox selected_photo_picturebox;
    }
}