﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlFontStyle : XamlFont
    {
        protected override string Wpf
        {
            get { return "FontStyle"; }
        }

        public XamlFontStyle(string line,XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }

        protected override string GetValue(string line)
        {
            var value = "this.";

            if (line.Contains("System.Drawing.FontStyle.Regular"))
            {
                value = "Normal";
            }
            else if (line.Contains("System.Drawing.FontStyle.Italic"))
            {
                value = "Italic";
            }

            return value;
        }

    }
}
