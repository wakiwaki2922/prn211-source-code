using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();
            try
            {
                using (var context = new MyStockEfcContext())
                {
                    list = context.Categories.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
    }
}
