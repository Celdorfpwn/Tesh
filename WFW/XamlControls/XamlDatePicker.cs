using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public class XamlDatePicker : XamlControl
    {
        protected override string ControlType
        {
            get { return "System.Windows.Forms.DateTimePicker"; }
        }

        protected override string XamlType
        {
            get { return "DatePicker"; }
        }

        public XamlDatePicker(IEnumerable<string> lines, XmlDocument document, string controlType, string controlName)
            : base(lines,document,controlType,controlName)
        {
            if (Processed)
            {
                var padding = document.CreateAttribute("Padding");
                padding.Value = "0";
                XmlNode.Attributes.Append(padding);
            }
        }
    }
}
