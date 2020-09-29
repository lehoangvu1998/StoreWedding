namespace StoreWedding.GUI
{
    partial class fBilling
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
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_Amount = new System.Windows.Forms.Label();
            this.lb_PayDate = new System.Windows.Forms.Label();
            this.lb_RecivedDate = new System.Windows.Forms.Label();
            this.lb_BillDate = new System.Windows.Forms.Label();
            this.lb_NameCustomer = new System.Windows.Forms.Label();
            this.lb_NamProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(320, 397);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Product
            // 
            this.lb_Product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Product.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Product.Location = new System.Drawing.Point(45, 78);
            this.lb_Product.Name = "lb_Product";
            this.lb_Product.Size = new System.Drawing.Size(164, 27);
            this.lb_Product.TabIndex = 2;
            this.lb_Product.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(45, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(45, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày đặt:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(45, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày nhận:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(45, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày trả:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(45, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(45, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đơn giá:";
            // 
            // lb_Price
            // 
            this.lb_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.ForeColor = System.Drawing.Color.Coral;
            this.lb_Price.Location = new System.Drawing.Point(215, 367);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(164, 27);
            this.lb_Price.TabIndex = 15;
            this.lb_Price.Text = "Đơn giá:";
            // 
            // lb_Amount
            // 
            this.lb_Amount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Amount.ForeColor = System.Drawing.Color.Coral;
            this.lb_Amount.Location = new System.Drawing.Point(215, 321);
            this.lb_Amount.Name = "lb_Amount";
            this.lb_Amount.Size = new System.Drawing.Size(164, 27);
            this.lb_Amount.TabIndex = 14;
            this.lb_Amount.Text = "Số lượng:";
            // 
            // lb_PayDate
            // 
            this.lb_PayDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PayDate.ForeColor = System.Drawing.Color.Coral;
            this.lb_PayDate.Location = new System.Drawing.Point(215, 273);
            this.lb_PayDate.Name = "lb_PayDate";
            this.lb_PayDate.Size = new System.Drawing.Size(164, 27);
            this.lb_PayDate.TabIndex = 13;
            this.lb_PayDate.Text = "Ngày trả:";
            // 
            // lb_RecivedDate
            // 
            this.lb_RecivedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RecivedDate.ForeColor = System.Drawing.Color.Coral;
            this.lb_RecivedDate.Location = new System.Drawing.Point(215, 228);
            this.lb_RecivedDate.Name = "lb_RecivedDate";
            this.lb_RecivedDate.Size = new System.Drawing.Size(164, 27);
            this.lb_RecivedDate.TabIndex = 12;
            this.lb_RecivedDate.Text = "Ngày nhận:";
            // 
            // lb_BillDate
            // 
            this.lb_BillDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BillDate.ForeColor = System.Drawing.Color.Coral;
            this.lb_BillDate.Location = new System.Drawing.Point(215, 178);
            this.lb_BillDate.Name = "lb_BillDate";
            this.lb_BillDate.Size = new System.Drawing.Size(164, 27);
            this.lb_BillDate.TabIndex = 11;
            this.lb_BillDate.Text = "Ngày đặt:";
            // 
            // lb_NameCustomer
            // 
            this.lb_NameCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameCustomer.ForeColor = System.Drawing.Color.Coral;
            this.lb_NameCustomer.Location = new System.Drawing.Point(215, 130);
            this.lb_NameCustomer.Name = "lb_NameCustomer";
            this.lb_NameCustomer.Size = new System.Drawing.Size(164, 27);
            this.lb_NameCustomer.TabIndex = 10;
            this.lb_NameCustomer.Text = "Tên khách hàng:";
            // 
            // lb_NamProduct
            // 
            this.lb_NamProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamProduct.ForeColor = System.Drawing.Color.Coral;
            this.lb_NamProduct.Location = new System.Drawing.Point(215, 78);
            this.lb_NamProduct.Name = "lb_NamProduct";
            this.lb_NamProduct.Size = new System.Drawing.Size(164, 27);
            this.lb_NamProduct.TabIndex = 9;
            this.lb_NamProduct.Text = "Áo cưới";
            // 
            // fBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 447);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.lb_Amount);
            this.Controls.Add(this.lb_PayDate);
            this.Controls.Add(this.lb_RecivedDate);
            this.Controls.Add(this.lb_BillDate);
            this.Controls.Add(this.lb_NameCustomer);
            this.Controls.Add(this.lb_NamProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "fBilling";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.fBilling_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_Amount;
        private System.Windows.Forms.Label lb_PayDate;
        private System.Windows.Forms.Label lb_RecivedDate;
        private System.Windows.Forms.Label lb_BillDate;
        private System.Windows.Forms.Label lb_NameCustomer;
        private System.Windows.Forms.Label lb_NamProduct;
    }
}