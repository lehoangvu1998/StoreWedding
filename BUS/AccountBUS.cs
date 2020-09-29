using BUS.Model;
using DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BUS.Model.UserModel;

namespace BUS
{
    public class AccountBUS
    {
        private static volatile AccountBUS instance;
        ShopWeddingDBDataContext db;
        private AccountBUS()
        {
            db = DBConnection.getInstance();
        }

        public static AccountBUS getInstance()
        {
            if (instance == null)
            {
                instance = new AccountBUS();
            }
            return instance;
        }

        //check username and password
        public bool checkUSerNameAndPass(string username, string password)
        {
            try
            {
                var account = (from ac in db.STAFFs
                               where ac.EMAIL == username || ac.PHONENUMBER == username && ac.PASS == password
                               select new UserModel
                               {
                                   Name = ac.STAFFNAME,
                                   Email = ac.EMAIL,
                                   Phone = ac.PHONENUMBER,
                                   PWD = ac.PASS,
                                   Piority = ac.TYPE
                               }).SingleOrDefault();

                GlobalInfo.CurrentUser = new UserModel(account.Name, account.Email, account.Phone, account.PWD, account.Piority);
                if (account.Name != "")
                {
                    return true;
                }
                else
                    return false;
            }
            catch (NullReferenceException ex)
            {
                return false;
                throw ex;
            }
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

        //Insert, Update the account
        public void UpdatePassword(string emailStaff, string pass)
        {
            var matchedStaff = (from a in db.GetTable<STAFF>()
                                  where a.EMAIL == emailStaff
                                  select a).SingleOrDefault();

            if (matchedStaff != null)
            {
                try
                {
                    matchedStaff.PASS = pass;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
