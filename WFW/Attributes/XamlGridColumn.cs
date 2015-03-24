using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlGridColumn : XamlAttribute
    {
        protected override string Wpf
        {
            get { return "Grid.Column"; }
        }

        public XamlGridColumn(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            if (line.Contains("Controls") && line.Contains("Add") && line.Split('.').Length == 5 && line.Split(',').Length == 3) 
            {
                var value = line.Split('.')[4].Split(',')[1].Trim();

                Validate(value, xmlDocument);
            }
        }
    }
}
