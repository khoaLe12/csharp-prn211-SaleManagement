using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ProductObject
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; } = null!;

        public string Weight { get; set; } = null!;

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public virtual ICollection<OrderDetailObject> OrderDetails { get; } = new List<OrderDetailObject>();
        public ProductObject()
        {

        }
        public ProductObject(int productId, int categoryId, string productName, string weight, decimal unitPrice, int unitsInStock, ICollection<OrderDetailObject> orderDetails)
        {
            ProductId = productId;
            CategoryId = categoryId;
            ProductName = productName;
            Weight = weight;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            OrderDetails = orderDetails;
        }
    }
}
