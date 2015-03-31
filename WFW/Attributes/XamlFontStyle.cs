using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlFontStyle : XamlFont
    {
        protected override string Wpf
        {
            get { return "FontStyle"; }
        }

        public XamlFontStyle(string line,XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }

        protected override string GetValue(string line)
        {
            //System.Drawing.FontStyle.Regular
            //var fontStyle = line.Split(',')[0].Trim().Replace("System.Drawing.FontStyle.", String.Empty);

            //if(fontStyle.Equals("Regular"))
            //{
            //    return "Normal";
            //}

            return "Normal";
        }
    }
}
