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
        private const string WpfCavasLeft = "Canvas.Left";

        public XamlCanvasLeft(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            Wpf = WpfCavasLeft;

            var value = line.Trim()
                    .Replace("this.Location = new System.Drawing.Point(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');
            if(value.Length>0)

            Validate(value[0], xmlDocument);
        }
    }
}
