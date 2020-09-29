using BUS.Model;
using DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace BUS
{
    public class CategoryBUS
    {
        private static volatile CategoryBUS instance;
        ShopWeddingDBDataContext db;
        private CategoryBUS()
        {
            db = DBConnection.getInstance();
        }

        public static CategoryBUS getInstance()
        {
            if (instance == null)
            {
                instance = new CategoryBUS();
            }
            return instance;
        }
        //get NameCategory
        public String GetNameCategory(int key)
        {
            ShopWeddingDBDataContext db =  new ShopWeddingDBDataContext(); 
            string name = (from id in db.CATEGORies
                            where id.IDCATEGORY == key
                            select id.NAMECATEGORY).First().ToString();
            return name;
        }
        //get ListAllCatagory
        public List<CATEGORY> GetListAllCategory()
        {
                var query = from c in db.CATEGORies
                            orderby c.NAMECATEGORY
                            select c;

                return query.ToList();
        }

        //Insert, Update the category
        public void InsertOrUpdateCategory(int categoryId, string categoryName)
        {
                var matchedCategory = (from c in db.GetTable<CATEGORY>()
                                       where c.IDCATEGORY == categoryId
                                       select c).SingleOrDefault();
                
                if (matchedCategory == null)
                {
                    try
                    {
                        // create new category record since category ID
                        // does not exist
                        Table<CATEGORY> categories = Accessor.GetCategoryTable();
                        CATEGORY category = new CATEGORY();

                        category.NAMECATEGORY = categoryName;

                        categories.InsertOnSubmit(category);
                        categories.Context.SubmitChanges();
                        MessageBox.Show("Them thanh cong", "Thong bao");
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
                        matchedCategory.NAMECATEGORY = categoryName;
                        db.SubmitChanges();
                        MessageBox.Show("Cap nhat thanh cong", "Thong bao");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
        }

        //Delete
        public void deleteCategory(int categoryId)
        {
            var matchedCategory = (from c in db.GetTable<CATEGORY>()
                                   where c.IDCATEGORY == categoryId
                                   select c).SingleOrDefault();

            try
            {
                db.CATEGORies.DeleteOnSubmit(matchedCategory);
                db.SubmitChanges();
                MessageBox.Show("Xoa thanh cong", "Thong bao");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
