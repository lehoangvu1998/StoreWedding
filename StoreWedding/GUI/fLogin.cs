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
using BUS.Model;

namespace StoreWedding.GUI
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        AccountBUS accountBUS;
        public fLogin()
        {
            accountBUS = AccountBUS.getInstance();
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            OverlayShowForm.Instance.CloseProgressPanel();
            this.Close();
        }

        private void ck_MatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_MatKhau.Checked == true)
            {
                tbpass.Properties.PasswordChar = '\0';
            }
            else
                tbpass.Properties.PasswordChar = '*';
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            errProviderError.ContainerControl = this;
        }
        private void tbusername_Validating(object sender, CancelEventArgs e)
        {
            checkUserName();
        }

        private void tbpass_Validating(object sender, CancelEventArgs e)
        {
            checPassword();
        }
        private bool checkUserName()
        {
            bool bStatus = true;
            if (tbusername.Text == string.Empty || tbusername.Text.Count() < 5)
            {
                errProviderError.SetError(tbusername, "Vui lòng nhập tên người dùng hoặc tên người dùng ít hơn 5 kí tự!!!");
                errorProvider_Correct.SetError(tbusername, "");
                tbusername.Focus();
                bStatus = false;
            }
            else
            {
                errProviderError.SetError(tbusername, "");
                errorProvider_Correct.SetError(tbusername, "Chính xác");
            }
            return bStatus;
        }
        private bool checPassword()
        {
            bool bStatus = true;
            if (tbpass.Text == string.Empty || tbpass.Text.Count() < 5)
            {
                errProviderError.SetError(tbpass, "Vui lòng nhập mật khẩu hoặc mật khẩu ít hơn 5 kí tự!!!");
                errorProvider_Correct.SetError(tbpass, "");
                tbpass.Focus();
                bStatus = false;
            }
            else
            {
                errProviderError.SetError(tbpass, "");
                errorProvider_Correct.SetError(tbpass, "Chính xác");
            }
            return bStatus;
        }
        private void ValidateForm()
        {
            bool bValidName = checkUserName();
            bool bVaildPass = checPassword();
            if (bValidName && bVaildPass)
            {
                if (accountBUS.checkUSerNameAndPass(tbusername.Text.Trim(), tbpass.Text.Trim()))
                {
                    OverlayShowForm.Instance.CloseProgressPanel();
                    this.Close();
                }
                else
                    MessageBox.Show("Đăng nhập tài khoản thất bại!!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}