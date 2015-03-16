using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfParser
{
    public class ButtonAttributesFactory
    {
        private XmlDocument Document { get; set; }

        public ButtonAttributesFactory(XmlDocument document)
        {
            Document = document;
        }

        internal IEnumerable<XmlAttribute> GetAttributes(string controlName, IEnumerable<string> controlLines)
        {
            List<XmlAttribute> attributes = new List<XmlAttribute>();

            var lines = new List<string>();

            

            foreach(var line in controlLines)
            { 
                var newLine = line.Replace(controlName + ".", String.Empty);
                lines.Add(newLine);
            }

            return AttributesFactory.AttributesFactory.GetAttributes(lines,Document);
        }

        private void SetAttributes(List<XmlAttribute> attributes, string line)
        {
            if(line.Contains(Location))
            {
                SetLocationAttributes(attributes, line);
                return;
            }
            if(line.Contains(Size))
            {
                SetSizeAttributes(attributes, line);
                return;
            }
            if(line.Contains(TabIndex))
            {
                SetTabIndexAttribute(attributes, line);
                return;
            }
            if(line.Contains(Name))
            {
                SetNameAttribute(attributes, line);
            }
            if(line.Contains(Text))
            {
                SetTextAttribute(attributes, line);
            }
        }

        private void SetTextAttribute(List<XmlAttribute> attributes, string line)
        {
            XmlAttribute content = Document.CreateAttribute(Content);
            var value = line.Trim().Replace("this.Text = ", String.Empty)
                .Replace("\"", String.Empty)
                .Replace(";", String.Empty)
                .Trim();
            content.Value = value;
            attributes.Add(content);
        }

        private void SetNameAttribute(List<XmlAttribute> attributes, string line)
        {
            XmlAttribute name = Document.CreateAttribute(Name);
            var value = line.Trim().Replace("this.Name = ", String.Empty)
                .Replace("\"", String.Empty)
                .Replace(";",String.Empty)
                .Trim();
            name.Value = value;
            attributes.Add(name);
        }



        private void SetTabIndexAttribute(List<XmlAttribute> attributes, string line)
        {
            XmlAttribute tabIndex = Document.CreateAttribute(TabIndex);
            var value = line.Trim().Replace("this.TabIndex = ", String.Empty)
                .Replace(";", String.Empty).Trim();
            tabIndex.Value = value;
            attributes.Add(tabIndex);
        }

        private void SetSizeAttributes(List<XmlAttribute> attributes, string line)
        {
            var sizes = GetSizes(line);
            XmlAttribute width = Document.CreateAttribute(Width);
            width.Value = sizes[0].Trim();
            XmlAttribute height = Document.CreateAttribute(Height);
            height.Value = sizes[1].Trim();
            attributes.Add(width);
            attributes.Add(height);
        }

        private void SetLocationAttributes(List<XmlAttribute> attributes, string line)
        {
            var values = GetLocationPoints(line);

            XmlAttribute canvasLeft = Document.CreateAttribute(CanvasLeft);
            canvasLeft.Value = values[0].Trim();
            XmlAttribute canvasTop = Document.CreateAttribute(CanvasTop);
            canvasTop.Value = values[1].Trim();
            attributes.Add(canvasLeft);
            attributes.Add(canvasTop);

        }


        private string[] GetLocationPoints(string line)
        {
            if (line != null)
            {
                return line.Trim()
                    .Replace("this.Location = new System.Drawing.Point(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');
            }
            return null;
        }

        private string[] GetSizes(string line)
        {
            if (line != null)
            {
                return line.Trim()
                    .Replace("this.Size = new System.Drawing.Size(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');
            }
            return null;
        }



        private const string Location = "Location";
        private const string Size = "Size";
        private const string TabIndex = "TabIndex";
        private const string Name = "Name";
        private const string Text = "Text";


        private const string CanvasTop = "Canvas.Top";
        private const string CanvasLeft = "Canvas.Left";
        private const string Width = "Width";
        private const string Height = "Height";
        private const string Content = "Content";

    }
}
