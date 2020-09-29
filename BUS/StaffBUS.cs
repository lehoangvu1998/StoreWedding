using DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace BUS
{
    public class StaffBUS
    {
        private static volatile StaffBUS instance;
        ShopWeddingDBDataContext db;
        private StaffBUS()
        {
            db = DBConnection.getInstance();
        }

        public static StaffBUS getInstance()
        {
            if (instance == null)
            {
                instance = new StaffBUS();
            }
            return instance;
        }
        // get Name Customer
        public string getNameStaff(int key)
        {
            string nameStaff = (from c in db.STAFFs
                                  where c.IDSTAFF == key
                                  select c).Single().STAFFNAME;
            return nameStaff;
        }
        //get id staff
        public List<STAFF> GetListAllStaff(int key, bool type)
        {
            var query = from s in db.STAFFs
                        orderby s.STAFFNAME
                        where s.IDSTAFF == key && s.TYPE == type
                        select s;

            return query.ToList();
        }
       //get ListALlStaff
        public List<STAFF> GetListAllStaff(bool type)
        {
            var query = from c in db.STAFFs
                        orderby c.STAFFNAME
                        where c.TYPE == type
                        select c;

            return query.ToList();
        }

        
       //Insert, Update the Staff
       public void InsertOrUpdateStaff(int staffId, string staffName, string staffEmail,
           string staffPhone, string staffAddress, string staffCard, string staffPass)
       {
           var matchedstaff = (from p in db.GetTable<STAFF>()
                                 where p.IDSTAFF == staffId
                                 select p).SingleOrDefault();

           if (matchedstaff == null)
           {
               try
               {
                   // create new staff record since staff ID
                   // does not exist
                   Table<STAFF> staffs = Model.Accessor.GetStaffTable();
                    STAFF staff = new STAFF();

                   staff.STAFFNAME = staffName;
                   staff.EMAIL = staffEmail;
                   staff.PHONENUMBER = staffPhone;
                   staff.ADDRES = staffAddress;
                   staff.IDCARD = staffCard;
                    staff.PASS = staffPass;

                   staffs.InsertOnSubmit(staff);
                   staffs.Context.SubmitChanges();
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
                   matchedstaff.STAFFNAME = staffName;
                   matchedstaff.EMAIL = staffEmail;
                   matchedstaff.PHONENUMBER = staffPhone;
                   matchedstaff.ADDRES = staffAddress;
                   matchedstaff.IDCARD = staffCard;
                   db.SubmitChanges();
               }
               catch (Exception ex)
               {
                   throw ex;
               }
           }
       }
        //Delete
        public void deleteStaff(int staffId)
        {
            var matchedStaff = (from c in db.GetTable<STAFF>()
                                   where c.IDSTAFF == staffId
                                   select c).SingleOrDefault();

            try
            {
                db.STAFFs.DeleteOnSubmit(matchedStaff);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
