using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlContainers
{
    public class XamlTabItem : XamlContainer
    {
        public override string ContainerType
        {
            get { return "System.Windows.Forms.TabPage"; }
        }

        public override string XamlType
        {
            get { return "TabItem"; }
        }

        public override bool RequireCanvas
        {
            get { return true; }
        }

        public XamlTabItem(IEnumerable<string> lines, XmlDocument document, IEnumerable<FieldDeclarationSyntax> designerFields, string containerType, string containerName)
            : base(lines, document, designerFields,containerType,containerName)
        {
            if(Processed)
            {
                var header = XmlNode.Attributes.GetNamedItem("Content").Value;
                XmlNode.Attributes.RemoveNamedItem("Content");

                var headerAttribute = document.CreateAttribute("Header");
                headerAttribute.Value = header;
                XmlNode.Attributes.Append(headerAttribute);

                XmlNode.Attributes.RemoveNamedItem("Height");
                XmlNode.Attributes.RemoveNamedItem("Width");
                XmlNode.Attributes.RemoveNamedItem("Canvas.Top");
                XmlNode.Attributes.RemoveNamedItem("Canvas.Left");
            }
        }

        protected override void AppendSpecials(IEnumerable<string> lines, string containerName, System.Xml.XmlDocument document)
        {

        }
    }
}
