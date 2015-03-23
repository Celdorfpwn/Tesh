using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlContainers
{
    public class XamlTabControl : XamlContainer
    {
        public override string ContainerType
        {
            get { return "System.Windows.Forms.TabControl"; }
        }

        public override string XamlType
        {
            get { return "TabControl"; }
        }

        public override bool RequireCanvas
        {
            get { return false; }
        }

        public XamlTabControl(IEnumerable<string> lines, XmlDocument document, IEnumerable<FieldDeclarationSyntax> designerFields, string containerType, string containerName)
            : base(lines, document, designerFields,containerType,containerName)
        {
        }

        protected override void AppendSpecials(IEnumerable<string> lines, string containerName, System.Xml.XmlDocument document)
        {
            
        }
    }
}
