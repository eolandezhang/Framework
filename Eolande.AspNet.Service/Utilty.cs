using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web;

namespace Eolande.AspNet.Service
{
    public class Utility
    {
        public string Proxy { get; set; }
        public Utility(string proxy = "Eolande.AspNet.IBll.Proxy")
        {
            Proxy = proxy;
        }
        List<Type> types;
        public List<Type> Types
        {
            get
            {
                if (types == null)
                {
                    types = GetTypes();
                    return types;
                }
                return types;
            }
        }
        public List<Type> GetTypes()
        {
            List<Type> types = new List<Type>();
            string bll = ConfigurationManager.AppSettings[Proxy].ToString();
            var assembly = Assembly.Load(bll);

            foreach (var t in assembly.GetTypes())
            {
                types.Add(t);
            }
            return types;
        }

       
    }
}