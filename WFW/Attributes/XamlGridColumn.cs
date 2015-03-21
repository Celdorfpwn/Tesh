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
            if (line.Contains("Controls"))
            {
                var firstSplit = line.Split('.');
                if(firstSplit.Length == 5)
                {
                    var second = firstSplit[4].Split(',');

                    if(second.Length == 3)
                    {
                        var value = second[1].Trim();
                        Validate(value, xmlDocument);
                    }
                } 
            }
        }
    }
}
