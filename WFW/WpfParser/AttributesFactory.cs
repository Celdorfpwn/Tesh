using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfParser
{
    public class WindowAttributesFactory
    {
        private XmlDocument Document { get; set; }

        public WindowAttributesFactory(XmlDocument doc)
        {
            Document = doc;
        }

        public List<XmlAttribute> GetWindowAttributes(IEnumerable<string> lines)
        {
            var attributes = new List<XmlAttribute>();

            foreach(var line in lines)
            {
                SetAttributes(attributes, line);
            }

            return attributes;
        }

        private  void SetAttributes(List<XmlAttribute> attributes,string line)
        {
            if(line.Contains(Text))
            {
                AddTitleAttribute(attributes, line);
                return;
            }
            if(line.Contains(ClientSize))
            {
                AddClientSizeAttributes(attributes, line);
                return;
            }
        }

        private void AddTitleAttribute(List<XmlAttribute> attributes, string line)
        {
            var text = line.Trim().Replace("this.Text = ", string.Empty)
                .Replace("\"", String.Empty).Replace(";",string.Empty);

            var title = Document.CreateAttribute(Title);
            title.Value = text;
            attributes.Add(title);
        }

        private  void AddClientSizeAttributes(List<XmlAttribute> attributes, string line)
        {
            var sizes = GetSizes(line);

            var width = Document.CreateAttribute(Width);
            width.Value = (Convert.ToInt32(sizes[0].Trim())+16).ToString();
            var height = Document.CreateAttribute(Height);
            height.Value = (Convert.ToInt32(sizes[1].Trim())+38).ToString();

            attributes.Add(width);
            attributes.Add(height);

        }

        private  string[] GetSizes(string line)
        {
            if (line != null)
            {
                return line.Trim()
                    .Replace("this.ClientSize = new System.Drawing.Size(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');
            }
            return null;
        }



        private const string ClientSize = "ClientSize";
        private const string Name = "Name";
        private const string Text = "Text";

        private const string Height = "Height";
        private const string Width = "Width";
        private const string Title = "Title";
    }
}
