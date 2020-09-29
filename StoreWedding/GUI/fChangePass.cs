using System;
using System.Windows.Forms;
using BUS.Model;
using BUS;
using static BUS.Model.UserModel;

namespace StoreWedding.GUI
{
    public partial class fChangePass : DevExpress.XtraEditors.XtraForm
    {
        AccountBUS accountBUS;
        public fChangePass()
        {
            accountBUS = AccountBUS.getInstance();
            InitializeComponent();
        }

        private void ck_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Password.Checked == true)
            {
                txt_Password.PasswordChar = '\0';
                txt_newpass.PasswordChar = '\0';
                txt_repass.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
                txt_newpass.PasswordChar = '*';
                txt_repass.PasswordChar = '*';
            }
        }

        private void fChangePass_Load(object sender, EventArgs e)
        {
            UserModel user = GlobalInfo.CurrentUser;
            if (user.Name != "")
            {
                txt_User.Text = user.Name;
            }
        }
        public bool chekData()
        {
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Password.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_newpass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_newpass.Focus();
                return false;
            }
            if (txt_newpass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu ít nhất phải 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_newpass.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_repass.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_repass.Focus();
                return false;
            }
            return true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_newpass.ResetText();
            txt_Password.ResetText();
            txt_repass.ResetText();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            UserModel user = GlobalInfo.CurrentUser;
            string passold = txt_Password.Text.Trim();
            string newpass = txt_newpass.Text.Trim();
            string repass = txt_repass.Text.Trim();
            if (chekData())
            {
                if (user.PWD.Trim() == passold)
                {
                    if (passold != newpass)
                    {
                        if (newpass == repass)
                        {
                            accountBUS.UpdatePassword(user.Email, newpass);
                            MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            OverlayShowForm.Instance.CloseProgressPanel();
            this.Close();
        }
    }
}