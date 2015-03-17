using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Xml;
using XamlControls;

namespace XamlControlsFactory
{
    public class XamlControlsFactory
    {
        public static IEnumerable<XmlNode> GetControls(IEnumerable<string> lines, XmlDocument document
            , IEnumerable<FieldDeclarationSyntax> controlsSyntax)
        {
            var controlAssemblyTypes = ControlTypes.AssemblyTypes.ToList();

            var controls = new List<XamlControl>();

            foreach(var controlSyntax in controlsSyntax)
            {
                foreach(var type in controlAssemblyTypes)
                {
                    var control = (XamlControl)Activator.CreateInstance(type,lines,document,
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
