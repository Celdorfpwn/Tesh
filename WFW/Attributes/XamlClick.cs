using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlClick : XamlAttribute
    {
        protected override string Wpf
        {
            get
            {
                return "Click";
            }
        }

        public XamlClick(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            var value = line.Trim().Replace("this.Click += new System.EventHandler(this.", String.Empty)
                .Replace("\"", String.Empty)
                .Replace(");", String.Empty)
                .Trim();

            Validate(value, xmlDocument);
        }
 
        
    }
}
