using BUS;
using System;
using System.Windows.Forms;

namespace StoreWedding.GUI
{
    public partial class fStaff : DevExpress.XtraEditors.XtraForm
    {
        StaffBUS staffBUS;
        public fStaff()
        {
            staffBUS = StaffBUS.getInstance();
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clearData();
            grid_Staff.Enabled = false;
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
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    staffBUS.deleteStaff(int.Parse(txt_ID.Text.Trim()));
                    MessageBox.Show("Xóa thành công","Thông báo");
                    LoadAllStaff();
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn item để xóa");
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
            grid_Staff.Enabled = true;
        }
        //Load data
        private void LoadAllStaff()
        {
            grid_Staff.DataSource = staffBUS.GetListAllStaff(false);
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
            LoadAllStaff();
        }
        private void ValidateForm()
        {
            if (txt_ID.Text.Equals(""))
            {
                if (checkData())
                {
                    staffBUS.InsertOrUpdateStaff(0, txt_Name.Text.Trim(), txt_email.Text.Trim() + cb_endMail.Text.Trim(), txt_Number.Text.Trim(),
                        txt_Address.Text.Trim(), txt_IDCard.Text.Trim(), txt_IDCard.Text.Trim());
                    grid_Staff.Enabled = true;
                    LoadAllStaff();
                    disappearButton(true);
                }
            }
            else
            {
                if (checkData())
                {
                    staffBUS.InsertOrUpdateStaff(int.Parse(txt_ID.Text.Trim()), txt_Name.Text.Trim(), txt_email.Text.Trim() + cb_endMail.Text.Trim(), txt_Number.Text.Trim(),
                       txt_Address.Text.Trim(), txt_IDCard.Text.Trim(), null);
                    grid_Staff.Enabled = true;
                    LoadAllStaff();
                    disappearButton(true);
                }
            }
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            cb_endMail.Text = "@gmail.com";
            cb_endMail.Items.Add("@gmail.com");
            cb_endMail.Items.Add("@yahoo.com");
            disappearButton(true);
        }

        private void grid_Staff_SelectionChanged(object sender, EventArgs e)
        {
            int pos = grid_Staff.CurrentCell.RowIndex;
            loadStaff(pos);
        }
        private void loadStaff(int pos)
        {
            try
            {
                txt_ID.Text = grid_Staff.Rows[pos].Cells[0].Value.ToString().Trim();
                txt_Name.Text = grid_Staff.Rows[pos].Cells[1].Value.ToString().Trim();
                string email = grid_Staff.Rows[pos].Cells[2].Value.ToString().Trim();
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
                txt_Number.Text = grid_Staff.Rows[pos].Cells[3].Value.ToString().Trim();
                txt_Address.Text = grid_Staff.Rows[pos].Cells[4].Value.ToString().Trim();
                txt_IDCard.Text = grid_Staff.Rows[pos].Cells[5].Value.ToString().Trim();
            }
            catch (Exception e) { }
        }

        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Space) && (txt_Address.Text.Length == 0))
                e.Handled = true;
            else
            {
                if (char.IsDigit(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
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
            if (((System.Windows.Forms.TextBoxBase)(sender)).TextLength == 10)
                MessageBox.Show("Số điện thoại chỉ tối đa 10 số!");
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