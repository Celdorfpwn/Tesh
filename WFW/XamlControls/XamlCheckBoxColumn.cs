using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XamlControls
{
    public class XamlCheckBoxColumn : XamlDataGridColumn
    {
        protected override string ControlType
        {
            get { return "System.Windows.Forms.DataGridViewCheckBoxColumn"; }
        }

        protected override string XamlType
        {
            get { return "DataGridCheckBoxColumn"; }
        }

        public XamlCheckBoxColumn(IEnumerable<string> lines, XmlDocument document, string controlType, string controlName)
            : base(lines,document,controlType,controlName)
        {

        }
    }
}
