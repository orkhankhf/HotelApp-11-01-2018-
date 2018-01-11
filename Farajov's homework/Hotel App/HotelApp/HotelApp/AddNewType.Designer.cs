namespace HotelApp
{
    partial class AddNewType
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
            this.add_type_btn = new System.Windows.Forms.Button();
            this.add_type_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_type_btn
            // 
            this.add_type_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.add_type_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_type_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_type_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_type_btn.Location = new System.Drawing.Point(83, 32);
            this.add_type_btn.Name = "add_type_btn";
            this.add_type_btn.Size = new System.Drawing.Size(158, 28);
            this.add_type_btn.TabIndex = 17;
            this.add_type_btn.Text = "Add Type";
            this.add_type_btn.UseVisualStyleBackColor = false;
            this.add_type_btn.Click += new System.EventHandler(this.add_type_btn_Click);
            // 
            // add_type_name
            // 
            this.add_type_name.Location = new System.Drawing.Point(83, 6);
            this.add_type_name.Name = "add_type_name";
            this.add_type_name.Size = new System.Drawing.Size(158, 20);
            this.add_type_name.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type Name";
            // 
            // AddNewType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 325);
            this.Controls.Add(this.add_type_btn);
            this.Controls.Add(this.add_type_name);
            this.Controls.Add(this.label1);
            this.Name = "AddNewType";
            this.Text = "Add New Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_type_btn;
        private System.Windows.Forms.TextBox add_type_name;
        private System.Windows.Forms.Label label1;
    }
}