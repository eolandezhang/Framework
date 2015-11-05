using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eolande.Core
{
    public static class Expension
    {
        public static string ToSafeString(this object obj)
        {
            if (object.Equals(obj, null))
            {
                return string.Empty;
            }
            return obj.ToString();
        }
    }
}
