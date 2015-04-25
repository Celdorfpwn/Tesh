using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlHeader : XamlAttribute
    {
        protected override string Wpf
        {
            get { return "Header"; }
        }

        protected override List<string> ClearLineToGetValue
        {
            get
            {
                return new List<string>
                {
                    "this.HeaderText = ",
                    "\"",
                    ";"
                };
            }
        }

        public XamlHeader(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }
    }
}
