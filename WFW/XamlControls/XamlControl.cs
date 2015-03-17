using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public abstract class XamlControl
    {

        public bool Processed { get;private set; }

        public XmlNode XmlNode { get;set; }

        public XamlControl(IEnumerable<string> lines,XmlDocument document)
        {

        }
    }
}
