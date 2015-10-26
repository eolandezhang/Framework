using Eolande.AspNet.IBll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eolande.AspNet.Domain;

namespace Eolande.AspNet.Bll
{
    public class UserManager : IUserManager
    {
        public string Add(UserDomain userDomain)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IList<UserDomain> GetList(string queryString)
        {
            throw new NotImplementedException();
        }

        public string GetMessage()
        {
            return "GetMessage";
        }

        public void Modify(UserDomain userDomain)
        {
            throw new NotImplementedException();
        }
    }
}
