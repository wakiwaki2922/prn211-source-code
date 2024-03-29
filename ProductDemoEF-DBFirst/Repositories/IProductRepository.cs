using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        List<Category> GetCategories();
        List<Product> GetProducts();
        void SaveProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
         
    }
}
