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
    public partial class fListCustomer : DevExpress.XtraEditors.XtraForm
    {
        CategoryBUS categoryBUS;
        public fListCustomer()
        {
            categoryBUS = CategoryBUS.getInstance();
            InitializeComponent();
        }

        private void fListCustomer_Load(object sender, EventArgs e)
        {
            populateListCustomer();
        }
        private void populateListCustomer()
        {
            CustomerInformation[] customer = new CustomerInformation[20];
            for (int i = 0; i < customer.Length; i++)
            {
                customer[i] = new CustomerInformation();
                customer[i].Id = "1";
                customer[i].Name = "test";

                flowLayout_Customer.Controls.Add(customer[i]);
            }
        }
    }
}