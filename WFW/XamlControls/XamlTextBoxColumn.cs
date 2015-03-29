using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public class XamlTextBoxColumn : XamlDataGridColumn
    {
        protected override string ControlType
        {
            get { return "System.Windows.Forms.DataGridViewTextBoxColumn"; }
        }

        protected override string XamlType
        {
            get { return "DataGridTextColumn"; }
        }

        public XamlTextBoxColumn(IEnumerable<string> lines, XmlDocument document, string controlType, string controlName)
            : base(lines,document,controlType,controlName)
        {
        }

    }
}
