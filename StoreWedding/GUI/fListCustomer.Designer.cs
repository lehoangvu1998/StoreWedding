namespace StoreWedding.GUI
{
    partial class fListCustomer
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
            this.flowLayout_Customer = new System.Windows.Forms.FlowLayoutPanel();
            this.customerInformation1 = new StoreWedding.GUI.CustomerInformation();
            this.flowLayout_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn khách hàng";
            // 
            // flowLayout_Customer
            // 
            this.flowLayout_Customer.AutoScroll = true;
            this.flowLayout_Customer.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayout_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayout_Customer.Controls.Add(this.customerInformation1);
            this.flowLayout_Customer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayout_Customer.ForeColor = System.Drawing.Color.Blue;
            this.flowLayout_Customer.Location = new System.Drawing.Point(303, 7);
            this.flowLayout_Customer.Name = "flowLayout_Customer";
            this.flowLayout_Customer.Size = new System.Drawing.Size(558, 506);
            this.flowLayout_Customer.TabIndex = 0;
            // 
            // customerInformation1
            // 
            this.customerInformation1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerInformation1.Id = null;
            this.customerInformation1.Location = new System.Drawing.Point(3, 3);
            this.customerInformation1.Name = "customerInformation1";
            this.customerInformation1.Name1 = null;
            this.customerInformation1.Size = new System.Drawing.Size(548, 0);
            this.customerInformation1.TabIndex = 0;
            // 
            // fListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayout_Customer);
            this.Name = "fListCustomer";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.fListCustomer_Load);
            this.flowLayout_Customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_Customer;
        private CustomerInformation customerInformation1;
    }
}