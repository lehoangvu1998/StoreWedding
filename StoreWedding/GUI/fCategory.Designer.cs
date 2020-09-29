namespace StoreWedding.GUI
{
    partial class fCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_Category = new System.Windows.Forms.DataGridView();
            this.groupChucNang = new DevExpress.XtraEditors.GroupControl();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_CategoryId = new System.Windows.Forms.TextBox();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChucNang)).BeginInit();
            this.groupChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Category
            // 
            this.grid_Category.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Category.Location = new System.Drawing.Point(21, 249);
            this.grid_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_Category.Name = "grid_Category";
            this.grid_Category.RowHeadersWidth = 51;
            this.grid_Category.RowTemplate.Height = 24;
            this.grid_Category.Size = new System.Drawing.Size(786, 341);
            this.grid_Category.TabIndex = 6;
            this.grid_Category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Category_CellClick);
            this.grid_Category.SelectionChanged += new System.EventHandler(this.grid_Category_SelectionChanged);
            // 
            // groupChucNang
            // 
            this.groupChucNang.Controls.Add(this.btn_Cancle);
            this.groupChucNang.Controls.Add(this.btn_Submit);
            this.groupChucNang.Controls.Add(this.btn_Clear);
            this.groupChucNang.Controls.Add(this.btn_Update);
            this.groupChucNang.Controls.Add(this.btn_Delete);
            this.groupChucNang.Controls.Add(this.btn_Add);
            this.groupChucNang.Location = new System.Drawing.Point(539, 25);
            this.groupChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupChucNang.Name = "groupChucNang";
            this.groupChucNang.Size = new System.Drawing.Size(268, 196);
            this.groupChucNang.TabIndex = 4;
            this.groupChucNang.Text = "Chức Năng";
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Location = new System.Drawing.Point(155, 121);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(94, 30);
            this.btn_Cancle.TabIndex = 8;
            this.btn_Cancle.Text = "Hủy";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(155, 50);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(94, 30);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Cập nhật";
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(155, 86);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 30);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Lảm lại";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(37, 85);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 30);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(37, 121);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 30);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(37, 50);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 30);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_CategoryId);
            this.groupControl1.Controls.Add(this.txt_CategoryName);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(21, 25);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(481, 196);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh Mục";
            // 
            // txt_CategoryId
            // 
            this.txt_CategoryId.Location = new System.Drawing.Point(143, 65);
            this.txt_CategoryId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CategoryId.Name = "txt_CategoryId";
            this.txt_CategoryId.Size = new System.Drawing.Size(280, 23);
            this.txt_CategoryId.TabIndex = 9;
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Location = new System.Drawing.Point(143, 133);
            this.txt_CategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(280, 23);
            this.txt_CategoryName.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Danh Mục";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // fCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 622);
            this.ControlBox = false;
            this.Controls.Add(this.grid_Category);
            this.Controls.Add(this.groupChucNang);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.fCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChucNang)).EndInit();
            this.groupChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Category;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_CategoryId;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.SimpleButton btn_Submit;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public DevExpress.XtraEditors.GroupControl groupChucNang;
    }
}