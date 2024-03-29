using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (var context = new MyStockEfcContext())
                {
                    products = context.Products.Include(c => c.Category).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return products;
        }
        public static void SaveProduct(Product product)
        {
            try
            {
                using (var context = new MyStockEfcContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteProduct(Product product)
        {
            try
            {
                using (var context = new MyStockEfcContext())
                {
                    var p1 = context.Products.SingleOrDefault(m => m.ProductId == product.ProductId);
                    context.Products.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateProduct(Product product)
        {
            try
            {
                using (var context = new MyStockEfcContext())
                {
                    context.Products.Update(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
