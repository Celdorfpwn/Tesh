using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlGridRow : XamlAttribute
    {
        protected override string Wpf
        {
            get { return "Grid.Row"; }
        }

        public XamlGridRow(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            if (line.Contains("Controls") && line.Contains("Add"))
            {
                var value = line.Split('.')[4].Split(',')[2].Replace(");", string.Empty).Trim();
                Validate(value, xmlDocument);
            }
        }
    }
}
