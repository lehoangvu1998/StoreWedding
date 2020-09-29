namespace StoreWedding.GUI
{
    partial class fProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProduct));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_categoryId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ChooseImage = new System.Windows.Forms.Button();
            this.pic_Product = new System.Windows.Forms.PictureBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rt_Description = new System.Windows.Forms.RichTextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupChucNang = new DevExpress.XtraEditors.GroupControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.list_Products = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDPRODUCT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAMEPRODUCT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESCRIPTIONPRODUCT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRICE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDCATEGORY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IMAGEPRODUCT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_Sync = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_categoryId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChucNang)).BeginInit();
            this.groupChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.cb_categoryId);
            this.groupControl1.Controls.Add(this.txt_Status);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.btn_ChooseImage);
            this.groupControl1.Controls.Add(this.pic_Product);
            this.groupControl1.Controls.Add(this.txt_Price);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.rt_Description);
            this.groupControl1.Controls.Add(this.txt_Name);
            this.groupControl1.Controls.Add(this.txt_ID);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 22);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(983, 290);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sản Phẩm";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(336, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "vnd";
            // 
            // cb_categoryId
            // 
            this.cb_categoryId.EditValue = "";
            this.cb_categoryId.Location = new System.Drawing.Point(143, 64);
            this.cb_categoryId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_categoryId.Name = "cb_categoryId";
            this.cb_categoryId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_categoryId.Properties.NullText = "";
            this.cb_categoryId.Properties.PopupView = this.searchLookUpEdit1View;
            this.cb_categoryId.Size = new System.Drawing.Size(185, 24);
            this.cb_categoryId.TabIndex = 24;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.DetailHeight = 431;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(498, 245);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(126, 23);
            this.txt_Status.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tinh trang";
            // 
            // btn_ChooseImage
            // 
            this.btn_ChooseImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChooseImage.BackgroundImage")));
            this.btn_ChooseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChooseImage.FlatAppearance.BorderSize = 0;
            this.btn_ChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChooseImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseImage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_ChooseImage.Location = new System.Drawing.Point(849, 212);
            this.btn_ChooseImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ChooseImage.Name = "btn_ChooseImage";
            this.btn_ChooseImage.Size = new System.Drawing.Size(117, 37);
            this.btn_ChooseImage.TabIndex = 21;
            this.btn_ChooseImage.Text = "Chọn ảnh";
            this.btn_ChooseImage.UseVisualStyleBackColor = true;
            this.btn_ChooseImage.Click += new System.EventHandler(this.btn_ChooseImage_Click);
            // 
            // pic_Product
            // 
            this.pic_Product.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Product.BackgroundImage")));
            this.pic_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Product.Location = new System.Drawing.Point(849, 68);
            this.pic_Product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_Product.Name = "pic_Product";
            this.pic_Product.Size = new System.Drawing.Size(117, 137);
            this.pic_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Product.TabIndex = 20;
            this.pic_Product.TabStop = false;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(143, 249);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(185, 23);
            this.txt_Price.TabIndex = 9;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá tiền";
            // 
            // rt_Description
            // 
            this.rt_Description.Location = new System.Drawing.Point(498, 64);
            this.rt_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rt_Description.Name = "rt_Description";
            this.rt_Description.Size = new System.Drawing.Size(286, 152);
            this.rt_Description.TabIndex = 7;
            this.rt_Description.Text = "";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(143, 191);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(185, 23);
            this.txt_Name.TabIndex = 6;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(143, 133);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(185, 23);
            this.txt_ID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Danh Mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // groupChucNang
            // 
            this.groupChucNang.Controls.Add(this.btn_Add);
            this.groupChucNang.Controls.Add(this.btn_Update);
            this.groupChucNang.Controls.Add(this.btn_Save);
            this.groupChucNang.Controls.Add(this.btn_Cancel);
            this.groupChucNang.Controls.Add(this.btn_Delete);
            this.groupChucNang.Location = new System.Drawing.Point(4, 373);
            this.groupChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupChucNang.Name = "groupChucNang";
            this.groupChucNang.Size = new System.Drawing.Size(991, 81);
            this.groupChucNang.TabIndex = 0;
            this.groupChucNang.Text = "Chức Năng";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(234, 47);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 30);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(690, 47);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 30);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(350, 47);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 30);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(464, 47);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 30);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(577, 47);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 30);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // list_Products
            // 
            this.list_Products.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("list_Products.BackgroundImage")));
            this.list_Products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.IDPRODUCT,
            this.NAMEPRODUCT,
            this.DESCRIPTIONPRODUCT,
            this.PRICE,
            this.IDCATEGORY,
            this.IMAGEPRODUCT,
            this.STATUS});
            this.list_Products.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Products.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.list_Products.HideSelection = false;
            this.list_Products.Location = new System.Drawing.Point(4, 479);
            this.list_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_Products.Name = "list_Products";
            this.list_Products.Size = new System.Drawing.Size(991, 256);
            this.list_Products.TabIndex = 1;
            this.list_Products.UseCompatibleStateImageBehavior = false;
            this.list_Products.View = System.Windows.Forms.View.Details;
            this.list_Products.SelectedIndexChanged += new System.EventHandler(this.list_Products_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // IDPRODUCT
            // 
            this.IDPRODUCT.Text = "Mã SP";
            this.IDPRODUCT.Width = 80;
            // 
            // NAMEPRODUCT
            // 
            this.NAMEPRODUCT.Text = "Tên Sản phẩm";
            this.NAMEPRODUCT.Width = 150;
            // 
            // DESCRIPTIONPRODUCT
            // 
            this.DESCRIPTIONPRODUCT.Text = "Mô tả";
            this.DESCRIPTIONPRODUCT.Width = 240;
            // 
            // PRICE
            // 
            this.PRICE.Text = "Giá";
            this.PRICE.Width = 110;
            // 
            // IDCATEGORY
            // 
            this.IDCATEGORY.Text = "Mã loại";
            this.IDCATEGORY.Width = 100;
            // 
            // IMAGEPRODUCT
            // 
            this.IMAGEPRODUCT.Text = "Hình ảnh";
            this.IMAGEPRODUCT.Width = 140;
            // 
            // STATUS
            // 
            this.STATUS.Text = "Tình trạng";
            this.STATUS.Width = 100;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(229, 319);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(130, 44);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(376, 330);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(195, 23);
            this.txt_Search.TabIndex = 24;
            this.txt_Search.Text = "Nhập thông tin";
            this.txt_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Search_MouseClick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // btn_Sync
            // 
            this.btn_Sync.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sync.Appearance.Options.UseFont = true;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sync.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sync.ImageOptions.Image")));
            this.btn_Sync.Location = new System.Drawing.Point(827, 323);
            this.btn_Sync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(168, 44);
            this.btn_Sync.TabIndex = 25;
            this.btn_Sync.Text = "Sync dữ liệu";
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 748);
            this.Controls.Add(this.btn_Sync);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.list_Products);
            this.Controls.Add(this.groupChucNang);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.fProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_categoryId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChucNang)).EndInit();
            this.groupChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rt_Description;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView list_Products;
        private System.Windows.Forms.ColumnHeader IDPRODUCT;
        private System.Windows.Forms.ColumnHeader NAMEPRODUCT;
        private System.Windows.Forms.ColumnHeader DESCRIPTIONPRODUCT;
        private System.Windows.Forms.ColumnHeader PRICE;
        private System.Windows.Forms.ColumnHeader IDCATEGORY;
        private System.Windows.Forms.Button btn_ChooseImage;
        private System.Windows.Forms.PictureBox pic_Product;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cb_categoryId;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ColumnHeader IMAGEPRODUCT;
        private System.Windows.Forms.ColumnHeader STATUS;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btn_Sync;
        private System.Windows.Forms.ColumnHeader STT;
        public DevExpress.XtraEditors.GroupControl groupChucNang;
    }
}