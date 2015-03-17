using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfParser
{
    public class ControlsFactory
    {
        private XmlDocument Document { get; set; }

        public ControlsFactory(XmlDocument document)
        {
            Document = document;
        }

        public List<XmlNode> GetControls(IEnumerable<string> lines, IEnumerable<FieldDeclarationSyntax> controls)
        {
            List<XmlNode> nodes = new List<XmlNode>();

            foreach (var control in controls)
            {
                var controlName = control.Declaration.Variables.First().ToFullString();
                var controlIdentifier = "this." + controlName;
                var controlLines = lines.Where(line => line.Contains(controlIdentifier));


                var controlNode = CreateControlNode(controlName, controlLines, control.Declaration.Type.ToFullString());
                if (controlNode != null)
                {
                    nodes.Add(controlNode);
                }
            }
            return nodes;
        }

        private XmlNode CreateControlNode(string controlName, IEnumerable<string> controlLines,string controlType)
        {

            switch(controlType)
            {
                case ButtonType:
                    return CreateButtonNode(controlName, controlLines);
                    
            }
            return null;
        }

        private XmlNode CreateButtonNode(string controlName, IEnumerable<string> controlLines)
        {
            
            XmlNode button = Document.CreateElement(Button, Document.DocumentElement.NamespaceURI);
            ButtonAttributesFactory attributesFactory = new ButtonAttributesFactory(Document);
            attributesFactory
                .GetAttributes(controlName, controlLines)
                .ToList()
                .ForEach(attribute => button.Attributes.Append(attribute));


            return button;

        }



        private const string ButtonType = "System.Windows.Forms.Button ";
        private const string Button = "Button";
        private const string Canvas = "Canvas";

       
    }
}
