using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Collections.Generic;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlCheckBoxTest
    {
        [TestMethod]
        public void XamlCheckBoxProcessedIsTrue()
        {
            var controlName = "checkBox2";
            var controlType = "System.Windows.Forms.CheckBox ";

            var xamlCheckBox = new XamlCheckBox(CheckBoxLines, MockedXmlDocument, controlType, controlName);

            Assert.IsTrue(xamlCheckBox.Processed);

            Assert.IsNotNull(xamlCheckBox.XmlNode);
        }


        [TestMethod]
        public void XamlCheckBoxProcessedIsFalse()
        {
            var controlName = "button5";        
            var controlType = "System.Windows.Forms.Button ";

            var xamlCheckBox = new XamlCheckBox(CheckBoxLines, MockedXmlDocument, controlType, controlName);

            Assert.IsFalse(xamlCheckBox.Processed);

            Assert.IsNull(xamlCheckBox.XmlNode);
        }

        [TestMethod]
        public void XamlCheckBoxHasAttributes()
        {
            var controlName = "checkBox2";
            var controlType = "System.Windows.Forms.CheckBox ";

            var xamlCheckBox = new XamlCheckBox(CheckBoxLines, MockedXmlDocument, controlType, controlName);

            var expected = 7;

            var actual = xamlCheckBox.XmlNode.Attributes.Count;

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


        private List<string> CheckBoxLines
        {
            get
            {
                return new List<string>
            {
                  "this.checkBox2.AutoSize = true;",
                  "this.checkBox2.Location = new System.Drawing.Point(176, 199);",
                  "this.checkBox2.Name = \"checkBox2\";",
                  "this.checkBox2.Size = new System.Drawing.Size(80, 17);",
                  "this.checkBox2.TabIndex = 23;",
                  "this.checkBox2.Text = \"checkBox2\";"
            };
            }

        }
    }
}
