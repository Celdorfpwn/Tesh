using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attributes
{
    public abstract class XamlColorAttribute : XamlAttribute
    {
        public XamlColorAttribute(string line, XmlDocument xmlDocument)
            :base(line,xmlDocument)
        {
            if (IsColorAttribute(line))
            {
                var color = GetColor(line);

                Validate(color, xmlDocument);
            }
        }

        protected abstract bool IsColorAttribute(string line);

        protected abstract string ClearLine(string line);

        private string GetColor(string line)
        {
            var colorLine = ClearLine(line);

            if(colorLine.Contains("FromArgb"))
            {
                return ColorFromArgb(colorLine);
            }

            if (colorLine.Contains("SystemColors"))
            {
                return ColorFromSystem(colorLine);
            }

            if(colorLine.Contains("Color"))
            {
                return ColorFromColors(colorLine);
            }

            return string.Empty;
        }

        private string ColorFromColors(string colorLine)
        {
            var colorName = colorLine.Replace("Color.", String.Empty)
                .Replace(";", String.Empty).Trim();

            var color = Color.FromName(colorName);

            return HexFromARGB(color.A, color.R, color.G, color.B);
        }

        private string ColorFromSystem(string colorLine)
        {
            var colorName = colorLine.Replace("SystemColors.", String.Empty)
                .Replace(";", String.Empty).Trim();

            var colorType = typeof(SystemColors).GetProperties(BindingFlags.Static | BindingFlags.Public)
                .FirstOrDefault(systemColor => systemColor.Name.Equals(colorName));

            var colors = typeof(SystemColors).GetProperties(BindingFlags.Static | BindingFlags.Public).ToList();

            var color = (Color)colorType.GetValue(colorType);

            return HexFromARGB(color.A, color.R, color.G, color.B);
        }


        private string ColorFromArgb(string colorLine)
        {
            var colorCodes = colorLine.Replace("Color.FromArgb(", String.Empty)
                .Replace("((int)(((byte)(", String.Empty)
                .Replace("))))", String.Empty)
                .Replace(");", String.Empty)
                .Trim().Split(',');

            var argbColor = System.Drawing
                .Color.FromArgb(((int)(((byte)(Convert.ToInt32(colorCodes[0]))))),
                ((int)(((byte)(Convert.ToInt32(colorCodes[1]))))),
                ((int)(((byte)(Convert.ToInt32(colorCodes[2]))))));

            return HexFromARGB(argbColor.A,argbColor.R,argbColor.G,argbColor.B);
        }

        private string HexFromARGB(byte A,byte R,byte G,byte B)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}",
                 A,
                 R,
                 G,
                 B);
        }


    }
}
