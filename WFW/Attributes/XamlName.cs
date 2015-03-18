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
        protected override string Wpf
        {
            get
            {
                return "Name";
            }
        } 

        public XamlName(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            var value = line.Trim().Replace("this.Name = ", String.Empty)
                .Replace("\"", String.Empty)
                .Replace(";", String.Empty)
                .Trim();

            Validate(value, xmlDocument);
        }
    }
}
