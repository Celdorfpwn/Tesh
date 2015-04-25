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

        protected override List<string> ClearLineToGetValue
        {
            get
            {
                return new List<string>
                {
                    "this.Name = ",
                    "\"",
                    ";"
                };
            }
        }

        public XamlName(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }
    }
}
