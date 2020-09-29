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
    public class ContactBUS
    {
        private string Format = "dd/MM/yyyy";
        private static volatile ContactBUS instance;
        ShopWeddingDBDataContext db;
        ProductBUS productBUS;
        CustomerBUS customerBUS;
        StaffBUS staffBUS;
        private ContactBUS()
        {
            staffBUS = StaffBUS.getInstance();
            productBUS = ProductBUS.getInstance();
            customerBUS = CustomerBUS.getInstance();
            db = DBConnection.getInstance();
        }

        public static ContactBUS getInstance()
        {
            if (instance == null)
            {
                instance = new ContactBUS();
            }
            return instance;
        }
        //get ListALlContact
        public List<ContactModel> GetListAllContact()
        {
            var query = from c in db.CONTRACTs
                        orderby c.CONTRACTDATE
                        select new ContactModel
                        {
                            IDCONTACT = c.IDCONTRACT,
                            DATECONTECT = c.CONTRACTDATE.ToString(Format, CultureInfo.InvariantCulture),
                            DATERECIVED = c.DATERECEIVEPRODUCT.ToString(Format, CultureInfo.InvariantCulture),
                            DATEPAY = c.DATEPAY.ToString(Format, CultureInfo.InvariantCulture),
                            NAMESTAFF = staffBUS.getNameStaff(int.Parse(c.IDSTAFF.ToString())),
                            NAMECUSTOMER = customerBUS.getNameCustomer(int.Parse(c.IDCUSTOMER.ToString())),
                            NAMEPRODUCT = productBUS.getNameProduct(int.Parse(c.IDPRODUCT.ToString())),
                        };

            return query.ToList();
        }

        public bool InsertContact(string dateContact, string dateRecived, string datePay, int customerId, int staffId, int productId)
        {
            try
            {
                Table<CONTRACT> contacts = Model.Accessor.GetContactTable();
                CONTRACT contact = new CONTRACT();

                contact.CONTRACTDATE = toDateTime(dateContact);
                contact.DATERECEIVEPRODUCT = toDateTime(dateRecived);
                contact.DATEPAY = toDateTime(datePay);
                contact.IDCUSTOMER = customerId;
                contact.IDSTAFF = staffId;
                contact.IDPRODUCT = productId;

                contacts.InsertOnSubmit(contact);
                contacts.Context.SubmitChanges();
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
        //Delete
        public void deleteContact(int contactID)
        {
            var matchedContact = (from c in db.GetTable<CONTRACT>()
                                   where c.IDCONTRACT == contactID
                                   select c).SingleOrDefault();

            try
            {
                db.CONTRACTs.DeleteOnSubmit(matchedContact);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
