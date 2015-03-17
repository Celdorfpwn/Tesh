using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attributes;
using System.Xml;

namespace AttributesFactory
{
    public static class AttributesFactory 
    {
        public static IEnumerable<XmlAttribute> GetAttributes(IEnumerable<string> lines,XmlDocument document)
        {
            var attributesAssemblyTypes = AttributesTypes.AssemblyTypes.ToList();

            var attributes = new List<XamlAttribute>();

            foreach(var line in lines)
            {
                foreach (var type in attributesAssemblyTypes)
                {
                    var attribute = (XamlAttribute)Activator.CreateInstance(type, line, document);
                    attributes.Add(attribute);
                }
            }

            var ret = attributes.Where(attribute => attribute.Processed)
                .Select(attribute => attribute.XmlAttribute).ToList();

            return ret;
        }

    }
}
