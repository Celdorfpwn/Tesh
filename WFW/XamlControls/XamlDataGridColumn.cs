using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public abstract class XamlDataGridColumn : XamlControl
    {
        public XamlDataGridColumn(IEnumerable<string> lines, XmlDocument document, string controlType, string controlName)
            : base(lines,document,controlType,controlName)
        {
            if (Processed)
            {
                XmlNode.Attributes.RemoveNamedItem("Name");
                var widthAttribute = XmlNode.Attributes.GetNamedItem("Width");
                if(widthAttribute==null)
                {
                    var width = document.CreateAttribute("Width");
                    width.Value = "*";
                    XmlNode.Attributes.Append(width);
                }
            }
        }
    }
}
