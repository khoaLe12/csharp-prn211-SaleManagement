using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        List<Order> getAllOrder();
        Order GetOrder(int id);
        void UpdateOrder(Order order);
        void CreateOrder(Order order);
        void DeleteOrder(int id);
    }
}
