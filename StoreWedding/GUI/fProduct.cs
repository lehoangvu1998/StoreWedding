using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using BUS;

namespace StoreWedding.GUI
{
    public partial class fProduct : DevExpress.XtraEditors.XtraForm
    {
        public bool themmoi = false;
        string image;
        Image file;
        ProductBUS productBUS;
        CategoryBUS categoryBUS;
        public fProduct()
        {
            productBUS = ProductBUS.getInstance();
            categoryBUS = CategoryBUS.getInstance();
            InitializeComponent();
        }

        private void fProduct_Load(object sender, EventArgs e)
        {
            Utils.setCurrentDictionary();
            SetNull();
            SetButton(true);
        }
        DataTable table = new DataTable();
        //Load Product
        private void LoadAllProduct()
        {
            int counter = 1;
           
            list_Products.Items.Clear();
            list_Products.FullRowSelect = true;
            table = Utils.ToDataTable(productBUS.GetListAllProduct());
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem liv = new ListViewItem(counter.ToString());
                liv.SubItems.Add(row[0].ToString());
                liv.SubItems.Add(row[1].ToString());
                liv.SubItems.Add(row[2].ToString());
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                string price = double.Parse(row[3].ToString()).ToString("#,###", cul.NumberFormat);
                liv.SubItems.Add(price);
                liv.SubItems.Add(row[4].ToString());
                liv.SubItems.Add(row[5].ToString());
                liv.SubItems.Add(row[6].ToString());
                list_Products.Items.Add(liv);
                counter++;
            }
        }

