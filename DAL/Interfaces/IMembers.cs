using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJS__Member_Registration.DAL.Interfaces
{
    public interface IMembers
    {
        bool Create(Member model);
        Member Read(int id);
        IQueryable<Member> ReadAll();
        bool Update(Member model);
    }
}
