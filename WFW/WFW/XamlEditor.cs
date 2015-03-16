using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WFW
{
    public static class XamlEditor
    {
        public static XmlDocument NewXaml
        {
            get
            {
                return new XmlDocument();
            }
        }
    }
}
