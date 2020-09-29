namespace StoreWedding.GUI
{
    partial class fStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStore));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Contact = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit_Return = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_Recived = new DevExpress.XtraEditors.DateEdit();
            this.date_Bill = new DevExpress.XtraEditors.DateEdit();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.cb_Product = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.group_Customer = new System.Windows.Forms.GroupBox();
            this.rd_FriendShipCus = new System.Windows.Forms.RadioButton();
            this.rd_StrangerCus = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Customer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.grid_Product = new DevExpress.XtraGrid.GridControl();
            this.gridView_Product = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_Contact = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Sync = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ViewBill = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Return.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Return.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Recived.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Recived.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Bill.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Bill.Properties)).BeginInit();
            this.group_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Contact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wedding Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sản Phẩm";
            // 
            // btn_Contact
            // 
            this.btn_Contact.Location = new System.Drawing.Point(49, 64);
            this.btn_Contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.Size = new System.Drawing.Size(100, 30);
            this.btn_Contact.TabIndex = 8;
            this.btn_Contact.Text = "Lập hợp đồng";
            this.btn_Contact.Click += new System.EventHandler(this.btn_Contact_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dateEdit_Return);
            this.groupControl2.Controls.Add(this.dateEdit_Recived);
            this.groupControl2.Controls.Add(this.date_Bill);
            this.groupControl2.Controls.Add(this.txt_category);
            this.groupControl2.Controls.Add(this.cb_Product);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.group_Customer);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.cb_Customer);
            this.groupControl2.Location = new System.Drawing.Point(12, 232);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1065, 243);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Hợp Đồng";
            // 
            // dateEdit_Return
            // 
            this.dateEdit_Return.EditValue = "";
            this.dateEdit_Return.Location = new System.Drawing.Point(253, 131);
            this.dateEdit_Return.Name = "dateEdit_Return";
            this.dateEdit_Return.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Return.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Return.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEdit_Return.Properties.DisplayFormat.FormatString = "";
            this.dateEdit_Return.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_Return.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit_Return.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_Return.Size = new System.Drawing.Size(238, 24);
            this.dateEdit_Return.TabIndex = 33;
            // 
            // dateEdit_Recived
            // 
            this.dateEdit_Recived.EditValue = "";
            this.dateEdit_Recived.Location = new System.Drawing.Point(253, 85);
            this.dateEdit_Recived.Name = "dateEdit_Recived";
            this.dateEdit_Recived.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Recived.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Recived.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEdit_Recived.Properties.DisplayFormat.FormatString = "";
            this.dateEdit_Recived.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_Recived.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit_Recived.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_Recived.Size = new System.Drawing.Size(238, 24);
            this.dateEdit_Recived.TabIndex = 32;
            this.dateEdit_Recived.EditValueChanged += new System.EventHandler(this.dateEdit_Recived_EditValueChanged);
            // 
            // date_Bill
            // 
            this.date_Bill.EditValue = "";
            this.date_Bill.Enabled = false;
            this.date_Bill.Location = new System.Drawing.Point(253, 41);
            this.date_Bill.Name = "date_Bill";
            this.date_Bill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Bill.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Bill.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.date_Bill.Properties.DisplayFormat.FormatString = "";
            this.date_Bill.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_Bill.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.date_Bill.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.date_Bill.Size = new System.Drawing.Size(238, 24);
            this.date_Bill.TabIndex = 31;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(782, 71);
            this.txt_category.Name = "txt_category";
            this.txt_category.ReadOnly = true;
            this.txt_category.Size = new System.Drawing.Size(148, 23);
            this.txt_category.TabIndex = 29;
            // 
            // cb_Product
            // 
            this.cb_Product.Enabled = false;
            this.cb_Product.FormattingEnabled = true;
            this.cb_Product.Location = new System.Drawing.Point(782, 33);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(148, 24);
            this.cb_Product.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Chọn khách hàng";
            // 
            // group_Customer
            // 
            this.group_Customer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.group_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.group_Customer.Controls.Add(this.rd_FriendShipCus);
            this.group_Customer.Controls.Add(this.rd_StrangerCus);
            this.group_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_Customer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_Customer.ForeColor = System.Drawing.Color.DarkCyan;
            this.group_Customer.Location = new System.Drawing.Point(662, 107);
            this.group_Customer.Name = "group_Customer";
            this.group_Customer.Size = new System.Drawing.Size(268, 100);
            this.group_Customer.TabIndex = 24;
            this.group_Customer.TabStop = false;
            this.group_Customer.Text = "Loại khách hàng";
            // 
            // rd_FriendShipCus
            // 
            this.rd_FriendShipCus.AutoSize = true;
            this.rd_FriendShipCus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rd_FriendShipCus.ForeColor = System.Drawing.Color.DarkGreen;
            this.rd_FriendShipCus.Location = new System.Drawing.Point(36, 30);
            this.rd_FriendShipCus.Name = "rd_FriendShipCus";
            this.rd_FriendShipCus.Size = new System.Drawing.Size(199, 23);
            this.rd_FriendShipCus.TabIndex = 22;
            this.rd_FriendShipCus.Text = "Khách hàng thân thiết";
            this.rd_FriendShipCus.UseVisualStyleBackColor = true;
            this.rd_FriendShipCus.CheckedChanged += new System.EventHandler(this.CheckRadio);
            // 
            // rd_StrangerCus
            // 
            this.rd_StrangerCus.AutoSize = true;
            this.rd_StrangerCus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rd_StrangerCus.ForeColor = System.Drawing.Color.DarkGreen;
            this.rd_StrangerCus.Location = new System.Drawing.Point(36, 64);
            this.rd_StrangerCus.Name = "rd_StrangerCus";
            this.rd_StrangerCus.Size = new System.Drawing.Size(146, 23);
            this.rd_StrangerCus.TabIndex = 23;
            this.rd_StrangerCus.Text = "Khách vãng lai";
            this.rd_StrangerCus.UseVisualStyleBackColor = true;
            this.rd_StrangerCus.CheckedChanged += new System.EventHandler(this.CheckRadio);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày Nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày lập hợp đồng";
            // 
            // cb_Customer
            // 
            this.cb_Customer.EditValue = "";
            this.cb_Customer.Location = new System.Drawing.Point(782, 212);
            this.cb_Customer.Name = "cb_Customer";
            this.cb_Customer.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.cb_Customer.Properties.Appearance.Options.UseForeColor = true;
            this.cb_Customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Customer.Properties.NullText = "";
            this.cb_Customer.Properties.PopupView = this.searchLookUpEdit1View;
            this.cb_Customer.Size = new System.Drawing.Size(148, 24);
            this.cb_Customer.TabIndex = 30;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton4);
            this.groupControl3.Controls.Add(this.btn_Contact);
            this.groupControl3.Location = new System.Drawing.Point(1147, 232);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(180, 243);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Chức Năng";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(49, 128);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(100, 30);
            this.simpleButton4.TabIndex = 10;
            this.simpleButton4.Text = "Hủy ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // grid_Product
            // 
            this.grid_Product.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_Product.Location = new System.Drawing.Point(0, 627);
            this.grid_Product.MainView = this.gridView_Product;
            this.grid_Product.Name = "grid_Product";
            this.grid_Product.Size = new System.Drawing.Size(1385, 225);
            this.grid_Product.TabIndex = 13;
            this.grid_Product.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Product});
            // 
            // gridView_Product
            // 
            this.gridView_Product.GridControl = this.grid_Product;
            this.gridView_Product.Name = "gridView_Product";
            this.gridView_Product.OptionsView.ShowFooter = true;
            this.gridView_Product.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Product_FocusedRowChanged);
            // 
            // grid_Contact
            // 
            this.grid_Contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_Contact.Location = new System.Drawing.Point(0, 0);
            this.grid_Contact.MainView = this.gridView1;
            this.grid_Contact.Name = "grid_Contact";
            this.grid_Contact.Size = new System.Drawing.Size(1385, 218);
            this.grid_Contact.TabIndex = 14;
            this.grid_Contact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_Contact;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // btn_Sync
            // 
            this.btn_Sync.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sync.Appearance.Options.UseFont = true;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sync.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sync.ImageOptions.Image")));
            this.btn_Sync.Location = new System.Drawing.Point(1159, 547);
            this.btn_Sync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(168, 32);
            this.btn_Sync.TabIndex = 26;
            this.btn_Sync.Text = "Sync dữ liệu";
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btn_ViewBill
            // 
            this.btn_ViewBill.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewBill.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ViewBill.Appearance.Options.UseFont = true;
            this.btn_ViewBill.Appearance.Options.UseForeColor = true;
            this.btn_ViewBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ViewBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewBill.ImageOptions.Image")));
            this.btn_ViewBill.Location = new System.Drawing.Point(904, 547);
            this.btn_ViewBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ViewBill.Name = "btn_ViewBill";
            this.btn_ViewBill.Size = new System.Drawing.Size(230, 32);
            this.btn_ViewBill.TabIndex = 27;
            this.btn_ViewBill.Text = "Xem chi tiết hóa đơn";
            this.btn_ViewBill.Click += new System.EventHandler(this.btn_ViewBill_Click);
            // 
            // fStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 852);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ViewBill);
            this.Controls.Add(this.btn_Sync);
            this.Controls.Add(this.grid_Contact);
            this.Controls.Add(this.grid_Product);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fStore";
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.fStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Return.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Return.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Recived.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Recived.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Bill.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Bill.Properties)).EndInit();
            this.group_Customer.ResumeLayout(false);
            this.group_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Contact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_Contact;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.GroupBox group_Customer;
        private System.Windows.Forms.RadioButton rd_FriendShipCus;
        private System.Windows.Forms.RadioButton rd_StrangerCus;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl grid_Product;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Product;
        private System.Windows.Forms.ComboBox cb_Product;
        private System.Windows.Forms.TextBox txt_category;
        private DevExpress.XtraEditors.SearchLookUpEdit cb_Customer;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit date_Bill;
        private DevExpress.XtraEditors.DateEdit dateEdit_Return;
        private DevExpress.XtraEditors.DateEdit dateEdit_Recived;
        private DevExpress.XtraGrid.GridControl grid_Contact;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Sync;
        private DevExpress.XtraEditors.SimpleButton btn_ViewBill;
    }
}