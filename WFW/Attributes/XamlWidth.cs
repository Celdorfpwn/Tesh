﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlWidth : XamlAttribute
    {
        protected override string Wpf
        {
            get
            {
                return "Width";
            }
        } 

        public XamlWidth(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            var value = line.Trim()
                    .Replace("this.Size = new System.Drawing.Size(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');

            if (value.Length > 0)
            {
                Validate(value[0], xmlDocument);
            }
        }
    }
}
