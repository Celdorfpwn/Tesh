using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlTabIndex : XamlAttribute
    {
        private const string WpfTabIndex = "TabIndex";

        public XamlTabIndex(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            Wpf = WpfTabIndex;
            var value = line.Trim().Replace("this.TabIndex = ", String.Empty)
                .Replace(";", String.Empty).Trim();

            Validate(value, xmlDocument);
        }
    }
}
