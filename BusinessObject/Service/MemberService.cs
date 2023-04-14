using AutoMapper;
using DataAccess.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public class MemberService : IMemberService
    {
        IMemberRepository _memberRepository = new MemberRepository();
        IMapper _mapper;
        IOrderService _orderService = new OrderService();
        IOrderRepository _orderRepository = new OrderRepository();
        IOrderDetailRepository detailRepository = new OrderDetailRepository();
        public MemberService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Member, MemberObject>();
                cfg.CreateMap<MemberObject, Member>();
            });
            this._mapper = config.CreateMapper();
        }
        public MemberService(IMemberRepository memberRepository)
        {
            this._memberRepository = memberRepository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Member, MemberObject>();
                cfg.CreateMap<MemberObject, Member>();
            });
            this._mapper = config.CreateMapper();
        }
            public void Create(MemberObject member)
        {
            if (member is not null)
            {
                _memberRepository.CreateMember(_mapper.Map<MemberObject, Member>(member));
            }
        }

        public void Delete(int id)
        {
            _orderRepository.getAllOrder().Where(o => o.MemberId == id).ToList().ForEach(o => {
                detailRepository.getAllOrderDetail().Where(d => d.OrderId == o.OrderId).ToList().ForEach(d => { 
                detailRepository.DeleteOrderDetail(d);
                });
                _orderRepository.DeleteOrder(o.OrderId);
            });
               
            _memberRepository.DeleteMember(id);
        }

        public IEnumerable<MemberObject> FindAll(string? term = null)
        {

            if (term is null || term.Trim().Length <= 0) return _memberRepository.getAllMembers().Select(e => _mapper.Map<Member, MemberObject>(e));
            else return _memberRepository.getAllMembers().Where(prod => prod.Email.Contains(term)).Select(e => _mapper.Map<Member, MemberObject>(e));
        }

        public MemberObject GetById(int id)
        {
            var member = _memberRepository.GetMember(id);
            return _mapper.Map<Member,MemberObject>(member);
        }

        public void Update(MemberObject member)
        {
            if (member is not null)
            {
                _memberRepository.UpdateMember(_mapper.Map<MemberObject, Member>(member));
            }
        }
    }
}
