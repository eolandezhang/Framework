using Eolande.AspNet.IBll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Eolande.AspNet.Service.Controller
{
    public class UserController : ApiController
    {
        IUserManager Manager;


        public UserController()
        {
            Manager = GetInstance(new Utility().Types);
        }
        public IUserManager GetInstance(List<Type> types)
        {
            IUserManager Manager = null;
            foreach (var t in types)
            {
                if (typeof(IUserManager).IsAssignableFrom(t))
                {
                    var x = t.Assembly.CreateInstance(t.FullName);
                    Manager = t.Assembly.CreateInstance(t.FullName) as IBll.IUserManager;
                }
            }
            return Manager;
        }

        [HttpGet()]
        //[ActionName("Get")]
        public string Get()
        {
            return "Web Api";
        }
        [HttpGet]
        //[ActionName("GetMessage")]
        public string GetMessage()
        {
            return Manager.GetMessage();
        }
    }
}