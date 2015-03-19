using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace XamlContainers
{
    public class XamlGrid : XamlContainer
    {
        public override string ContainerType
        {
            get
            {
                return "System.Windows.Forms.TableLayoutPanel";
            }


        }

        public override string XamlType
        {
            get
            {
                return "Grid";
            }

        }

        public XamlGrid(IEnumerable<string> lines, XmlDocument document, IEnumerable<FieldDeclarationSyntax> designerFields, string containerType, string containerName)
            : base(lines, document, designerFields,containerType,containerName)
        {

        }
    }
}
