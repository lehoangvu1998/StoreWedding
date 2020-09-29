namespace StoreWedding.GUI
{
    partial class fHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnnhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btntaikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnkhachhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnhopdong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhmuc = new DevExpress.XtraBars.BarButtonItem();
            this.btnsanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btnContact = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.lb_name = new DevExpress.XtraBars.BarHeaderItem();
            this.lb_email = new DevExpress.XtraBars.BarStaticItem();
            this.btn_login = new DevExpress.XtraBars.BarButtonItem();
            this.lb_date = new DevExpress.XtraBars.BarHeaderItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonLogout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonLogin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonChange = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pn_Content = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Content)).BeginInit();
            this.pn_Content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnnhanvien,
            this.btntaikhoan,
            this.btnkhachhang,
            this.btnhopdong,
            this.btnDanhmuc,
            this.btnsanpham,
            this.btnContact,
            this.btn_Logout,
            this.lb_name,
            this.lb_email,
            this.btn_login,
            this.lb_date,
            this.barButtonItem1,
            this.btn_ChangePass});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1317, 181);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Caption = "Nhân Viên";
            this.btnnhanvien.Hint = "          ";
            this.btnnhanvien.Id = 3;
            this.btnnhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.ImageOptions.Image")));
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnnhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnhanvien_ItemClick);
            // 
            // btntaikhoan
            // 
            this.btntaikhoan.Caption = "Tài Khoản";
            this.btntaikhoan.Id = 4;
            this.btntaikhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntaikhoan.ImageOptions.Image")));
            this.btntaikhoan.Name = "btntaikhoan";
            this.btntaikhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btntaikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btntaikhoan_ItemClick);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.Caption = "Khách Hàng";
            this.btnkhachhang.Id = 6;
            this.btnkhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.ImageOptions.Image")));
            this.btnkhachhang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.ImageOptions.LargeImage")));
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnkhachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkhachhang_ItemClick);
            // 
            // btnhopdong
            // 
            this.btnhopdong.Caption = "Hợp Đồng";
            this.btnhopdong.Id = 7;
            this.btnhopdong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhopdong.ImageOptions.Image")));
            this.btnhopdong.Name = "btnhopdong";
            this.btnhopdong.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnDanhmuc
            // 
            this.btnDanhmuc.Caption = "Danh Mục";
            this.btnDanhmuc.Id = 8;
            this.btnDanhmuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhmuc.ImageOptions.Image")));
            this.btnDanhmuc.Name = "btnDanhmuc";
            this.btnDanhmuc.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDanhmuc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhmuc_ItemClick);
            // 
            // btnsanpham
            // 
            this.btnsanpham.Caption = "Sản Phẩm";
            this.btnsanpham.Id = 9;
            this.btnsanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsanpham.ImageOptions.Image")));
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnsanpham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsanpham_ItemClick);
            // 
            // btnContact
            // 
            this.btnContact.Caption = "Lập hợp đồng";
            this.btnContact.Id = 11;
            this.btnContact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.ImageOptions.Image")));
            this.btnContact.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnContact.ImageOptions.LargeImage")));
            this.btnContact.Name = "btnContact";
            this.btnContact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Caption = "Đăng xuất";
            this.btn_Logout.Id = 12;
            this.btn_Logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.ImageOptions.Image")));
            this.btn_Logout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.ImageOptions.LargeImage")));
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Logout_ItemClick);
            // 
            // lb_name
            // 
            this.lb_name.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.lb_name.Appearance.BackColor = System.Drawing.Color.Red;
            this.lb_name.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lb_name.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lb_name.Appearance.Options.UseBackColor = true;
            this.lb_name.Appearance.Options.UseBorderColor = true;
            this.lb_name.Appearance.Options.UseFont = true;
            this.lb_name.Appearance.Options.UseForeColor = true;
            this.lb_name.Appearance.Options.UseImage = true;
            this.lb_name.Appearance.Options.UseTextOptions = true;
            this.lb_name.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.lb_name.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.lb_name.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lb_name.Caption = "Hi";
            this.lb_name.Id = 13;
            this.lb_name.Name = "lb_name";
            this.lb_name.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // lb_email
            // 
            this.lb_email.Caption = "Welcome back";
            this.lb_email.Id = 14;
            this.lb_email.Name = "lb_email";
            this.lb_email.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btn_login
            // 
            this.btn_login.Caption = "Đăng Nhập";
            this.btn_login.Id = 15;
            this.btn_login.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_login.ImageOptions.SvgImage")));
            this.btn_login.Name = "btn_login";
            this.btn_login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_login_ItemClick);
            // 
            // lb_date
            // 
            this.lb_date.Caption = "ngày";
            this.lb_date.Id = 16;
            this.lb_date.Name = "lb_date";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Caption = "Đổi mật khẩu";
            this.btn_ChangePass.Id = 18;
            this.btn_ChangePass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ChangePass.ImageOptions.SvgImage")));
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ChangePass_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup8,
            this.ribbonLogout,
            this.ribbonLogin,
            this.ribbonChange});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDanhmuc);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnsanpham);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnnhanvien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnkhachhang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "  ";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup8.ItemLinks.Add(this.lb_name);
            this.ribbonPageGroup8.ItemLinks.Add(this.lb_email);
            this.ribbonPageGroup8.ItemLinks.Add(this.lb_date);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonLogout
            // 
            this.ribbonLogout.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonLogout.ItemLinks.Add(this.btn_Logout);
            this.ribbonLogout.Name = "ribbonLogout";
            // 
            // ribbonLogin
            // 
            this.ribbonLogin.ItemLinks.Add(this.btn_login);
            this.ribbonLogin.Name = "ribbonLogin";
            // 
            // ribbonChange
            // 
            this.ribbonChange.ItemLinks.Add(this.btn_ChangePass);
            this.ribbonChange.Name = "ribbonChange";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cửa Hàng";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnContact);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "                                                      ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thông Tin Liên Hệ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 651);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1317, 27);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tài Khoản";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // pn_Content
            // 
            this.pn_Content.AutoSize = true;
            this.pn_Content.Controls.Add(this.panel2);
            this.pn_Content.Controls.Add(this.panel1);
            this.pn_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Content.Location = new System.Drawing.Point(0, 181);
            this.pn_Content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn_Content.Name = "pn_Content";
            this.pn_Content.Size = new System.Drawing.Size(1317, 470);
            this.pn_Content.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1313, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa hàng Áo Cưới của chúng tôi cung cấp nhiều sản phẩm chất lượng với các thương " +
    "hiệu uy tín.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 160);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 312);
            this.panel2.TabIndex = 2;
            // 
            // fHome
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1317, 678);
            this.Controls.Add(this.pn_Content);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "fHome";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Chào mừng bạn đến với cửa hàng quản lý và cho thuê áo cưới";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Content)).EndInit();
            this.pn_Content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnnhanvien;
        private DevExpress.XtraBars.BarButtonItem btntaikhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnkhachhang;
        private DevExpress.XtraBars.BarButtonItem btnhopdong;
        private DevExpress.XtraBars.BarButtonItem btnDanhmuc;
        private DevExpress.XtraBars.BarButtonItem btnsanpham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnContact;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraEditors.PanelControl pn_Content;
        private DevExpress.XtraBars.BarButtonItem btn_Logout;
        private DevExpress.XtraBars.BarHeaderItem lb_name;
        private DevExpress.XtraBars.BarStaticItem lb_email;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonLogout;
        private DevExpress.XtraBars.BarButtonItem btn_login;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonLogin;
        private DevExpress.XtraBars.BarHeaderItem lb_date;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_ChangePass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}