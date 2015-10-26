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

        public void Modify(UserDomain userDomain)
        {
            throw new NotImplementedException();
        }

        public string GetMessage()
        {
            string baseAddress = ConfigurationManager.AppSettings["BaseAddress"].ToString();
            var msg = new RestClient().Read(baseAddress, HttpMethod.Get, "user/GetMessage");
            return msg;

        }
    }
}
