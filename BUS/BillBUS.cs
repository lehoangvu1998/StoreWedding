using BUS.Model;
using DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillBUS
    {
        private string Format = "dd/MM/yyyy";
        private static volatile BillBUS instance;
        ShopWeddingDBDataContext db;
        ProductBUS productBUS;
        CustomerBUS customerBUS;
        StaffBUS staffBUS;
        private BillBUS()
        {
            staffBUS = StaffBUS.getInstance();
            productBUS = ProductBUS.getInstance();
            customerBUS = CustomerBUS.getInstance();
            db = DBConnection.getInstance();
        }
        public static BillBUS getInstance()
        {
            if (instance == null)
            {
                instance = new BillBUS();
            }
            return instance;
        }
        //get ListALlContact
        public List<BillModel> GetBiilingInfo(int key)
        {
            var query = from t1 in db.BILLs
                        join t2 in db.CONTRACTs on t1.IDCONTRACT equals key
                        select new BillModel
                        {
                            AMOUNT = (int)t1.AMOUNT,
                            TOTAL = (int)t1.TOTAL,
                            DATECONTECT = t2.CONTRACTDATE.ToString(Format, CultureInfo.InvariantCulture),
                            DATERECIVED = t2.DATERECEIVEPRODUCT.ToString(Format, CultureInfo.InvariantCulture),
                            DATEPAY = t2.DATEPAY.ToString(Format, CultureInfo.InvariantCulture),
                            NAMESTAFF = staffBUS.getNameStaff(int.Parse(t2.IDSTAFF.ToString())),
                            NAMECUSTOMER = customerBUS.getNameCustomer(int.Parse(t2.IDCUSTOMER.ToString())),
                            NAMEPRODUCT = productBUS.getNameProduct(int.Parse(t2.IDPRODUCT.ToString())),
                            IDCONTACT = t2.IDCONTRACT
                        };

            return query.ToList();
        }

        public bool InsertBilling(string dateContact, int total, int idContact, int productId)
        {
            try
            {
                Table<BILL> bills = Model.Accessor.GetBillingTable();
                BILL bill = new BILL();

                bill.AMOUNT = 1;
                bill.BILLINGDATE = toDateTime(dateContact);
                bill.TOTAL =total ;
                bill.IDCONTRACT = idContact;
                bill.IDPRODUCT = productId;

                bills.InsertOnSubmit(bill);
                bills.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        private DateTime toDateTime(string date)
        {
            string[] validformats = new[] { "dd-MM-yyyy", "yyyy/MM/dd", "MM/dd/yyyy HH:mm:ss",
                                        "MM/dd/yyyy hh:mm tt", "yyyy-MM-dd HH:mm:ss,fff" };

            CultureInfo provider = new CultureInfo("en-US");

            try
            {
                DateTime dateTime = DateTime.ParseExact(date, validformats[0], provider);
                return dateTime;
            }
            catch (FormatException)
            {
                return DateTime.Now;
            }
        }
    }
}
