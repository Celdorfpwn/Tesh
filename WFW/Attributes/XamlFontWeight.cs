using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlFontWeight : XamlFont
    {
        protected override string Wpf
        {
            get { return "FontWeight"; }
        }

        public XamlFontWeight(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }

        protected override string GetValue(string line)
        {
            var value = "this.";

            if (line.Contains("System.Drawing.FontStyle.Bold"))
            {
                value = "Bold";
            }

            return value;
        }
    }
}
