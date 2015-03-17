﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlHeight : XamlAttribute
    {
        private const string WpfHeight = "Height";

        public XamlHeight(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            Wpf = WpfHeight;

            var value = line.Trim()
                    .Replace("this.Size = new System.Drawing.Size(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');

            if (value.Length > 1 && value[0].Length<5)
            {
                Validate(value[1].Trim(), xmlDocument);
            }
        }
    }
}
