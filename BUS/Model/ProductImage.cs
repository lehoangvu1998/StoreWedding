using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class ProductImage
    {
        private int _IDPRODUCT;
        private string _NAMEPRODUCT;
        private string _DESCRIPTIONPRODUCT;
        private Image _IMAGEPRODUCT;
        private String _PRICEPRODUCT;
        private bool _STATUS;
        private int _IDCATEGORY;

        public bool STATUS { get =>_STATUS; set => _STATUS = value; }
        public string PRICEPRODUCT { get => _PRICEPRODUCT; set => _PRICEPRODUCT = value; }
        public Image IMAGEPRODUCT { get => _IMAGEPRODUCT; set => _IMAGEPRODUCT = value; }
        public string DESCRIPTIONPRODUCT { get => _DESCRIPTIONPRODUCT; set => _DESCRIPTIONPRODUCT = value; }
        public string NAMEPRODUCT { get => _NAMEPRODUCT; set => _NAMEPRODUCT = value; }
        public int IDPRODUCT { get => _IDPRODUCT; set => _IDPRODUCT = value; }
        public int IDCATEGORY { get => _IDCATEGORY; set => _IDCATEGORY = value; }
    }
}
