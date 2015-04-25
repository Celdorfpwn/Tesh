using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlWidth : XamlAttribute
    {
        protected override string Wpf
        {
            get
            {
                return "Width";
            }
        }

        protected override List<string> ClearLineToGetValue
        {
            get
            {
                return new List<string>
                {
                    "this.Size = new System.Drawing.Size(",
                    ");"
                };
            }
        }

        protected override string GetValue(string line)
        {
            var values = base.GetValue(line).Split(',');
            return values.Length > 0
                ? values[0].Trim()
                : line;
        }

        public XamlWidth(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }
    }
}
