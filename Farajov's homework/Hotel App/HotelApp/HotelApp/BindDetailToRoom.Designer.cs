namespace HotelApp
{
    partial class BindDetailToRoom
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
            this.bind_room_to_detail_room_number = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bind_room_to_detail_detail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bind_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bind_room_to_detail_room_number
            // 
            this.bind_room_to_detail_room_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bind_room_to_detail_room_number.FormattingEnabled = true;
            this.bind_room_to_detail_room_number.Location = new System.Drawing.Point(137, 6);
            this.bind_room_to_detail_room_number.Name = "bind_room_to_detail_room_number";
            this.bind_room_to_detail_room_number.Size = new System.Drawing.Size(158, 21);
            this.bind_room_to_detail_room_number.Sorted = true;
            this.bind_room_to_detail_room_number.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Room Number";
            // 
            // bind_room_to_detail_detail
            // 
            this.bind_room_to_detail_detail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bind_room_to_detail_detail.FormattingEnabled = true;
            this.bind_room_to_detail_detail.Location = new System.Drawing.Point(137, 33);
            this.bind_room_to_detail_detail.Name = "bind_room_to_detail_detail";
            this.bind_room_to_detail_detail.Size = new System.Drawing.Size(158, 21);
            this.bind_room_to_detail_detail.Sorted = true;
            this.bind_room_to_detail_detail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detail";
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
            this.bind_btn.TabIndex = 15;
            this.bind_btn.Text = "Bind";
            this.bind_btn.UseVisualStyleBackColor = false;
            this.bind_btn.Click += new System.EventHandler(this.bind_btn_Click);
            // 
            // BindDetailToRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 325);
            this.Controls.Add(this.bind_btn);
            this.Controls.Add(this.bind_room_to_detail_detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bind_room_to_detail_room_number);
            this.Controls.Add(this.label2);
            this.Name = "BindDetailToRoom";
            this.Text = "BindDetailToRoom";
            this.Load += new System.EventHandler(this.BindDetailToRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bind_room_to_detail_room_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bind_room_to_detail_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bind_btn;
    }
}