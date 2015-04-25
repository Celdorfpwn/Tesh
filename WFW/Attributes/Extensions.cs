using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal static class Extensions
    {
        internal static string ReplaceAll(this string line,List<string> list)
        {
            return line.Trim().ReplaceRecursive(list, 0).Trim();
        }

        private static string ReplaceRecursive(this string line,List<string> list,int index)
        {
            return index < list.Count
                ? line.ReplaceRecursive(list, index + 1)
                .Replace(list.ElementAt(index),string.Empty)
                : line;
        }
    }
}
