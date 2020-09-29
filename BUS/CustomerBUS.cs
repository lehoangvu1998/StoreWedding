using DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        private static volatile CustomerBUS instance;
        ShopWeddingDBDataContext db;
        private CustomerBUS()
        {
            db = DBConnection.getInstance();
        }

        public static CustomerBUS getInstance()
        {
            if (instance == null)
            {
                instance = new CustomerBUS();
            }
            return instance;
        }
        // get Name Customer
        public string getNameCustomer(int key)
        {
            string nameCustomer = (from c in db.CUSTOMERs
                                  where c.IDCUSTOMER == key
                                  select c).Single().CUSTOMERNAME;
            return nameCustomer;
        }
        //get id customer
        public List<CUSTOMER> GetListAllCustomer(int key)
        {
            var query = from c in db.CUSTOMERs
                        orderby c.CUSTOMERNAME
                        where c.IDCUSTOMER == key
                        select c;

            return query.ToList();
        }
        //get ListALlCustomer
        public List<CUSTOMER> GetListAllCustomer()
        {
            var query = from c in db.CUSTOMERs
                        orderby c.CUSTOMERNAME
                        select c;

            return query.ToList();
        }

        public int id = 0;
        //Insert, Update the customer
        public void InsertOrUpdateCustomer(int customerId, string customerName, string customerEmail,
            string customerPhone, string customerAddress, string customerCard)
        {
            var matchedCustomer = (from p in db.GetTable<CUSTOMER>()
                                  where p.IDCUSTOMER == customerId
                                  select p).SingleOrDefault();

            if (matchedCustomer == null)
            {
                try
                {
                    // create new customer record since customer ID
                    // does not exist
                    Table<CUSTOMER> customers = Model.Accessor.GetCustomerTable();
                    CUSTOMER customer = new CUSTOMER();

                    customer.CUSTOMERNAME = customerName;
                    customer.EMAIL = customerEmail;
                    customer.PHONENUMBER = customerPhone;
                    customer.ADDRES = customerAddress;
                    customer.IDCARD = customerCard;

                    customers.InsertOnSubmit(customer);
                    customers.Context.SubmitChanges();
                    id = customer.IDCUSTOMER;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    matchedCustomer.CUSTOMERNAME = customerName;
                    matchedCustomer.EMAIL = customerEmail;
                    matchedCustomer.PHONENUMBER = customerPhone;
                    matchedCustomer.ADDRES = customerAddress;
                    matchedCustomer.IDCARD = customerCard;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        //Delete
        public void deleteCustomer(int customerId)
        {
            var matchedCustomer = (from c in db.GetTable<CUSTOMER>()
                                where c.IDCUSTOMER == customerId
                                select c).SingleOrDefault();

            try
            {
                db.CUSTOMERs.DeleteOnSubmit(matchedCustomer);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
