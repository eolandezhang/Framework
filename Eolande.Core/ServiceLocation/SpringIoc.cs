using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;
namespace Eolande.Core.ServiceLocation
{
    public class SpringIoc
    {
        public static SpringIoc Deault { get; set; }
        IApplicationContext context;
        public SpringIoc()
        {
            context = ContextRegistry.GetContext();
            
        }
        static SpringIoc()
        {
            Deault = new SpringIoc();
        }
        public T GetObject<T>()
        {
            return context.GetObject<T>();
        }
    }
}
