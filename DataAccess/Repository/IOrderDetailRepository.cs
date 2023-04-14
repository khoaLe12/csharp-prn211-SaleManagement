using DataAccess.Entity;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> getAllOrderDetail();
        OrderDetail GetOrderDetail(int orderId , int productID);
        void UpdateOrder(OrderDetail orderdetail);
        void CreateOrderDetail(OrderDetail orderdetail);
        void DeleteOrderDetail(int orderId , int productID);
        void DeleteOrderDetail(OrderDetail orderDetail);
    }
}
