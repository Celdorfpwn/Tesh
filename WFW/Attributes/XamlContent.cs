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
            Wpf = WpfText;

            var value = line.Trim().Replace("this.Text = ", String.Empty)
                .Replace("\"", String.Empty)
                .Replace(";", String.Empty)
                .Trim();

            Validate(value, xmlDocument);
        }
    }
}
