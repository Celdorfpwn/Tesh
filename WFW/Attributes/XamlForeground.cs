using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlForeground : XamlColorAttribute
    {
        protected override string Wpf
        {
            get { return "Foreground"; }
        }


        public XamlForeground(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }

        protected override bool IsColorAttribute(string line)
        {
            return line.Contains("ForeColor = System.Drawing.");
        }

        protected override string ClearLine(string line)
        {
            return line.Trim().Replace("this.ForeColor = System.Drawing.", string.Empty);
        }
    }
}
