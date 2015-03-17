using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public class XamlTextBox : XamlControl
    {
        protected override string ControlType
        {
            get { return "System.Windows.Forms.TextBox"; }
        }

        protected override string XamlType
        {
            get { return "TextBox"; }
        }

        public XamlTextBox(IEnumerable<string> lines, XmlDocument document, string controlType, string controlName)
            : base(lines,document,controlType,controlName)
        {
            if(Processed)
            {
                XmlAttribute removeNode = null;
                XmlAttribute newNode = null;
                foreach (XmlAttribute attribute in XmlNode.Attributes)
                {
                    if(attribute.Name.Equals("Content"))
                    {
                        newNode = document.CreateAttribute("Text");
                        newNode.Value = attribute.Value;
                        removeNode = attribute;
                        break;
                    }
                }
                if(removeNode!=null && newNode!=null)
                {
                    XmlNode.Attributes.Remove(removeNode);
                    XmlNode.Attributes.Append(newNode);
                }
            }
        }
    }
}
