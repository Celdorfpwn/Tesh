using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace XamlContainers
{
    public abstract class XamlContainer
    {
        public bool Processed { get; private set; }

        public XmlNode XmlNode { get; private set; }

        public abstract string ContainerType { get; }

        public abstract string XamlType { get; }

        public XamlContainer(IEnumerable<string> lines, XmlDocument document, IEnumerable<FieldDeclarationSyntax> designerFields,string containerType, string containerName)
        {
            if (Validate(containerType))
            {
                XmlNode = document.CreateElement(XamlType, document.DocumentElement.NamespaceURI);
                var canvasNode = document.CreateElement("Canvas", document.DocumentElement.NamespaceURI);

                XmlNode.AppendChild(canvasNode);
                Processed = true;

                AppendAttributes(lines, containerName,document);

                var containerControls = GetContainerControls(lines, containerName);

                var controlsFields = designerFields.Where(field => containerControls.Contains(field.Declaration.Variables.First().ToFullString()));

                XamlControlsFactory.XamlControlsFactory
                    .GetControls(lines, document, controlsFields)
                    .ToList()
                    .ForEach(control => canvasNode.AppendChild(control));

            }
            
        }

        private void AppendAttributes(IEnumerable<string> lines, string containerName,XmlDocument document)
        {
            var attributeLines = ClearLines(containerName, lines);

            AttributesFactory.AttributesFactory
                .GetAttributes(attributeLines, document)
                .ToList()
                .ForEach(attribute => XmlNode.Attributes.Append(attribute));

            XmlNode.Attributes.RemoveNamedItem("TabIndex");
        }

        private IEnumerable<string> ClearLines(string containerName, IEnumerable<string> controlLines)
        {
            var lines = new List<string>();
            var remove = containerName + ".";
            var controlIdentifier = "this." + containerName;
            controlLines.Where(line => line.Contains(controlIdentifier) && line.Contains("=")).ToList()
                .ForEach(line => lines.Add(line.Replace(remove, string.Empty)));

            return lines;
        }

        private bool Validate(string containerType)
        {
            return containerType.Trim().Equals(ContainerType);
        }

        private IEnumerable<string> GetContainerControls(IEnumerable<string> lines,string containerName)
        {
            var searchIndicator = new StringBuilder()
                .Append("this.")
                .Append(containerName)
                .Append(".Controls.Add(this.").ToString().Trim();

           
            var controlNames = new List<string>();
            lines.Where(line => line.Contains(searchIndicator))
                .ToList()
                .ForEach(line => 
                controlNames.Add(line.Trim().Replace(searchIndicator,String.Empty).Split(',')[0]));


            return controlNames;
        }

        private void SetControls(IEnumerable<string> lines, XmlDocument document, IEnumerable<FieldDeclarationSyntax> controlsSyntax)
        {
            XamlControlsFactory.XamlControlsFactory
                .GetControls(lines, document, controlsSyntax)
                .ToList()
                .ForEach(control => XmlNode.AppendChild(control));
        }
    }
}
