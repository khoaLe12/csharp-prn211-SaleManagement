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

    public class OrderService : IOrderService
    {
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository detailRepository = new OrderDetailRepository();
        IMapper _mapper;
        public OrderService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderObject>();
                cfg.CreateMap<OrderObject, Order>();
                cfg.CreateMap<OrderDetail, OrderDetailObject>();
                cfg.CreateMap<OrderDetailObject, OrderDetail>();


            });
            this._mapper = config.CreateMapper();
        }
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderObject>();
                cfg.CreateMap<OrderObject, Order>();
                
            });
            this._mapper = config.CreateMapper();

        }
        public void Create(OrderObject order)
        {

            if (order is not null)
            {
                orderRepository.CreateOrder(_mapper.Map<OrderObject, Order>(order));
            }
        }

        public void Delete(int id)
        {
            this.GetById(id).OrderDetails?.ToList().ForEach(e =>
            {
                detailRepository.DeleteOrderDetail(_mapper.Map<OrderDetailObject,OrderDetail>(e));
            });
            orderRepository.DeleteOrder(id);
        }

        public IEnumerable<OrderObject> FindAll()
        {
            var orders = orderRepository.getAllOrder().Select(e => _mapper.Map<Order, OrderObject>(e));
            var fullOrders = orders.Select(order =>
            {
                var orderDetails = detailRepository.getAllOrderDetail().Where(detail => detail.OrderId == order.OrderId);
                order.OrderDetails = orderDetails.Select(e => _mapper.Map<OrderDetail, OrderDetailObject>(e));
                return order;
            });
            return fullOrders;
        }

        public OrderObject GetById(int id)
        {
            var order = _mapper.Map<Order, OrderObject>(orderRepository.GetOrder(id));
            var orderDetails = detailRepository.getAllOrderDetail().Where(detail => detail.OrderId == order.OrderId).Select(detail => _mapper.Map<OrderDetail,OrderDetailObject>(detail));
            order.OrderDetails = orderDetails;
            return order;
        }

        public void Update(OrderObject order)
        {
            if (order is not null)
            {
                var orderEntity = (_mapper.Map<OrderObject, Order>(order));
                orderRepository.UpdateOrder(orderEntity);
            }
        }
    }
}
