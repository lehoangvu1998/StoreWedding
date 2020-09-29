using System;
using System.Windows.Forms;
using BUS;

namespace StoreWedding.GUI
{
    public partial class fCategory : DevExpress.XtraEditors.XtraForm
    {
        CategoryBUS categoryBUS;
        public fCategory()
        {
            categoryBUS = CategoryBUS.getInstance();
            InitializeComponent();
        }

        private void fCategory_Load(object sender, EventArgs e)
        {
            txt_CategoryId.ReadOnly = true;
            LoadCategory();
            disappearButton(true);
            errorProvider.ContainerControl = this;
        }

        private void grid_Category_SelectionChanged(object sender, EventArgs e)
        {
            int pos = grid_Category.CurrentCell.RowIndex;
            loadCategory(pos);
        }

        private void loadCategory(int pos)
        {
            try
            {
                txt_CategoryId.Text = grid_Category.Rows[pos].Cells[0].Value.ToString().Trim();
                txt_CategoryName.Text = grid_Category.Rows[pos].Cells[1].Value.ToString();
            }
            catch (Exception e) { }
        }
        private void grid_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clearData();
            grid_Category.Enabled = false;
            disappearButton(false);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearData();
        }
        private void clearData()
        {
            txt_CategoryId.ResetText();
            txt_CategoryName.ResetText();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!txt_CategoryId.Text.Equals(""))
            {
                disappearButton(false);
            }
            else
                MessageBox.Show("Chua chon item de sửa", "Thong bao");
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            ValidateForm();
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!txt_CategoryId.Text.Equals(""))
            {
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    categoryBUS.deleteCategory(int.Parse(txt_CategoryId.Text.Trim()));
                    LoadCategory();
                }
            }
            else
                MessageBox.Show("You never choose item need to delete");
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            disappearButton(true);
            grid_Category.Enabled = true;
        }

        //Load data
        private void LoadCategory()
        {
            grid_Category.DataSource = categoryBUS.GetListAllCategory();
        }

        private bool ValidateName()
        {
            bool bStatus = true;
            if (txt_CategoryName.Text == "")
            {
                txt_CategoryName.Focus();
                errorProvider.SetError(txt_CategoryName, "Vui lòng nhập tên danh mục");
                bStatus = false;
            }
            else
                errorProvider.SetError(txt_CategoryName, "");
            return bStatus;
        }
        private void ValidateForm()
        {
            bool bValidName = ValidateName();
            if (bValidName)
            {
                if (txt_CategoryId.Text.Equals(""))
                {
                    categoryBUS.InsertOrUpdateCategory(0, txt_CategoryName.Text.Trim());
                }
                else
                {
                    categoryBUS.InsertOrUpdateCategory(int.Parse(txt_CategoryId.Text.Trim()), txt_CategoryName.Text.Trim());
                }
                grid_Category.Enabled = true;
                LoadCategory();
                disappearButton(true);
            }
        }
    }
}