using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eolande.AspNet.Domain;
using System.Reflection;
using System.Net.Http;
using System.Configuration;
using Eolande.Core.WebApi;

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
            return new RestClient().Post<List<SysUserDomain>>("user/GetList","");
        }

        public void Modify(SysUserDomain userDomain)
        {
            throw new NotImplementedException();
        }

        public string GetMessage()
        {
            //string baseAddress = ConfigurationManager.AppSettings["BaseAddress"].ToString();
            //var msg = new RestClient().Read(HttpMethod.Get, "user/GetMessage");
            var msg = new RestClient().Get<string>("user/GetMessage");
            return msg;

        }
    }
}
