using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public interface IMemberService
    {
        IEnumerable<MemberObject> FindAll(string? term = null);
        void Create(MemberObject member);
        void Update(MemberObject member);
        void Delete(int id);
        MemberObject GetById(int id);
    }
}
