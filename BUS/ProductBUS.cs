using BUS.Model;
using DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BUS
{
    public class ProductBUS
    {
        private static volatile ProductBUS instance;
        ShopWeddingDBDataContext db;
        private ProductBUS()
        {
            db = DBConnection.getInstance();
        }

        public static ProductBUS getInstance()
        {
            if (instance == null)
            {
                instance = new ProductBUS();
            }
            return instance;
        }
        // get Name Product
        public string getNameProduct(int key)
        {
            string nameProduct = (from p in db.PRODUCTs
                                 where p.IDPRODUCT == key
                                 select p).Single().NAMEPRODUCT;
            return nameProduct;
        }

        //get id ListALlProduct
        public List<ProductImage> GetIDPRoduct(int key)
        {
            var query = from p in db.PRODUCTs
                        where p.IDPRODUCT == key
                        select new ProductImage
                        {
                            IDPRODUCT = p.IDPRODUCT,
                            NAMEPRODUCT = p.NAMEPRODUCT,
                        };

            return query.ToList();
        }
        //Search product
        public List<PRODUCT> Search(string keywords)
        {
            var result = db.PRODUCTs
                        .OrderBy(x=> x.NAMEPRODUCT)
                        .Where(x => x.NAMEPRODUCT.Contains(keywords) || x.DESCRIPTIONPRODUCT.Contains(keywords));
            return result.ToList();
        }
        //get ListALlProduct
        public List<PRODUCT> GetListAllProduct()
        {
            var query = from p in db.PRODUCTs
                        orderby p.NAMEPRODUCT
                        select p;

            return query.ToList();
        }
        //get ListALlProduct
        public List<ProductImage> GetListAllImageProduct()
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            var query = from p in db.PRODUCTs
                        orderby p.NAMEPRODUCT
                        select new ProductImage
                        {
                            IDPRODUCT = p.IDPRODUCT,
                            NAMEPRODUCT = p.NAMEPRODUCT,
                            DESCRIPTIONPRODUCT = p.DESCRIPTIONPRODUCT,
                            IMAGEPRODUCT = Utils.LoadImage(p.IMAGEPRODUCT),
                            PRICEPRODUCT = double.Parse(p.PRICE.ToString()).ToString("#,###", cul.NumberFormat),
                            STATUS = p.STATUS,
                            IDCATEGORY = int.Parse(p.IDCATEGORY.ToString()),
                        };

            return query.ToList();
        }
        public int id = 0;
        //Insert, Update the product
        public void InsertOrUpdateProduct(int productId, string productName, string productDescription,
            int productPrice, string productImage,int categoryId, Boolean productStatus)
        {
            var matchedProduct = (from p in db.GetTable<PRODUCT>()
                                   where p.IDPRODUCT == productId
                                   select p).SingleOrDefault();

            if (matchedProduct == null)
            {
                try
                {
                    // create new product record since product ID
                    // does not exist
                    Table<PRODUCT> products = Model.Accessor.GetProductTable();
                    PRODUCT product = new PRODUCT();

                    product.NAMEPRODUCT = productName;
                    product.DESCRIPTIONPRODUCT = productDescription;
                    product.PRICE = productPrice;
                    product.IMAGEPRODUCT = productImage;
                    product.IDCATEGORY = categoryId;
                    product.STATUS = productStatus;

                    products.InsertOnSubmit(product);
                    products.Context.SubmitChanges();
                    id = product.IDPRODUCT;
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
                    matchedProduct.NAMEPRODUCT = productName;
                    matchedProduct.DESCRIPTIONPRODUCT = productDescription;
                    matchedProduct.PRICE = productPrice;
                    matchedProduct.IMAGEPRODUCT = productImage;
                    matchedProduct.IDCATEGORY = categoryId;
                    matchedProduct.STATUS = productStatus;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        //Delete
        public void deleteProduct(int productId)
        {
            var matchedProduct = (from c in db.GetTable<PRODUCT>()
                                   where c.IDPRODUCT == productId
                                   select c).SingleOrDefault();

            try
            {
                db.PRODUCTs.DeleteOnSubmit(matchedProduct);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
