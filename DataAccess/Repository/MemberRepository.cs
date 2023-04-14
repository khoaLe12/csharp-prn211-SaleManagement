using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly Assignment02Context _db;
        public MemberRepository()
        {
            _db = new();
        }

        public void CreateMember(Member member)
        {
            if(member != null)
            {
                _db.Members.Add(member);
                _db.SaveChanges();
            }
        }

        public void DeleteMember(int id)
        {
            Member member = GetMember(id);
            if(member != null)
            {
                _db.Members.Remove(member);
                _db.SaveChanges();
            }
        }

        public List<Member> getAllMembers()
        {
            return _db.Members.ToList();
        }

        public Member GetMember(int id)
        {
            List<Member> members = getAllMembers();
            if (members != null)
            {
                Member member = members.FirstOrDefault(m => m.MemberId == id);
                return member;
            }
            return null;    
        }
        public void UpdateMember(Member member)
        {
            Member mem = GetMember(member.MemberId);
            if(mem != null)
            {
                mem.Email = member.Email;
                mem.City = member.City;
                mem.Country = member.Country;
                mem.CompanyName = member.CompanyName;
                mem.Password = member.Password;
                mem.MemberId = mem.MemberId;
               _db.Members.Update(mem);
               _db.SaveChanges();
            }
        }

    }
}
