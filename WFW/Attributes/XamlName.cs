using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlName : XamlAttribute
    {
        private const string WpfName = "Name";

        public XamlName(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            Wpf = WpfName;
            var value = line.Trim().Replace("this.Name = ", String.Empty)
                .Replace("\"", String.Empty)
                .Replace(";", String.Empty)
                .Trim();

            Validate(value, xmlDocument);
        }
    }
}
