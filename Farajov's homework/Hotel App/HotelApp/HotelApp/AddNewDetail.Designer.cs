namespace HotelApp
{
    partial class AddNewDetail
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
            this.add_detail_name = new System.Windows.Forms.TextBox();
            this.add_detail_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Name";
            // 
            // add_detail_name
            // 
            this.add_detail_name.Location = new System.Drawing.Point(83, 6);
            this.add_detail_name.Name = "add_detail_name";
            this.add_detail_name.Size = new System.Drawing.Size(158, 20);
            this.add_detail_name.TabIndex = 1;
            // 
            // add_detail_btn
            // 
            this.add_detail_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.add_detail_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_detail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_detail_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_detail_btn.Location = new System.Drawing.Point(83, 32);
            this.add_detail_btn.Name = "add_detail_btn";
            this.add_detail_btn.Size = new System.Drawing.Size(158, 28);
            this.add_detail_btn.TabIndex = 14;
            this.add_detail_btn.Text = "Add Detail";
            this.add_detail_btn.UseVisualStyleBackColor = false;
            this.add_detail_btn.Click += new System.EventHandler(this.add_detail_btn_Click);
            // 
            // AddNewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 325);
            this.Controls.Add(this.add_detail_btn);
            this.Controls.Add(this.add_detail_name);
            this.Controls.Add(this.label1);
            this.Name = "AddNewDetail";
            this.Text = "Add New Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox add_detail_name;
        private System.Windows.Forms.Button add_detail_btn;
    }
}