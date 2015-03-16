using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFW
{
    public class CodeAnalyzer
    {
        private const string CanvasStart = "<Canvas>";
        private const string CanvasEnd = "</Canvas>";
        private const string ButtonStart = "<Button";
        private const string ButtonEnd = "></Button>";
        private const string CanvasLeft = " Canvas.Left=";
        private const string CanvasTop = " Canvas.Top=";
        private const string Width = " Width=";
        private const string Height = " Height=";
        private const string Name = " Name=";


        private const string Location = "Location";
        private const string DrawingPoint = "System.Drawing.Point";

        public static string GetWpfButton(string name,List<string> details)
        {
            StringBuilder builder = new StringBuilder();

            var location = GetLocation(details);
            bool hasLocation = !String.IsNullOrEmpty(location);

            if(hasLocation)
            {
                builder.Append(CanvasStart);
            }


            builder.Append(ButtonStart);

            if (hasLocation)
            {
                var points = GetPoints(location, name);

                builder.Append(CanvasLeft);
                builder.Append("\"" + points[0].Trim() + "\"");
                builder.Append(CanvasTop);
                builder.Append("\"" + points[1].Trim() + "\"");
            }

            var sizes = GetSizes(name, details);

            if(sizes!=null)
            {
                builder.Append(Width);
                builder.Append("\"" + sizes[0].Trim() + "\"");
                builder.Append(Height);
                builder.Append("\"" + sizes[1].Trim() + "\"");
            }

            var buttonName = GetName(name, details);

            if(buttonName!=null)
            {
                builder.Append(Name);
                builder.Append("\"" + buttonName + "\"");
            }

            builder.Append(ButtonEnd);

            if(hasLocation)
            {
                builder.Append(CanvasEnd);
            }

            return builder.ToString();
        }

        private static string GetName(string name,List<string> details)
        {
            var nameRow = "this." + name + ".Name = ";
 
            var line = details.FirstOrDefault(detail => detail.Contains(nameRow));

            if(line!=null)
            {
                var x = line.Trim()
                    .Replace(nameRow, String.Empty)
                    .Replace(";", String.Empty);
                return x.Remove(x.Length - 1, 1)
                    .Remove(0,1);
            }

            return null;
        }

        private static string[] GetSizes(string name,List<string> details)
        {
            var line = details.FirstOrDefault(detail => detail.Contains("Size = new System.Drawing.Size("));
            if(line!=null)
            {
                return line.Trim()
                    .Replace("this." + name + ".Size = new System.Drawing.Size(", string.Empty)
                    .Replace(");", string.Empty)
                    .Split(',');
            }

            return null;
        }

        private static string[] GetPoints(string location,string name)
        {
            var replace1 = "this."+name+".Location = new System.Drawing.Point(";
            var replace2 = ");";
            return location.Replace(replace1,String.Empty).Replace(replace2,String.Empty).Split(',');
        }

        private static string GetLocation(List<string> details)
        {
            foreach(var detail in details)
            {
                if(detail.Contains(Location) || detail.Contains(DrawingPoint))
                {
                    return detail.Trim();
                }
            }
            return null;
        }
    }
}
