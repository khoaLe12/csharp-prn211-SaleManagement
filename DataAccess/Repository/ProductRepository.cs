using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Assignment02Context _db;
        public ProductRepository()
        {
            _db = new();
        }
        public void CreateProdcut(Product product)
        {
            if(product != null)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProduct(id);
            if(product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
            }
        }

        public List<Product> getAllProduct()
        {
            return _db.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return _db.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public void UpdateProduct(Product product)
        {
            Product p = GetProduct(product.ProductId);
            if(p != null)
            {
                p.ProductId = p.ProductId;
                p.ProductName = product.ProductName;
                p.UnitPrice = product.UnitPrice;
                p.UnitsInStock = product.UnitsInStock;
                p.CategoryId = product.CategoryId;
                p.Weight = product.Weight;
                _db.Products.Update(p);
                _db.SaveChanges();
            }
        }
    }
}
