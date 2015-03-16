using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public abstract class XamlAttribute
    {
        public bool Processed { get; protected set; }

        protected string Wpf { get; set; }

        public XmlAttribute XmlAttribute { get; protected set; }

        public XamlAttribute(string line,XmlDocument xmlDocument)
        {
        }

        protected void Validate(string value,XmlDocument xmlDocument)
        {
            if(!value.Contains("this."))
            {
                 XmlAttribute = xmlDocument.CreateAttribute(Wpf);
                 XmlAttribute.Value = value;
                Processed = true;
            }
            else
            {
                    Processed = false;
            }
        }
    }
}
