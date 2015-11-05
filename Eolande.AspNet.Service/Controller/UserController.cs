using Eolande.AspNet.IBll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Eolande.AspNet.Bll;
namespace Eolande.AspNet.Service.Controller
{
    public class UserController : ApiController
    {
        IUserManager Manager = new UserManager();


        public UserController()
        {
            
        }
        
        [HttpGet()]
        //[ActionName("Get")]
        public string Get()
        {
            return "Web Api";
        }
        [HttpGet]
        [ActionName("Message")]
        public string GetMessage()
        {
            return Manager.GetMessage();
        }
    }
}