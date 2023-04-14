using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        List<Member> getAllMembers();
        Member GetMember(int id);
        void UpdateMember(Member member);
        void CreateMember(Member member);
        void DeleteMember(int id); 
    }
}
