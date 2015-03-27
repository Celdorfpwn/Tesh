using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public class XamlTreeView : XamlControl
    {
        protected override string ControlType
        {
            get { return "System.Windows.Forms.TreeView"; }
        }

        protected override string XamlType
        {
            get { return "TreeView"; }
        }

        public XamlTreeView(IEnumerable<string> lines,XmlDocument document,string controlType,string controlName)
            : base(lines,document,controlType,controlName)
        {
            if(Processed)
            {
                AddNodes(lines, controlName,document);
            }
        }

        private void AddNodes(IEnumerable<string> lines, string controlName,XmlDocument document)
        {
            var mainNodes = GetMainNodesName(lines, controlName);
            GetNodes(mainNodes, lines,document).ForEach(node => XmlNode.AppendChild(node));
        }

        private List<string> GetMainNodesName(IEnumerable<string> lines,string controlName)
        {
            var listLines = lines.ToList();
            var containsNodesLine = listLines
                .FirstOrDefault(line => line.Trim().Split('.').Contains(controlName) && line.Split('.').Contains("Nodes"));


            return GetNodesNames(listLines,containsNodesLine);
        }

        private List<string> GetNodesNames(List<string> listLines,string containsNodesLine)
        {
            List<string> nodes = new List<string>();

            if (containsNodesLine != null)
            {

                var nodesStartIndex = listLines.IndexOf(containsNodesLine);
                for (int index = nodesStartIndex + 1; index < listLines.Count; index++)
                {
                    nodes.Add(listLines[index].Trim().Replace(",", string.Empty).Replace("});", string.Empty));

                    if (listLines[index].EndsWith("});"))
                    {
                        break;
                    }
                }
            }
            return nodes;
        }

        private List<XmlNode> GetNodes(List<string> nodesName,IEnumerable<string> lines,XmlDocument document)
        {
            var nodes = new List<XmlNode>();
            foreach(var nodeName in nodesName)
            {
                var xmlNode = document.CreateElement("TreeViewItem", document.DocumentElement.NamespaceURI);

                var nodeAttributeLines = new List<string>();

                lines.Where(line => line.Trim().Split('.').Contains(nodeName))
                    .ToList()
                    .ForEach(line => nodeAttributeLines.Add("this." + line.Replace(nodeName+".",String.Empty).TrimStart(' ')));

                AttributesFactory.AttributesFactory.GetAttributes(nodeAttributeLines, document)
                    .ToList()
                    .ForEach(attribute => xmlNode.Attributes.Append(attribute));

                var contentAttribute = xmlNode.Attributes.GetNamedItem("Content");

                var headerAttribute = document.CreateAttribute("Header");
                headerAttribute.Value = contentAttribute.Value;

                xmlNode.Attributes.RemoveNamedItem("Content");
                xmlNode.Attributes.Append(headerAttribute);
                xmlNode.Attributes.RemoveNamedItem("Name");

                var mainNodes = GetSubNodesName(lines, nodeName);
                GetNodes(mainNodes, lines, document).ForEach(node => xmlNode.AppendChild(node));


                nodes.Add(xmlNode);
            }

            return nodes;
        }


        private List<string> GetSubNodesName(IEnumerable<string> lines, string nodeName)
        {
            var listLines = lines.ToList();

            var containsNodesLine = listLines
                .FirstOrDefault(line => line.Split(' ').Contains(nodeName) && line.Contains("System.Windows.Forms.TreeNode[]"));


            return GetNodesNames(listLines, containsNodesLine);
        }
    }
}
