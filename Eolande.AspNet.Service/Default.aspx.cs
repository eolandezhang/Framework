using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eolande.AspNet.Service
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = new List<Type>();
            var assembly = Assembly.GetAssembly(typeof(Default));
            foreach (var t in assembly.GetTypes())
            {
                if (typeof(ApiController).IsAssignableFrom(t))
                {
                    list.Add(t);
                }
            }
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendFormat("类：{0}\n", item.Name);

                foreach (var method in item.GetMethods())
                {

                    if (!(Attribute.IsDefined(method, typeof(HttpGetAttribute))
                        || Attribute.IsDefined(method, typeof(HttpPostAttribute))
                        || Attribute.IsDefined(method, typeof(HttpPutAttribute))
                        || Attribute.IsDefined(method, typeof(HttpDeleteAttribute)))

                        )
                        continue;
                    if (!method.IsPublic) continue;
                    sb.AppendFormat("    方法：{0}\n", method.Name);

                    foreach (var param in method.GetParameters())
                    {
                        sb.AppendFormat("        参数：{0}:{1}\n", param.Name, param.GetType().ToString());

                    }
                }

            }
            Response.Write(sb.ToString());
        }
    }
}