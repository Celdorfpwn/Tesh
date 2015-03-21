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

        private void AppendColumnsAndRowsDefinitions(IEnumerable<string> lines,string containerName,XmlDocument document)
        {
            AppendColumns(lines,containerName,document);
            AppendRows(lines, containerName, document);
        }

        private void AppendRows(IEnumerable<string> lines, string containerName, XmlDocument document)
        {
            var rowLines = lines.Where(line => line.Contains(containerName))
                .Where(line => line.Contains("RowStyles"));

            XmlNode node = document.CreateElement("Grid.RowDefinitions", document.DocumentElement.NamespaceURI);

            foreach(var rowLine in rowLines)
            {
                XmlNode row = document.CreateElement("RowDefinition", document.DocumentElement.NamespaceURI);
                var height = document.CreateAttribute("Height");

                height.Value = GetRowHeight(rowLine, containerName);

                row.Attributes.Append(height);
                node.AppendChild(row);
            }

            XmlNode.AppendChild(node);

        }

        private void AppendColumns(IEnumerable<string> lines,string containerName,XmlDocument document)
        {
            var columnsLines = lines.Where(line => line.Contains(containerName))
                .Where(line => line.Contains("ColumnStyles"));

            XmlNode node = document.CreateElement("Grid.ColumnDefinitions", document.DocumentElement.NamespaceURI);

            foreach(var columnLine in columnsLines)
            {
                XmlNode column = document.CreateElement("ColumnDefinition",document.DocumentElement.NamespaceURI);

                var width = document.CreateAttribute("Width");
                width.Value = GetColumnWidth(columnLine,containerName);
                column.Attributes.Append(width);

                node.AppendChild(column);
            }

            XmlNode.AppendChild(node);
        }

        private string GetColumnWidth(string line,string containerName)
        {
            var value = line.Trim()
                .Replace(containerName + ".", String.Empty)
                .Replace("this.ColumnStyles.Add(", string.Empty)
                .Replace(");", string.Empty);

            if (value.Equals("new System.Windows.Forms.ColumnStyle()"))
                return "Auto";

            return "*";
        }

        private string GetRowHeight(string line,string containerName)
        {
            var value = line.Trim()
                .Replace(containerName + ".", string.Empty)
                .Replace("this.RowStyles.Add(", String.Empty)
                .Replace(");", string.Empty);

            if (value.Equals("new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F)"))
                return "*";

            return "Auto";
        }


        protected override void AppendSpecials(IEnumerable<string> lines, string containerName, XmlDocument document)
        {
            AppendColumnsAndRowsDefinitions(lines, containerName, document);
        }
    }
}
