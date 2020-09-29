using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreWedding.GUI
{
    public partial class CustomerInformation : System.Windows.Forms.UserControl
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {
            
        }

        #region Properties
        private string _id;
        private string _name;

        public string Id
        {
            get { return _id; }
            set { _id = value; lb_Name.Text = value; }

        }
        public string Name1
        {
            get { return _name; }
            set { _name = value; lb_Email.Text = value; }

        }
        #endregion

        private void CustomerInformation_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void CustomerInformation_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}