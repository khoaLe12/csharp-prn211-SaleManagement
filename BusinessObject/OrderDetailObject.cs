using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetailObject
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public virtual OrderObject Order { get; set; } = null!;

        public virtual ProductObject Product { get; set; } = null!;
        public OrderDetailObject() { }
        public OrderDetailObject(int orderId, int productId, int unitPrice, int quantity, double discount, OrderObject order, ProductObject product)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
            Order = order;
            Product = product;
        }
    }
}
