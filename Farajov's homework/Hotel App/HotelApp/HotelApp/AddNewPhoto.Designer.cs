namespace HotelApp
{
    partial class AddNewPhoto
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
            this.select_photo_btn = new System.Windows.Forms.Button();
            this.add_photo_btn = new System.Windows.Forms.Button();
            this.selected_photo_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.selected_photo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // select_photo_btn
            // 
            this.select_photo_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.select_photo_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.select_photo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_photo_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.select_photo_btn.Location = new System.Drawing.Point(12, 12);
            this.select_photo_btn.Name = "select_photo_btn";
            this.select_photo_btn.Size = new System.Drawing.Size(158, 30);
            this.select_photo_btn.TabIndex = 0;
            this.select_photo_btn.Text = "Select Photo";
            this.select_photo_btn.UseVisualStyleBackColor = false;
            this.select_photo_btn.Click += new System.EventHandler(this.select_photo_btn_Click);
            // 
            // add_photo_btn
            // 
            this.add_photo_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.add_photo_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_photo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_photo_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_photo_btn.Location = new System.Drawing.Point(176, 12);
            this.add_photo_btn.Name = "add_photo_btn";
            this.add_photo_btn.Size = new System.Drawing.Size(158, 30);
            this.add_photo_btn.TabIndex = 1;
            this.add_photo_btn.Text = "Add Photo";
            this.add_photo_btn.UseVisualStyleBackColor = false;
            this.add_photo_btn.Click += new System.EventHandler(this.add_photo_btn_Click);
            // 
            // selected_photo_picturebox
            // 
            this.selected_photo_picturebox.Location = new System.Drawing.Point(12, 48);
            this.selected_photo_picturebox.Name = "selected_photo_picturebox";
            this.selected_photo_picturebox.Size = new System.Drawing.Size(544, 265);
            this.selected_photo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selected_photo_picturebox.TabIndex = 2;
            this.selected_photo_picturebox.TabStop = false;
            // 
            // AddNewPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 325);
            this.Controls.Add(this.selected_photo_picturebox);
            this.Controls.Add(this.add_photo_btn);
            this.Controls.Add(this.select_photo_btn);
            this.Name = "AddNewPhoto";
            this.Text = "Add New Photo";
            ((System.ComponentModel.ISupportInitialize)(this.selected_photo_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button select_photo_btn;
        private System.Windows.Forms.Button add_photo_btn;
        private System.Windows.Forms.PictureBox selected_photo_picturebox;
    }
}