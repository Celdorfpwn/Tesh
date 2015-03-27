using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public static class AttributesTypes
    {
        public static IEnumerable<Type> AssemblyTypes
        {
            get
            {
                return Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(type => !type.IsAbstract && !type.Name.Contains("<") && !type.Name.Contains("_"));
            }
        }
    }
}
