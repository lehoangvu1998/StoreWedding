using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class BillModel
    {
        private int _IDCONTACT;
        private String _DATECONTECT;
        private String _DATERECIVED;
        private String _DATEPAY;
        private String _IDSTAFF;
        private String _IDCUSTOMER;
        private String _IDPRODUCT;
        private int _AMOUNT;
        private int _TOTAL;

        public string NAMEPRODUCT { get => _IDPRODUCT; set => _IDPRODUCT = value; }
        public string NAMECUSTOMER { get => _IDCUSTOMER; set => _IDCUSTOMER = value; }
        public string NAMESTAFF { get => _IDSTAFF; set => _IDSTAFF = value; }
        public string DATEPAY { get => _DATEPAY; set => _DATEPAY = value; }
        public string DATERECIVED { get => _DATERECIVED; set => _DATERECIVED = value; }
        public string DATECONTECT { get => _DATECONTECT; set => _DATECONTECT = value; }
        public int IDCONTACT { get => _IDCONTACT; set => _IDCONTACT = value; }
        public int AMOUNT { get => _AMOUNT; set => _AMOUNT = value; }
        public int TOTAL { get => _TOTAL; set => _TOTAL = value; }
    }
}
