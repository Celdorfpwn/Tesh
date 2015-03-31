using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public class XamlFontSize : XamlFont
    {
        protected override string Wpf
        {
            get { return "FontSize"; }
        }

        public XamlFontSize(string line,XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {

        }


        protected override string GetValue(string line)
        {
            var decimalSep = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            var size = line.Split(',')[1].Replace('F',' ').Trim().Replace(",",decimalSep).Replace(".",decimalSep);
            var toDouble = Convert.ToDouble(size);
            var doubleVal = toDouble / 72.0 * 96.0;
            var value = Convert.ToInt32(doubleVal).ToString();

            return value;
        }
    }
}
