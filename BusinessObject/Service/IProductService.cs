using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public interface IProductService
    {
        IEnumerable<ProductObject> FindAll(string? term = null);
        void Create(ProductObject product);
        void Update(ProductObject product);
        void Delete(int id);
        ProductObject GetById(int id);  
    }
}
