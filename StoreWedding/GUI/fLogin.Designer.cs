namespace StoreWedding.GUI
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusername = new DevExpress.XtraEditors.TextEdit();
            this.tbpass = new DevExpress.XtraEditors.TextEdit();
            this.btnlogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ck_MatKhau = new System.Windows.Forms.CheckBox();
            this.errProviderError = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Correct = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Correct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // tbusername
            // 
            this.errProviderError.SetIconAlignment(this.tbusername, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.tbusername.Location = new System.Drawing.Point(238, 139);
            this.tbusername.Name = "tbusername";
            this.tbusername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbusername.Size = new System.Drawing.Size(224, 23);
            this.tbusername.TabIndex = 4;
            this.tbusername.Validating += new System.ComponentModel.CancelEventHandler(this.tbusername_Validating);
            // 
            // tbpass
            // 
            this.errProviderError.SetIconAlignment(this.tbpass, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.tbpass.Location = new System.Drawing.Point(238, 213);
            this.tbpass.Name = "tbpass";
            this.tbpass.Properties.PasswordChar = '*';
            this.tbpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbpass.Size = new System.Drawing.Size(224, 23);
            this.tbpass.TabIndex = 5;
            this.tbpass.Validating += new System.ComponentModel.CancelEventHandler(this.tbpass_Validating);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(238, 283);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(94, 29);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(368, 283);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 29);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Thoát";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(268, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 74);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(187, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(187, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 24);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // ck_MatKhau
            // 
            this.ck_MatKhau.AutoSize = true;
            this.ck_MatKhau.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ck_MatKhau.Location = new System.Drawing.Point(238, 243);
            this.ck_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.ck_MatKhau.Name = "ck_MatKhau";
            this.ck_MatKhau.Size = new System.Drawing.Size(118, 21);
            this.ck_MatKhau.TabIndex = 15;
            this.ck_MatKhau.Text = "Hiện mật khẩu";
            this.ck_MatKhau.UseVisualStyleBackColor = true;
            this.ck_MatKhau.CheckedChanged += new System.EventHandler(this.ck_MatKhau_CheckedChanged);
            // 
            // errProviderError
            // 
            this.errProviderError.ContainerControl = this;
            this.errProviderError.Icon = ((System.Drawing.Icon)(resources.GetObject("errProviderError.Icon")));
            // 
            // errorProvider_Correct
            // 
            this.errorProvider_Correct.ContainerControl = this;
            this.errorProvider_Correct.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_Correct.Icon")));
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 363);
            this.ControlBox = false;
            this.Controls.Add(this.ck_MatKhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "fLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Correct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tbusername;
        private DevExpress.XtraEditors.TextEdit tbpass;
        private DevExpress.XtraEditors.SimpleButton btnlogin;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox ck_MatKhau;
        private System.Windows.Forms.ErrorProvider errProviderError;
        private System.Windows.Forms.ErrorProvider errorProvider_Correct;
    }
}