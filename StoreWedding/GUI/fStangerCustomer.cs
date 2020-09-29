using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace StoreWedding.GUI
{
    public partial class fStangerCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerBUS customerBUS;
        public static int id = 0;
        public fStangerCustomer()
        {
            customerBUS = CustomerBUS.getInstance();
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            OverlayShowForm.Instance.CloseProgressPanel();
            this.Close();
        }

        private void fStangerCustomer_Load(object sender, EventArgs e)
        {
            cb_endMail.Text = "@gmail.com";
            cb_endMail.Items.Add("@gmail.com");
            cb_endMail.Items.Add("@yahoo.com");
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkData())
                {
                    customerBUS.InsertOrUpdateCustomer(0, txt_Name.Text.Trim(), txt_Email.Text.Trim() + cb_endMail.Text.Trim(), txt_Phone.Text.Trim(), txt_Address.Text.Trim(), txt_IdCard.Text.Trim());
                    id = customerBUS.id;
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    OverlayShowForm.Instance.CloseProgressPanel();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
                throw ex;
            }
        }
        private bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Bạn chưa tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Name.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Phone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Address.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_IdCard.Text))
            {
                MessageBox.Show("Bạn chưa nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IdCard.Focus();
                return false;
            }

            return true;
        }
    }
}