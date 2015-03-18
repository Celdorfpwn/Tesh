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

        public XamlCanvasTop(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            var value = line.Trim()
                    .Replace("this.Location = new System.Drawing.Point(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');

            if(value.Length>1 && value[0].Length<5)
               Validate(value[1].Trim(), xmlDocument);
        }
    }
}
