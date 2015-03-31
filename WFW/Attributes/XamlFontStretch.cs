using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlFontStretch : XamlFont
    {
        protected override string Wpf
        {
            get { return "FontStretch"; }
        }

        public XamlFontStretch(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }

        protected override string GetValue(string line)
        {
            var value = "this.";

            return value;
        }
    }
}
