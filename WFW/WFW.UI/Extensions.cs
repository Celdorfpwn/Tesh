using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFW.UI
{
    public static class Extensions
    {
        public static T To<T>(this object obj) where T : class
        {
            return obj as T;
        }
    }
}
