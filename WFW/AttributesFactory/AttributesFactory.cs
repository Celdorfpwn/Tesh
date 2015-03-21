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

            lines.ToList()
                .ForEach(line =>
                attributesAssemblyTypes
                .ForEach(type =>
                    attributes.Add((XamlAttribute)Activator.CreateInstance(type, line, document))
                ));

            return attributes.Where(attribute => attribute.Processed)
                .Select(attribute => attribute.XmlAttribute);
        }
    }
}
