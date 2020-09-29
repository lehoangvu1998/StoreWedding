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

namespace StoreWedding.GUI
{
    public partial class fAccount : DevExpress.XtraEditors.XtraForm
    {
        public fAccount()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            fPass p = new fPass();
            p.ShowDialog();
        }
    }
}