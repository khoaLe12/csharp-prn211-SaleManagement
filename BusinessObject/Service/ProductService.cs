using AutoMapper;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
namespace BusinessObject.Service
{
    public class ProductService :IProductService
    {
        IProductRepository _productRepository = new ProductRepository();
        IMapper _mapper;
        IOrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        public ProductService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductObject>();
                cfg.CreateMap<ProductObject, Product>();
            });
            this._mapper = config.CreateMapper();
        }
        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductObject>();
                cfg.CreateMap<ProductObject, Product>();
            });
            this._mapper = config.CreateMapper();

        }
       public IEnumerable<ProductObject> FindAll(string term = null)
        {         
            if (term is null || term.Trim().Length <= 0) return _productRepository.getAllProduct().Select(e => _mapper.Map<Product,ProductObject>(e));
            else return _productRepository.getAllProduct().Where(prod => prod.ProductName.Contains(term)).Select(e => _mapper.Map<Product, ProductObject>(e));
        }

        public void Create(ProductObject product)
        {
            if(product is not null)
            {
                _productRepository.CreateProdcut(_mapper.Map<ProductObject,Product>(product));
            }
        }

        public void Update(ProductObject product)
        {
            if (product is not null)
            {
                _productRepository.UpdateProduct(_mapper.Map<ProductObject, Product>(product));
            }
        }

        public void Delete(int id)
        {
            _orderDetailRepository.getAllOrderDetail().Where(d => d.ProductId == id).ToList().ForEach(e =>
            {
                _orderDetailRepository.DeleteOrderDetail(e);
            });
            _productRepository.DeleteProduct(id);
        }

        public ProductObject GetById(int id)
        {
            var product = _productRepository.GetProduct(id);
            return _mapper.Map<Product, ProductObject>(product);
        }
    }
}
