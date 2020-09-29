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
using System.Globalization;

namespace StoreWedding.GUI
{
    public partial class fBilling : DevExpress.XtraEditors.XtraForm
    {
        BillBUS billBUS;
        private static int id = 0;
        public fBilling(int key)
        {
            id = key;
            billBUS = BillBUS.getInstance();
            InitializeComponent();
        }

        private void fBilling_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            DataTable dt = Utils.ToDataTable(billBUS.GetBiilingInfo(1));
            DataRow[] dr = dt.Select("IDCONTACT="+ id);
            lb_NamProduct.Text = dr[0]["Tên sản phẩm"].ToString();
            lb_NameCustomer.Text = dr[0]["Tên khách hàng"].ToString();
            lb_BillDate.Text = dr[0]["Ngày đặt"].ToString();
            lb_RecivedDate.Text = dr[0]["Ngày nhận"].ToString();
            lb_PayDate.Text = dr[0]["Ngày trả"].ToString();
            lb_Amount.Text = dr[0]["AMOUNT"].ToString();
            lb_Price.Text = double.Parse(dr[0]["TOTAL"].ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            OverlayShowForm.Instance.CloseProgressPanel();
            this.Close();
        }
    }
}