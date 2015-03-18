using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public class XamlRadioButton : XamlControl
    {
        protected override string ControlType
        {
            get { return "System.Windows.Forms.RadioButton"; }
        }

        protected override string XamlType
        {
            get { return "RadioButton"; }
        }

        public XamlRadioButton(IEnumerable<string> lines, XmlDocument document, string controlType, string controlName)
            : base(lines,document,controlType,controlName)
        {

        }
    }
}
