using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XamlControls
{
    public static class ControlsTypes
    {
        public static IEnumerable<Type> AssemblyTypes
        {
            get
            {
                var list = Assembly.GetExecutingAssembly()
                    .GetTypes().ToList();

                return Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(type => !type.IsAbstract && !type.Name.Contains("<") && !type.Name.Contains("_"));
            }
        }
    }
}
