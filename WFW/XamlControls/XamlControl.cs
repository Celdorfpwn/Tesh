using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public abstract class XamlControl
    {
        public bool Processed { get;private set; }

        public XmlNode XmlNode { get;private set; }

        protected abstract string  ControlType { get; }

        protected abstract string XamlType { get; }

        public XamlControl(IEnumerable<string> lines,XmlDocument document,string controlType,string controlName)
        {
            if (Validate(controlType))
            {
                Processed = true;
                XmlNode = document.CreateElement(XamlType, document.DocumentElement.NamespaceURI);
                lines = ClearLines(controlName, lines);
                AttributesFactory
                    .AttributesFactory
                    .GetAttributes(lines, document)
                    .ToList()
                    .ForEach(attribute => XmlNode.Attributes.Append(attribute));
            }
        }

        private bool Validate(string controlType)
        {
            return controlType.Trim().Equals(ControlType);
        }

        private IEnumerable<string> ClearLines(string controlName,IEnumerable<string> controlLines)
        {
            var lines = new List<string>();
            var remove = controlName + ".";
            var controlIdentifier = "this." + controlName;
            controlLines.Where(line => line.Split('.',')',',').Contains(controlName))
                .ToList()
                .ForEach(line => lines.Add(line.Replace(remove,string.Empty)));

            return lines;
        }
    }
}
            //var lines = new List<string>();
            //var remove = controlName + ".";
            ////var controlIdentifier = "this." + controlName;

            ////controlLines.Where(line => line.Split('.',')',',').Contains(controlName))
            ////    .ToList()
            ////    .ForEach(line => lines.Add(line.Replace(remove,string.Empty)));

            //var listLines = controlLines.ToList();
            

            //var first = controlLines.First(line => line.Contains("// " + controlName));

            //var startIndex = listLines.IndexOf(first) + 2;
            //var addIndex = 0;
            //while(!listLines[startIndex].Trim().Equals("//"))
            //{
            //    if(listLines[startIndex].Contains("this."+controlName))
            //    {
            //        lines.Add(listLines[startIndex]);
            //        addIndex++;
            //    }
            //    else
            //    {
            //        lines[addIndex-1] += listLines[startIndex];
            //    }

            //    startIndex++;
            //}

            //var processedLines = new List<string>();

            //lines.ForEach(line => processedLines.Add(line.Replace(remove, string.Empty)));

            //return processedLines;