using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Reflection;
using Eolande.AspNet.IBll;

namespace Eolande.AspNet.Web
{
    public class UserHelper
    {
        IUserManager Manager;
        public UserHelper()
        { 
            Manager = new IBll.Proxy.UserManager();
        }
        public string GetMessage()
        {
            if (Manager != null)
                return Manager.GetMessage();
            return "";
        }
    }
}