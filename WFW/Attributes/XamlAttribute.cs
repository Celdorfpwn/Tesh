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

        protected abstract string Wpf { get; }

        public XmlAttribute XmlAttribute { get; protected set; }

        protected virtual List<string> ClearLineToGetValue
        {
            get
            {
                return new List<string>();
            }
        }

        public XamlAttribute(string line,XmlDocument xmlDocument)
        {
            Validate(GetValue(line), xmlDocument);
        }

        protected virtual string GetValue(string line)
        {
            return line.ReplaceAll(ClearLineToGetValue);
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
