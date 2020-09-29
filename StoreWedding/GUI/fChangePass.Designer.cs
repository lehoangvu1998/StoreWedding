namespace StoreWedding.GUI
{
    partial class fChangePass
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
            this.txt_repass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.ck_Password = new System.Windows.Forms.CheckBox();
            this.btn_changepass = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_repass
            // 
            this.txt_repass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repass.Location = new System.Drawing.Point(253, 169);
            this.txt_repass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_repass.MaxLength = 10;
            this.txt_repass.Name = "txt_repass";
            this.txt_repass.PasswordChar = '*';
            this.txt_repass.Size = new System.Drawing.Size(233, 26);
            this.txt_repass.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nhập lại mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // txt_newpass
            // 
            this.txt_newpass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpass.Location = new System.Drawing.Point(253, 122);
            this.txt_newpass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newpass.MaxLength = 10;
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.PasswordChar = '*';
            this.txt_newpass.Size = new System.Drawing.Size(233, 26);
            this.txt_newpass.TabIndex = 36;
            // 
            // ck_Password
            // 
            this.ck_Password.AutoSize = true;
            this.ck_Password.Location = new System.Drawing.Point(253, 215);
            this.ck_Password.Margin = new System.Windows.Forms.Padding(4);
            this.ck_Password.Name = "ck_Password";
            this.ck_Password.Size = new System.Drawing.Size(117, 21);
            this.ck_Password.TabIndex = 35;
            this.ck_Password.Text = "hiện mật khẩu";
            this.ck_Password.UseVisualStyleBackColor = true;
            this.ck_Password.CheckedChanged += new System.EventHandler(this.ck_Password_CheckedChanged);
            // 
            // btn_changepass
            // 
            this.btn_changepass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_changepass.FlatAppearance.BorderSize = 0;
            this.btn_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_changepass.Location = new System.Drawing.Point(253, 257);
            this.btn_changepass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_changepass.Name = "btn_changepass";
            this.btn_changepass.Size = new System.Drawing.Size(117, 37);
            this.btn_changepass.TabIndex = 33;
            this.btn_changepass.Text = "Đổi mật khẩu";
            this.btn_changepass.UseVisualStyleBackColor = false;
            this.btn_changepass.Click += new System.EventHandler(this.btn_changepass_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(253, 69);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.MaxLength = 10;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(233, 26);
            this.txt_Password.TabIndex = 32;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(253, 17);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4);
            this.txt_User.Name = "txt_User";
            this.txt_User.ReadOnly = true;
            this.txt_User.Size = new System.Drawing.Size(233, 26);
            this.txt_User.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mật khẩu cũ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Username:";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reset.Location = new System.Drawing.Point(386, 203);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 37);
            this.btn_Reset.TabIndex = 34;
            this.btn_Reset.Text = "Làm lại";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Exit.Location = new System.Drawing.Point(386, 257);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 37);
            this.btn_Exit.TabIndex = 40;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // fChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 356);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_repass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.ck_Password);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_changepass);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_repass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.CheckBox ck_Password;
        private System.Windows.Forms.Button btn_changepass;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Exit;
    }
}