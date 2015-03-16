using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlContent : XamlAttribute
    {

        private const string WpfText = "Content";

        public XamlContent(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            var value = line.Trim().Replace("this.Text = ", String.Empty)
                .Replace("\"", String.Empty)
                .Replace(";", String.Empty)
                .Trim();

            if(Validate(value))
            {
                XmlAttribute = xmlDocument.CreateAttribute(WpfText);
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
