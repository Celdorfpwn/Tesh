using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlCanvasTop : XamlAttribute
    {
        protected override string Wpf
        {
            get
            {
                return "Canvas.Top";
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

        public XamlCanvasTop(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }

        protected override string GetValue(string line)
        {
            var values = base.GetValue(line).Split(',');

            return values.Length > 1 && values[0].Length < 5 
                ? values[1].Trim() 
                : line;
        }
    }
}
