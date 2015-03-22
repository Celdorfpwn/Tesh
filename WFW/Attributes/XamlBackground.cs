using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlBackground : XamlColorAttribute
    {
        protected override string Wpf
        {
            get { return "Background"; }
        }

        public XamlBackground(string line, XmlDocument xmlDocument)
            : base(line, xmlDocument)
        {
        }


        protected override bool IsColorAttribute(string line)
        {
            return line.Contains("BackColor = System.Drawing.");
        }

        protected override string ClearLine(string line)
        {
            return line.Trim().Replace("this.BackColor = System.Drawing.", string.Empty);
        }
    }
}
