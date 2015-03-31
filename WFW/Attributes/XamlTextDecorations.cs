using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlTextDecorations : XamlFont
    {
        protected override string Wpf
        {
            get { return "TextDecorations"; }
        }

        public XamlTextDecorations(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }

        protected override string GetValue(string line)
        {
            List<string> decorations = new List<string>();

            if (line.Contains("System.Drawing.FontStyle.Underline"))
            {
                decorations.Add("Underline");
            }

            if (line.Contains("System.Drawing.FontStyle.Strikeout"))
            {
                decorations.Add("Strikethrough");
            }

            var value = String.Empty;

            if(decorations.Count == 2)
            {
                value = decorations[0] + "," + decorations[1];
            }
            else if(decorations.Count == 1)
            {
                value = decorations[0];
            }

            if(string.IsNullOrEmpty(value))
            {
                value = "this.";
            }


            return value;
        }
    }
}
