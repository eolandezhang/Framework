using Eolande.AspNet.Domain;
using System.Collections.Generic;

namespace Eolande.AspNet.IBll
{
    public interface IUserManager
    {
        string Add(UserDomain userDomain);
        void Delete(string id);
        IList<UserDomain> GetList(string queryString);
        void Modify(UserDomain userDomain);
        string GetMessage();
    }
}
