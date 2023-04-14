using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {

        private readonly Assignment02Context _db;
        private IMemberRepository _memberRepository;
        public OrderRepository()
        {
            _db = new();
            _memberRepository = new MemberRepository();
        }
        public void CreateOrder(Order order)
        {
            if (order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
        }

        public void DeleteOrder(int id)
        {

            Order order = GetOrder(id);
            if (order != null)
            {
                _db.Orders.Remove(order);
                _db.SaveChanges();
            }
        }

        public List<Order> getAllOrder()
        {
            return _db.Orders.ToList();
        }

        public Order GetOrder(int id)
        {
            List<Order> orders = getAllOrder();
            if (orders != null)
            {
                Order order = orders.FirstOrDefault(o => o.OrderId == id);
                return order;
            }
            return null;
        }

        public void UpdateOrder(Order order)
        {
            Order ord = GetOrder(order.OrderId);
            if(ord != null)
            {
                ord.OrderDate = order.OrderDate;
                ord.MemberId = order.MemberId;
                ord.RequiredDate = order.RequiredDate;
                ord.Member = _memberRepository.GetMember(order.MemberId);
                ord.ShippedDate = order.ShippedDate;
                ord.OrderId = ord.OrderId;
                _db.Orders.Update(ord);
                _db.SaveChanges();
            }

        }
    }
}
