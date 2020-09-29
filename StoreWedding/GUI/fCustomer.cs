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
    public partial class fCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerBUS customerBUS;
        public fCustomer()
        {
            customerBUS = CustomerBUS.getInstance();
            InitializeComponent();
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            cb_endMail.Text = "@gmail.com";
            cb_endMail.Items.Add("@gmail.com");
            cb_endMail.Items.Add("@yahoo.com");
            disappearButton(true);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clearData();
            grid_Customer.Enabled = false;
            disappearButton(false);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!txt_ID.Text.Equals(""))
            {
                disappearButton(false);
            }
            else
                MessageBox.Show("Chưa chọn item để sửa", "Thông báo");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!txt_ID.Text.Equals(""))
            {
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    customerBUS.deleteCustomer(int.Parse(txt_ID.Text.Trim()));
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadAllCustomer();
                }
            }
            else
                MessageBox.Show("You never choose item need to delete");
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            disappearButton(true);
            grid_Customer.Enabled = true;
        }
        //Load data
        private void LoadAllCustomer()
        {
            grid_Customer.DataSource = customerBUS.GetListAllCustomer();
        }
        private void disappearButton(bool isVisiable)
        {
            btn_Add.Enabled = isVisiable;
            btn_Update.Enabled = isVisiable;
            btn_Clear.Enabled = !isVisiable;
            btn_Submit.Enabled = !isVisiable;
            btn_Delete.Enabled = isVisiable;
            btn_Cancle.Enabled = !isVisiable;
        }
        private void clearData()
        {
            txt_ID.ResetText();
            txt_Name.ResetText();
            txt_Number.ResetText();
            txt_IDCard.ResetText();
            txt_email.ResetText();
            txt_Address.ResetText();
            txt_Name.Focus();
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoadAllCustomer();
        }
        private void ValidateForm()
        {
            if (txt_ID.Text.Equals(""))
            {
                if (checkData())
                {
                    customerBUS.InsertOrUpdateCustomer(0, txt_Name.Text.Trim(), txt_email.Text.Trim() + cb_endMail.Text.Trim(), txt_Number.Text.Trim(),
                        txt_Address.Text.Trim(), txt_IDCard.Text.Trim());
                    grid_Customer.Enabled = true;
                    LoadAllCustomer();
                    disappearButton(true);
                }
            }
            else
            {
                customerBUS.InsertOrUpdateCustomer(int.Parse(txt_ID.Text.Trim()), txt_Name.Text.Trim(), txt_email.Text.Trim() + cb_endMail.Text.Trim(), txt_Number.Text.Trim(),
                   txt_Address.Text.Trim(), txt_IDCard.Text.Trim());
                grid_Customer.Enabled = true;
                LoadAllCustomer();
                disappearButton(true);
            }
        }

        private void grid_Customer_SelectionChanged(object sender, EventArgs e)
        {
            int pos = grid_Customer.CurrentCell.RowIndex;
            loadCustomer(pos);
        }
        private void loadCustomer(int pos)
        {
            try
            {
                txt_ID.Text = grid_Customer.Rows[pos].Cells[0].Value.ToString().Trim();
                txt_Name.Text = grid_Customer.Rows[pos].Cells[1].Value.ToString().Trim();
                string email = grid_Customer.Rows[pos].Cells[2].Value.ToString().Trim();
                int idx = email.IndexOf("@");
                int end = email.Length - idx;
                string splitEmail = "";
                string splitEmailEnd = "";
                if (idx != -1)
                {
                    splitEmail = email.Substring(0, idx);
                    splitEmailEnd = email.Substring(idx, end);

                }
                txt_email.Text = splitEmail;
                cb_endMail.Text = splitEmailEnd;
                txt_Number.Text = grid_Customer.Rows[pos].Cells[3].Value.ToString().Trim();
                txt_Address.Text = grid_Customer.Rows[pos].Cells[4].Value.ToString().Trim();
                txt_IDCard.Text = grid_Customer.Rows[pos].Cells[5].Value.ToString().Trim();
            }
            catch (Exception e) { }
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Space) && (txt_Name.TextLength == 0))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
                if (Control.IsKeyLocked(Keys.CapsLock))
                    e.Handled = true;
                else
                {
                    bool back = false;
                    if (txt_Name.TextLength == 0)
                    {
                        back = false;
                    }
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        back = true;
                    }
                    if (!back)
                    {
                        if ((txt_Name.TextLength == 0) || (txt_Name.Text.EndsWith(" ")))
                        {
                            //if ((e.KeyChar == (char)Keys.Space) || (e.KeyChar== 127) )
                            if ((e.KeyChar == (char)Keys.Space) || (e.KeyChar == 127))
                            {
                                txt_Name.Text = txt_Name.Text.Remove(txt_Name.Text.LastIndexOf(" "), 1);
                            }
                            txt_Name.AppendText(char.ToUpper(e.KeyChar).ToString());
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txt_Number.Text.StartsWith("0"))
                {
                    //do not something
                }
                else
                {
                    MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0");
                    txt_Number.Text = "0";
                    e.Handled = true;
                }
                if (txt_Number.TextLength <= 10)
                {
                    //do not something
                }
                else
                {
                    MessageBox.Show("Số điện thoại chỉ tối đa 10 số!");
                    e.Handled = true;
                }
                //To enter only numbers Text box
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txt_IDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //To enter only numbers Text box
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
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
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Bạn chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Number.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Number.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Address.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_IDCard.Text))
            {
                MessageBox.Show("Bạn chưa nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IDCard.Focus();
                return false;
            }

            return true;
        }
    }
}