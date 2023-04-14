using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public interface IOrderService
    {
        IEnumerable<OrderObject> FindAll();
        void Create(OrderObject order);
        void Update(OrderObject order);
        void Delete(int id);
        OrderObject GetById(int id);
    }
}
