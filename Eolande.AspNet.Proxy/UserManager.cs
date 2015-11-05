using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eolande.AspNet.Domain;
using System.Reflection;
using System.Net.Http;
using System.Configuration;

using Eolande.Client;

namespace Eolande.AspNet.IBll.Proxy
{
    public class UserManager : IUserManager
    {

        public string Add(SysUserDomain userDomain)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IList<SysUserDomain> GetList(string queryString)
        {
            return new WebApiService(Helper.BaseAddress).Post<List<SysUserDomain>>("user/GetList", "");
        }

        public void Modify(SysUserDomain userDomain)
        {
            throw new NotImplementedException();
        }

        public string GetMessage()
        {
            return new WebApiService(Helper.BaseAddress).Get<string>("user/Message");
            
        }

    }
}
