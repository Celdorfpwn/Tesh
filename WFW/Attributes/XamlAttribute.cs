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


        public XmlAttribute XmlAttribute { get; protected set; }

        public XamlAttribute(string line,XmlDocument xmlDocument)
        {
        }

        public bool Validate(string value)
        {
            return !value.Contains("this.");
        }
    }
}
