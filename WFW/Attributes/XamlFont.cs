using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public abstract class XamlFont : XamlAttribute
    {
        public XamlFont(string line,XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            if (line.Contains("this.Font = new System.Drawing.Font"))
            {
                var clearedLine = line.Replace("this.Font = new System.Drawing.Font(", String.Empty).Replace(");", string.Empty);
                var value = GetValue(clearedLine);

                Validate(value, xmlDocument);
            }
        }

        protected abstract string GetValue(string line);
    }
}
