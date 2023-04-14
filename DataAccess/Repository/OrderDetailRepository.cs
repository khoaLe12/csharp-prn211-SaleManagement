using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly Assignment02Context _db;
        private IOrderRepository _orderRepository;
        public OrderDetailRepository()
        {
            _db = new();
            _orderRepository = new OrderRepository();
        }
        public void CreateOrderDetail(OrderDetail orderdetail)
        {
            if (orderdetail != null)
            {
                _db.OrderDetails.Add(orderdetail);
                _db.SaveChanges();
            }
        }

        public void DeleteOrderDetail(int orderId , int productID)
        {
            OrderDetail orderDetail = GetOrderDetail(orderId, productID);
            if (orderDetail != null)
            {
                _db.OrderDetails.Remove(orderDetail);
                _db.SaveChanges();
            }
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                _db.OrderDetails.Remove(orderDetail);
                _db.SaveChanges();
            }
        }

        public List<OrderDetail> getAllOrderDetail()
        {
            return _db.OrderDetails.ToList();
        }

        public OrderDetail GetOrderDetail(int orderId , int productID)
        {
            return _db.OrderDetails.FirstOrDefault(o => o.OrderId == orderId && o.ProductId == productID);
        }

        public void UpdateOrder(OrderDetail orderdetail)
        {
            OrderDetail orderD = GetOrderDetail(orderdetail.OrderId,orderdetail.ProductId);
            if(orderD != null)
            {
                orderD.OrderId = orderD.OrderId;
                orderD.ProductId = orderD.ProductId;
                orderD.UnitPrice = orderdetail.UnitPrice;
                orderD.Quantity = orderdetail.Quantity;
                orderD.Order = _orderRepository.GetOrder(orderdetail.OrderId);
                orderD.Product = orderdetail.Product;
            }
        }
    }
}
