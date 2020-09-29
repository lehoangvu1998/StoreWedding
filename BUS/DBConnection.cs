using DAO;

namespace BUS
{
    class DBConnection
    {
        private static volatile ShopWeddingDBDataContext instance;

        private DBConnection()
        {
        }

        public static ShopWeddingDBDataContext getInstance()
        {
            if (instance == null)
            {
                instance = new ShopWeddingDBDataContext();
            }
            return instance;
        }

    }
}
