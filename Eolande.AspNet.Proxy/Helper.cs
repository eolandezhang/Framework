using Eolande.Core.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eolande.AspNet.IBll.Proxy
{
    public class Helper
    {
        public static string BaseAddress { get; set; }

        static Helper()
        {
            var x = SpringIoc.Deault.GetObject<Eolande.Client.WebApiService>();
            if (x != null)
            {
                BaseAddress = x.BaseAddress;
            }
        }
    }
}
