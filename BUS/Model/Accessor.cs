using DAO;

namespace BUS.Model
{
    class Accessor
    {
        //Category
        public static System.Data.Linq.Table<CATEGORY> GetCategoryTable()
        {
            ShopWeddingDBDataContext db = DBConnection.getInstance();
            return db.GetTable<CATEGORY>();
        }
        //Product
        public static System.Data.Linq.Table<PRODUCT> GetProductTable()
        {
            ShopWeddingDBDataContext db = DBConnection.getInstance();
            return db.GetTable<PRODUCT>();
        }
        //customer
        public static System.Data.Linq.Table<CUSTOMER> GetCustomerTable()
        {
            ShopWeddingDBDataContext db = DBConnection.getInstance();
            return db.GetTable<CUSTOMER>();
        }
        //staff
        public static System.Data.Linq.Table<STAFF> GetStaffTable()
        {
            ShopWeddingDBDataContext db = DBConnection.getInstance();
            return db.GetTable<STAFF>();
        }
        //contact
        public static System.Data.Linq.Table<CONTRACT> GetContactTable()
        {
            ShopWeddingDBDataContext db = DBConnection.getInstance();
            return db.GetTable<CONTRACT>();
        }
        //billing
        public static System.Data.Linq.Table<BILL> GetBillingTable()
        {
            ShopWeddingDBDataContext db = DBConnection.getInstance();
            return db.GetTable<BILL>();
        }
    }
}
