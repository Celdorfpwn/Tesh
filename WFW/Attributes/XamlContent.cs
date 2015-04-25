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

        protected override string  Wpf 
        {
            get
            {
                return "Content";
            }
        }

        protected override List<string> ClearLineToGetValue
        {
            get
            {
                return new List<string>
                {
                    "this.Text = ",
                    "\"",
                    ";"
                };
            }
        }

        public XamlContent(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }
    }
}
