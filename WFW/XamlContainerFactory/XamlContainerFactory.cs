using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using XamlContainers;

namespace XamlContainerFactory
{
    public static class XamlContainerFactory
    {
        public static IEnumerable<XmlNode> GetControls(IEnumerable<string> lines, XmlDocument document
            , IEnumerable<FieldDeclarationSyntax> controlsSyntax)
        {
            var controlAssemblyTypes = ContainerTypes.AssemblyTypes.ToList();

            var controls = new List<XamlContainer>();

            foreach (var controlSyntax in controlsSyntax)
            {
                foreach (var type in controlAssemblyTypes)
                {
                    var control = (XamlContainer)Activator.CreateInstance(type, lines, document,
                        controlsSyntax,
                        controlSyntax.Declaration.Type.ToFullString(),
                        controlSyntax.Declaration.Variables.First().ToFullString());

                    controls.Add(control);
                }
            }

            return controls.Where(attribute => attribute.Processed)
                .Select(attribute => attribute.XmlNode);

        }
    }
}
