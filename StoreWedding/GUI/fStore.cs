using System;
using System.Data;
using BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraEditors;
using System.Globalization;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace StoreWedding.GUI
{
    public partial class fStore : DevExpress.XtraEditors.XtraForm
    {
        ProductBUS productBUS;
        CategoryBUS categoryBUS;
        CustomerBUS customerBUS;
        ContactBUS contactBUS;
        int idContact = 0;
        public fStore()
        {
            categoryBUS = CategoryBUS.getInstance();
            productBUS = ProductBUS.getInstance();
            customerBUS = CustomerBUS.getInstance();
            contactBUS = ContactBUS.getInstance();
            Utils.setCurrentDictionary();
            InitializeComponent();
        }

        private void FormatDate(DateEdit dateEdit)
        {
            dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEdit.Properties.DisplayFormat.FormatString = "dd' tháng 'MM' năm 'yyyy";
        }
        private void SetMinMaxDate(DateEdit dateRecived, DateEdit dateBill)
        {
            dateRecived.Properties.MinValue = dateBill.DateTime;
            //dateEdit.Properties.MaxValue = new DateTime(DateTime.Now.Year, 12, 31);
        }
        private void fStore_Load(object sender, EventArgs e)
        {
            date_Bill.EditValue = System.DateTime.Today;
            FormatDate(date_Bill);
            FormatDate(dateEdit_Recived);
            FormatDate(dateEdit_Return);
            SetMinMaxDate(dateEdit_Recived, date_Bill);
            LoadProduct();
            loadDefaultRadbutton();
        }

        private void LoadProduct()
        {
            DataTable dt = Utils.ToDataTable(productBUS.GetListAllImageProduct());
            grid_Product.DataSource = Utils.AutoNumberedTable(dt);
        }
        private void CheckRadio(object sender, EventArgs e)
        {
            if (rd_FriendShipCus.Checked)
            {
                ClearCustomer();
                rd_StrangerCus.Checked = false;
                label7.Visible = true;
                cb_Customer.Visible = true;
                GetAllCustomer(0);
            }
            if (rd_StrangerCus.Checked)
            {
                OverlayShowForm.Instance.ShowFormOverlay(this);
                fStangerCustomer frm = new fStangerCustomer();
                frm.ShowDialog();
                loadDefaultRadbutton();
                if (fStangerCustomer.id != 0)
                {
                    GetAllCustomer(fStangerCustomer.id);
                }

            }
        }
        private void loadDefaultRadbutton()
        {
            rd_FriendShipCus.Checked = true;
            rd_StrangerCus.Checked = false;
        }

        //Cancel
        private void ClearCustomer()
        {
            cb_Customer.Properties.DataSource = null ;
            cb_Customer.DataBindings.Clear();
            cb_Customer.ResetText();
        }

        // get all customer
        private void GetAllCustomer(int key)
        {
            DataTable dt;
            if (key != 0)
            {
                dt = Utils.ToDataTable(customerBUS.GetListAllCustomer(key));
            }
            else
            {
                dt = Utils.ToDataTable(customerBUS.GetListAllCustomer());
            }
            cb_Customer.Properties.DataSource = dt;
            cb_Customer.Properties.DisplayMember = "CUSTOMERNAME";
            cb_Customer.Properties.ValueMember = "IDCUSTOMER";
        }
        // get all contact
        private void LoadAllContact()
        {
            DataTable dt = Utils.ToDataTable(contactBUS.GetListAllContact());
            grid_Contact.DataSource = Utils.AutoNumberedTable(dt); ;
        }
        // get id
        private void GetIdProduct(int key)
        {
            DataTable dt = Utils.ToDataTable(productBUS.GetIDPRoduct(key));
            cb_Product.DataSource = dt;
            cb_Product.DisplayMember = "Tên sản phẩm";
            cb_Product.ValueMember = "Mã sản phẩm";
        }
        private void gridView_Product_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int keyProduct =  int.Parse(gridView_Product.GetDataRow(e.FocusedRowHandle)["Mã sản phẩm"].ToString());
            GetIdProduct(keyProduct);
            GetIdProduct(keyProduct);
            int keyCategory = int.Parse(gridView_Product.GetDataRow(e.FocusedRowHandle)["Mã loại"].ToString());
            txt_category.Text = categoryBUS.GetNameCategory(keyCategory);
        }

        private void dateEdit_Recived_EditValueChanged(object sender, EventArgs e)
        {
            SetMinMaxDate(dateEdit_Return,dateEdit_Recived);
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoadAllContact();
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            string dateBill = date_Bill.DateTime.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            string dateRecivedBill = dateEdit_Recived.DateTime.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            string dateReturn = dateEdit_Return.DateTime.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
           
            if (contactBUS.InsertContact(dateBill, dateRecivedBill, dateReturn, int.Parse(cb_Customer.EditValue.ToString()), 1, int.Parse(cb_Product.SelectedValue.ToString().Trim())))
            {
                MessageBox.Show("Lập hợp đồng thành công", "Thông báo");
            }
            else
                MessageBox.Show("Lỗi!!!","Thông báo");
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            idContact = int.Parse(gridView1.GetDataRow(e.FocusedRowHandle)["IDCONTACT"].ToString());
        }

        private void btn_ViewBill_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount != 0 && idContact != 0)
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    if (gridView1.IsRowSelected(i))
                    {
                        OverlayShowForm.Instance.ShowFormOverlay(this);
                        fBilling frm = new fBilling(idContact);
                        frm.ShowDialog();
                    }
                }
            }
            else 
                MessageBox.Show("Vui lòng chọn thông tin hóa đơn cần xem !!!");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (idContact != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    contactBUS.deleteContact(idContact);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadAllContact();
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn item để xóa");
        }
    }
}