﻿namespace StoreWedding.GUI
{
    partial class fCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomer));
            this.grid_Customer = new System.Windows.Forms.DataGridView();
            this.groupChucNang = new DevExpress.XtraEditors.GroupControl();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Sync = new DevExpress.XtraEditors.SimpleButton();
            this.txt_IDCard = new System.Windows.Forms.TextBox();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.cb_endMail = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChucNang)).BeginInit();
            this.groupChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_Customer
            // 
            this.grid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customer.Location = new System.Drawing.Point(224, 336);
            this.grid_Customer.Name = "grid_Customer";
            this.grid_Customer.RowHeadersWidth = 51;
            this.grid_Customer.RowTemplate.Height = 24;
            this.grid_Customer.Size = new System.Drawing.Size(786, 348);
            this.grid_Customer.TabIndex = 6;
            this.grid_Customer.SelectionChanged += new System.EventHandler(this.grid_Customer_SelectionChanged);
            // 
            // groupChucNang
            // 
            this.groupChucNang.Controls.Add(this.btn_Cancle);
            this.groupChucNang.Controls.Add(this.btn_Submit);
            this.groupChucNang.Controls.Add(this.btn_Clear);
            this.groupChucNang.Controls.Add(this.btn_Update);
            this.groupChucNang.Controls.Add(this.btn_Delete);
            this.groupChucNang.Controls.Add(this.btn_Add);
            this.groupChucNang.Location = new System.Drawing.Point(26, 336);
            this.groupChucNang.Name = "groupChucNang";
            this.groupChucNang.Size = new System.Drawing.Size(172, 348);
            this.groupChucNang.TabIndex = 4;
            this.groupChucNang.Text = "Chức Năng";
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Location = new System.Drawing.Point(40, 252);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(94, 30);
            this.btn_Cancle.TabIndex = 20;
            this.btn_Cancle.Text = "Hủy";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(40, 184);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(94, 30);
            this.btn_Submit.TabIndex = 19;
            this.btn_Submit.Text = "Cập nhật";
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(40, 218);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 30);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "Lảm lại";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(39, 102);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 30);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(39, 138);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 30);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(39, 67);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 30);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Sync);
            this.groupControl1.Controls.Add(this.txt_IDCard);
            this.groupControl1.Controls.Add(this.txt_Number);
            this.groupControl1.Controls.Add(this.txt_Address);
            this.groupControl1.Controls.Add(this.cb_endMail);
            this.groupControl1.Controls.Add(this.txt_ID);
            this.groupControl1.Controls.Add(this.txt_email);
            this.groupControl1.Controls.Add(this.txt_Name);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(26, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(984, 291);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Khách Hàng";
            // 
            // btn_Sync
            // 
            this.btn_Sync.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sync.Appearance.Options.UseFont = true;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sync.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sync.ImageOptions.Image")));
            this.btn_Sync.Location = new System.Drawing.Point(768, 253);
            this.btn_Sync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(168, 32);
            this.btn_Sync.TabIndex = 36;
            this.btn_Sync.Text = "Sync dữ liệu";
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // txt_IDCard
            // 
            this.txt_IDCard.Location = new System.Drawing.Point(613, 214);
            this.txt_IDCard.Name = "txt_IDCard";
            this.txt_IDCard.Size = new System.Drawing.Size(323, 23);
            this.txt_IDCard.TabIndex = 35;
            this.txt_IDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDCard_KeyPress);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(613, 68);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(323, 23);
            this.txt_Number.TabIndex = 34;
            this.txt_Number.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            this.txt_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number_KeyPress);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(613, 136);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(323, 23);
            this.txt_Address.TabIndex = 33;
            // 
            // cb_endMail
            // 
            this.cb_endMail.FormattingEnabled = true;
            this.cb_endMail.Location = new System.Drawing.Point(326, 213);
            this.cb_endMail.Name = "cb_endMail";
            this.cb_endMail.Size = new System.Drawing.Size(111, 24);
            this.cb_endMail.TabIndex = 32;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(156, 65);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(281, 23);
            this.txt_ID.TabIndex = 31;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(156, 214);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 23);
            this.txt_email.TabIndex = 30;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(156, 133);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(281, 23);
            this.txt_Name.TabIndex = 29;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "CMND / CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 720);
            this.ControlBox = false;
            this.Controls.Add(this.grid_Customer);
            this.Controls.Add(this.groupChucNang);
            this.Controls.Add(this.groupControl1);
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChucNang)).EndInit();
            this.groupChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Customer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.GroupControl groupChucNang;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private DevExpress.XtraEditors.SimpleButton btn_Submit;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.ComboBox cb_endMail;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.SimpleButton btn_Sync;
        private System.Windows.Forms.TextBox txt_IDCard;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Address;
    }
}