        private void list_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Products.SelectedItems.Count > 0)
            {
                ListViewItem list = list_Products.SelectedItems[0];
                txt_ID.Text = list.SubItems[1].Text;
                txt_Name.Text = list.SubItems[2].Text;
                rt_Description.Text = list.SubItems[3].Text;
                txt_Price.Text = list.SubItems[4].Text;
                int categoryId = int.Parse(list.SubItems[5].Text);
                cb_categoryId.Properties.NullText = categoryBUS.GetNameCategory(categoryId);
                image = list.SubItems[6].Text;
                pic_Product.Image = Utils.LoadImage(image);
                bool status = bool.Parse(list.SubItems[7].Text);
                string showStatus = status ? "Đã đặt" : "Chưa đặt".ToString();  
                txt_Status.Text = showStatus;

            }
        }
        private void txt_Search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Search.ResetText();
        }
        //Show list category
        void ShowListCategory()
        {
            DataTable dt = Utils.ToDataTable(categoryBUS.GetListAllCategory());
            cb_categoryId.Properties.DataSource = dt;
            cb_categoryId.Properties.DisplayMember = "Tên loại";
            cb_categoryId.Properties.ValueMember = "Mã loại";
        }
       
        //Not display Category
        void Cancel()
        {
            cb_categoryId.Properties.DataSource = null;
            cb_categoryId.DataBindings.Clear();
            cb_categoryId.Properties.NullText = "<Chọn mã danh mục>";
        }
        private void SetNull()
        {
            txt_ID.ResetText();
            txt_Name.ResetText();
            txt_Price.ResetText();
            txt_Status.ResetText();
            rt_Description.ResetText();
            pic_Product.Image = null;
            txt_Name.Focus();
            list_Products.Items.Clear();
            Cancel();
        }
        void SetButton(bool val)
        {
            btn_Update.Enabled = val;
            btn_Add.Enabled = val;
            btn_Cancel.Enabled = val;
            btn_Delete.Enabled = val;
            btn_ChooseImage.Enabled = !val;
            btn_Save.Enabled = !val;
            btn_Cancel.Enabled = !val;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Search.Text.Equals("") || txt_Search.Text == "Nhập thông tin")
                {
                    MessageBox.Show("Thông tin không được rỗng", "Thông báo");
                }
                else
                {
                    if (!searchProduct())
                    {
                        MessageBox.Show("Không tìm thấy thông tin");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm sai" + ex.Message, "Thông báo");
            }
        }
        //Search
        private bool searchProduct()
        {
            list_Products.Items.Clear();
            list_Products.FullRowSelect = true;
            DataTable dt = Utils.ToDataTable(productBUS.Search(txt_Search.Text.Trim()));
            if (dt.Rows.Count == 0)
                return false;

            int counter = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                ListViewItem liv = new ListViewItem(counter.ToString());
                liv.SubItems.Add(row[0].ToString());
                liv.SubItems.Add(row[1].ToString());
                liv.SubItems.Add(row[2].ToString());
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                string price = double.Parse(row[3].ToString()).ToString("#,###", cul.NumberFormat);
                liv.SubItems.Add(price);
                liv.SubItems.Add(row[4].ToString());
                liv.SubItems.Add(row[5].ToString());
                liv.SubItems.Add(row[6].ToString());
                list_Products.Items.Add(liv);
                counter++;
            }
            return true;
        }

        private void btn_ChooseImage_Click(object sender, EventArgs e)
        {
            openFile.Filter = "(*.jpg)|*.jpg|(*.gif)|*gif|(*.*)|*.*";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.FileName = "placehoder.jpg";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = openFile.FileName;
                file = Image.FromFile(image);
                pic_Product.Image = file;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu ảnh? ", "Lưu ảnh", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string tenhinh = System.IO.Path.GetFileName(image);
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "(*.jpg)|*.jpg|(*.gif)|*gif|(*.*)|*.*";
                string path = System.IO.Directory.GetCurrentDirectory() + "\\" +tenhinh;
                if (!System.IO.File.Exists(path))
                {
                    File.Copy(image, path);
                    MessageBox.Show("Lưu ảnh thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tên ảnh đã tồn tại");
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetNull();
            ShowListCategory();
            SetButton(false);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            SetNull();
            SetButton(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            list_Products.Items.Clear();
            list_Products.FullRowSelect = true;
            int stt = 1;
            image =  Utils.PickImage(pic_Product, image);
            string CuttedImage = image.Substring(image.LastIndexOf("\\") + 1);
            if (themmoi)
            {
                if (chekData())
                {
                    productBUS.InsertOrUpdateProduct(0,txt_Name.Text.Trim(),rt_Description.Text.Trim(), int.Parse(txt_Price.Text.Trim()),
                        CuttedImage.Trim(), int.Parse(cb_categoryId.EditValue.ToString().Trim()), false);
                    ListViewItem liv = new ListViewItem(stt.ToString());
                    liv.SubItems.Add(productBUS.id.ToString());
                    liv.SubItems.Add(txt_Name.Text.Trim());
                    liv.SubItems.Add(rt_Description.Text.Trim());
                    liv.SubItems.Add(txt_Price.Text.Trim());
                    liv.SubItems.Add(cb_categoryId.EditValue.ToString().Trim());
                    liv.SubItems.Add(CuttedImage.Trim());
                    liv.SubItems.Add("false");
                    list_Products.Items.Add(liv);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                if (chekData())
                {
                    list_Products.Items.Clear();
                    string price = txt_Price.Text.Replace(".", string.Empty);
                    Boolean checkStatus = (txt_Status.Text.Trim() == "Đã đặt") ? true : false;
                    productBUS.InsertOrUpdateProduct(int.Parse(txt_ID.Text.Trim()), txt_Name.Text.Trim(), rt_Description.Text.Trim(), int.Parse(price),
                         CuttedImage.Trim(), int.Parse(cb_categoryId.EditValue.ToString().Trim()), checkStatus);
                    ListViewItem liv = new ListViewItem(stt.ToString());
                    liv.SubItems.Add(txt_ID.Text.ToString());
                    liv.SubItems.Add(txt_Name.Text.Trim());
                    liv.SubItems.Add(rt_Description.Text.Trim());
                    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                    string formatPrice = double.Parse(price.ToString()).ToString("#,###", cul.NumberFormat);
                    liv.SubItems.Add(formatPrice);
                    liv.SubItems.Add(cb_categoryId.EditValue.ToString().Trim());
                    liv.SubItems.Add(image.Trim());
                    liv.SubItems.Add(checkStatus.ToString());
                    list_Products.Items.Add(liv);
                    MessageBox.Show("Cập nhật thành công");
                    SetButton(true);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (list_Products.SelectedIndices.Count > 0)
            {
                themmoi = false;
                ShowListCategory();
                SetButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn áo cần cập nhật",
               "Sửa thông tin áo cưới", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoadAllProduct();
            Utils.RepaintListView(list_Products);
        }
        private bool chekData()
        {
            return true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (list_Products.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa sản phẩm", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int key = int.Parse(list_Products.SelectedItems[0].SubItems[1].Text.Trim());
                    productBUS.deleteProduct(key);
                    list_Products.Items.RemoveAt(list_Products.SelectedIndices[0]);
                    MessageBox.Show("XÓA thÀNH cÔNG");
                }
                else
                    MessageBox.Show("khÔNG thỂ xÓA");
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txt_Price.Text.StartsWith("0"))
                {
                    txt_Price.ResetText();
                    MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0");
                    e.Handled = true;
                }
                else
                {
                    //do not something
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
        private bool checkData()
        {
            if (string.IsNullOrWhiteSpace(cb_categoryId.Text))
            {
                MessageBox.Show("Bạn chưa chọn danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Bạn chưa tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Name.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Price.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Price.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(rt_Description.Text))
            {
                MessageBox.Show("Bạn chưa nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rt_Description.Focus();
                return false;
            }

            return true;
        }
    }
}