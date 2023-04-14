using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        List<Product> getAllProduct();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
        void CreateProdcut(Product product);
        void DeleteProduct(int id);
    }
}
