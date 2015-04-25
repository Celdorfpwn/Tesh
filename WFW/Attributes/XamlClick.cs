using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlClick : XamlAttribute
    {
        protected override string Wpf
        {
            get
            {
                return "Click";
            }
        }

        protected override List<string> ClearLineToGetValue
        {
            get
            {
                return new List<string>
                {
                    "this.Click += new System.EventHandler(this.",
                    "\"",
                    ");"
                };
            }
        }

        public XamlClick(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
        }
 
        
    }
}
