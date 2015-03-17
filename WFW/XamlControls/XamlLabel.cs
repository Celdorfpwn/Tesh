using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public class XamlLabel : XamlControl
    {
        protected override string ControlType
        {
            get { return "System.Windows.Forms.Label"; }
        }

        protected override string XamlType
        {
            get { return "Label"; }
        }

        public XamlLabel(IEnumerable<string> lines,XmlDocument document,string controlType,string controlName)
            : base(lines,document,controlType,controlName)
        {
            if(Processed)
            {
                var padding = document.CreateAttribute("Padding");
                padding.Value = "0";
                XmlNode.Attributes.Append(padding);
                //List<XmlAttribute> removeAttributes = new List<XmlAttribute>();

                //foreach(XmlAttribute attribute in XmlNode.Attributes)
                //{
                //    if(attribute.Name.Equals("Width") || attribute.Name.Equals("Height"))
                //    {
                //        removeAttributes.Add(attribute);
                //    }
                //}

                //removeAttributes.ForEach(attribute => XmlNode.Attributes.Remove(attribute));
            }
        }
    }
}
