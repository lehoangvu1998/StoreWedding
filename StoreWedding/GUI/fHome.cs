using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUS.Model;
using static BUS.Model.UserModel;

namespace StoreWedding.GUI
{
    public partial class fHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        fStore st = new fStore();
        fCustomer cus = new fCustomer();
        fCategory cat = new fCategory();
        fProduct pro = new fProduct();
        fStaff staff = new fStaff();
        fChangePass ch = new fChangePass();

        public fHome()
        {
            InitializeComponent();
        }

        private void btnsanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_Content.Show();
            pn_Content.Controls.Clear();
            pro.TopLevel = false;
            pro.Dock = DockStyle.Fill;
            pn_Content.Controls.Add(pro);
            pro.Show();
        }

        private void btnnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_Content.Show();
            pn_Content.Controls.Clear();
            staff.TopLevel = false;
            staff.Dock = DockStyle.Fill;
            pn_Content.Controls.Add(staff);
            staff.Show();
        }

        private void btnkhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_Content.Show();
            pn_Content.Controls.Clear();
            cus.TopLevel = false;
            cus.Dock = DockStyle.Fill;
            pn_Content.Controls.Add(cus);
            cus.Show();
        }

        private void btnDanhmuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_Content.Show();
            pn_Content.Controls.Clear();
            cat.TopLevel = false;
            cat.Dock = DockStyle.Fill;
            pn_Content.Controls.Add(cat);
            cat.Show();
        }

        private void btntaikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            fAccount ac = new fAccount();
            ac.ShowDialog();
        }

        private void btn_login_ItemClick(object sender, ItemClickEventArgs e)
        {
            OverlayShowForm.Instance.ShowFormOverlay(this);
            fLogin frm = new fLogin();
            frm.ShowDialog();
            CheckUserExist();
        }

        private void CheckUserExist()
        {
            UserModel user = GlobalInfo.CurrentUser;
            if (user != null)
            {
                if (user.Name != null)
                {
                    if (user.Piority == true)
                    {
                        lb_name.Caption = "Chào quản trị viên: "+user.Name;
                        lb_email.Caption = "Email: "+user.Email;
                        ShowHideByPriotity(true);
                        Task(true);
                    }
                    else
                    {
                        lb_name.Caption = "Chào nhân viên: " + user.Name;
                        lb_email.Caption = "Email: " + user.Email;
                        ShowHideByPriotity(true);
                        Task(false);
                    }
                }
                else
                {
                    lb_name.Caption = "Hi";
                    lb_email.Caption = "Welcome back!";
                    ShowHideByPriotity(false);
                }
            }
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_Content.Show();
            pn_Content.Controls.Clear();
            st.TopLevel = false;
            st.Dock = DockStyle.Fill;
            pn_Content.Controls.Add(st);
            st.Show();
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            ShowHideByPriotity(false);
            lb_date.Caption = DateTime.Now.ToString();
        }

        private void btnhopdong_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_Content.Show();
            pn_Content.Controls.Clear();
            st.TopLevel = false;
            st.Dock = DockStyle.Fill;
            pn_Content.Controls.Add(st);
            st.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            GlobalInfo.CurrentUser = new UserModel();
            CheckUserExist();
        }

        private void btn_ChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            OverlayShowForm.Instance.ShowFormOverlay(this);
            fChangePass frm = new fChangePass();
            frm.ShowDialog();
        }

        private void ShowHideByPriotity(bool val)
        {
            cat.Enabled = val;
            pro.Enabled = val;
            cus.Enabled = val;
            staff.Enabled = val;
            st.Enabled = val;
            ribbonLogin.Visible = !val;
            ribbonChange.Visible = val;
            ribbonLogout.Visible = val;
        }
        private void Task(bool val)
        {
            cat.groupChucNang.Visible = val;
            pro.groupChucNang.Visible = val;
            staff.groupChucNang.Visible = val;
            cus.groupChucNang.Visible = val;
        }
    }
}