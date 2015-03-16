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
            var value = line.Trim().Replace("this.TabIndex = ", String.Empty)
                .Replace(";", String.Empty).Trim();

            if(Validate(value))
            {
                XmlAttribute = xmlDocument.CreateAttribute(WpfTabIndex);
                XmlAttribute.Value = value;
                Processed = true;
            }
            else
            {
                Processed = false;
            }
        }
    }
}
