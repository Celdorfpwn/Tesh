using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlContainers
{
    public abstract class XamlContainer
    {
        public XamlContainer(IEnumerable<string> containerLines,string containerName,XmlDocument document)
        {

        }
    }
}
