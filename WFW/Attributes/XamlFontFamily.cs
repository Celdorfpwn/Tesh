using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlFontFamily : XamlFont
    {
        protected override string Wpf
        {
            get { return "FontFamily"; }
        }

        public XamlFontFamily(string line,XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }

        protected override string GetValue(string line)
        {
            var value = line.Split(',')[0].Trim().Replace("\"", String.Empty);
            return value;
        }
    }
}
