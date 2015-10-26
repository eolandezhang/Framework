using Eolande.AspNet.Domain;
using System.Collections.Generic;

namespace Eolande.AspNet.IBll
{
    public interface IUserManager
    {
        string Add(SysUserDomain userDomain);
        void Delete(string id);
        IList<SysUserDomain> GetList(string queryString);
        void Modify(SysUserDomain userDomain);
        string GetMessage();
    }
}
