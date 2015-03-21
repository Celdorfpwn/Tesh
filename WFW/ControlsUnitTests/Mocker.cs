using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ControlsUnitTests
{
    static class Mocker
    {

        public static IEnumerable<string> Lines
        {
            get
            {
                var filesPath = "../Debug/controlLines.txt";


                return File.ReadAllLines(filesPath);

            }
        }

        public static XmlDocument XmlDocument
        {
            get
            {
                var xmlDocument = new XmlDocument();
                var att = xmlDocument.CreateElement("Window", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
                xmlDocument.AppendChild(att);
                return xmlDocument;
            }
        }

    }
}
