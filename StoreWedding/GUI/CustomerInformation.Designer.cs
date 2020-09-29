namespace StoreWedding.GUI
{
    partial class CustomerInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_CMND = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(13, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(217, 29);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Tên khách hàng:";
            // 
            // lb_Email
            // 
            this.lb_Email.Location = new System.Drawing.Point(18, 33);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(101, 23);
            this.lb_Email.TabIndex = 1;
            this.lb_Email.Text = "Email: ";
            // 
            // lb_Phone
            // 
            this.lb_Phone.Location = new System.Drawing.Point(18, 56);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(101, 23);
            this.lb_Phone.TabIndex = 2;
            this.lb_Phone.Text = "Số điện thoại:";
            // 
            // lb_CMND
            // 
            this.lb_CMND.Location = new System.Drawing.Point(18, 79);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(101, 23);
            this.lb_CMND.TabIndex = 3;
            this.lb_CMND.Text = "CMND:";
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lb_CMND);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Name);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "CustomerInformation";
            this.Size = new System.Drawing.Size(557, 109);
            this.Load += new System.EventHandler(this.CustomerInformation_Load);
            this.MouseEnter += new System.EventHandler(this.CustomerInformation_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CustomerInformation_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_CMND;
    }
}
