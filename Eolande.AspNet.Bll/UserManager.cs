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
            return GetList();
        }

        public string GetMessage()
        {
            return "GetMessage";
        }

        public void Modify(SysUserDomain userDomain)
        {
            throw new NotImplementedException();
        }

        List<SysUserDomain> GetList()
        {
            List<SysUserDomain> list = new List<SysUserDomain>();
            list.Add(new SysUserDomain() { Id = "1", Name = "Eolande" });
            list.Add(new SysUserDomain() { Id = "2", Name = "Lucy" });
            return list;
        }
    }
}
