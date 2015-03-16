using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfParser
{
    public static class StringExtensions
    {
        public static bool ContainsOneFromList(this string value,IEnumerable<string> list)
        {
            foreach(var item in list)
            {
                if (value.Contains(item))
                    return true;
            }
            return false;
        }
    }
}
