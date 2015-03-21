using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlButtonTest
    {
        [TestMethod]
        public void XamlButtonProcessedIsTrue()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var xamlButton = new XamlButton(ButtonLines, MockedXmlDocument, controlType, controlName);

            Assert.IsTrue(xamlButton.Processed);

            Assert.IsNotNull(xamlButton.XmlNode);
        }

        [TestMethod]
        public void XamlButtonProcessedIsFalse()
        {
            var controlName = "textBox5";
            var controlType = "System.Windows.Forms.TextBox ";

            var xamlButton = new XamlButton(ButtonLines, MockedXmlDocument, controlType, controlName);

            Assert.IsFalse(xamlButton.Processed);

            Assert.IsNull(xamlButton.XmlNode);
        }

        [TestMethod]
        public void XamlButtonHasAttributes()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var xamlButton = new XamlButton(ButtonLines, MockedXmlDocument, controlType, controlName);

            var expected = 8;

            var actual = xamlButton.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }

        private XmlDocument MockedXmlDocument
        {
            get
            {
                var xmlDocument = new XmlDocument();
                var att = xmlDocument.CreateElement("Window", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
                xmlDocument.AppendChild(att);
                return xmlDocument;
            }
        }

        private List<string> ButtonLines
        {
            get
            {
                return new List<string>
            {
                  "this.button5.Location = new System.Drawing.Point(37, 13);",
                  "this.button5.Name = \"button5\";",
                  "this.button5.Size = new System.Drawing.Size(75, 23);",
                  "this.button5.TabIndex = 4;",
                  "this.button5.Text = \"button5\";",
                  "this.button5.UseVisualStyleBackColor = true;",
                  "this.button5.Click += new System.EventHandler(this.button5_Click);"
            };
            }
            
        }
    }
}
