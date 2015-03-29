using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlContainers
{
    public class XamlDataGrid : XamlContainer
    {
        public override bool RequireCanvas
        {
            get { return false; }
        }

        public override string ContainerType
        {
            get { return "System.Windows.Forms.DataGridView"; }
        }

        public override string XamlType
        {
            get { return "DataGrid"; }
        }

        public XamlDataGrid(IEnumerable<string> lines, XmlDocument document, IEnumerable<FieldDeclarationSyntax> designerFields, string containerType, string containerName)
            : base(lines, document, designerFields,containerType,containerName)
        {
            if (Processed)
            {
                var columnsControls = GetColumnsControls(lines, containerName);
                if (columnsControls.Count() > 0)
                {
                    var columnsNode = document.CreateElement("DataGrid.Columns", document.DocumentElement.NamespaceURI);
                    
                    var controlsFields = designerFields.Where(field => columnsControls.Contains(field.Declaration.Variables.First().ToFullString()));

                    XamlControlsFactory.XamlControlsFactory
                                       .GetControls(lines, document, controlsFields)
                                       .ToList()
                                       .ForEach(control => columnsNode.AppendChild(control));

                    XmlNode.AppendChild(columnsNode);
                }

            }
        }

        protected IEnumerable<string> GetColumnsControls(IEnumerable<string> lines,string containerName)
        {
            List<string> controls = new List<string>();

            var listLines = lines.ToList();

            var columnsAddLine = "this."+containerName+".Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {";

            var containsLine = listLines.FirstOrDefault(line => line.Contains(columnsAddLine));

            if (containsLine != null)
            {

                var nodesStartIndex = listLines.IndexOf(containsLine);
                for (int index = nodesStartIndex + 1; index < listLines.Count; index++)
                {
                    controls.Add(listLines[index].Trim().Replace("this.",String.Empty).Replace(",", string.Empty).Replace("});", string.Empty));

                    if (listLines[index].EndsWith("});"))
                    {
                        break;
                    }
                }
            }
            return controls;
        }

        protected override void AppendSpecials(IEnumerable<string> lines, string containerName, XmlDocument document)
        {
        }
    }
}
