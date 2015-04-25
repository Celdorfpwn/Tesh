using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlHeight : XamlAttribute
    {
        protected override string Wpf
        {
            get
            {
                return "Height";
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
            return values.Length > 1 && values[0].Length < 5
                ? values[1].Trim()
                : line;
        }

        public XamlHeight(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }
    }
}
