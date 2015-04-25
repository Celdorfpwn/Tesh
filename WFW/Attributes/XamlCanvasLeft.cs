using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlCanvasLeft : XamlAttribute
    {
        protected override string  Wpf 
        {
            get
            {
                return "Canvas.Left";
            }
        }

        protected override List<string> ClearLineToGetValue
        {
            get
            {
                return new List<string>
                {
                    "this.Location = new System.Drawing.Point(",
                    ");"
                };
            }
        }

        protected override string GetValue(string line)
        {
            var values = base.GetValue(line).Split(',');

            return values.Length > 0 ? values[0] : line;
        }

        public XamlCanvasLeft(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }
    }
}
