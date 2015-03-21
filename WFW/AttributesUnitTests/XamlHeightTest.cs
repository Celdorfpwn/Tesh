using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlHeightTest
    {
        [TestMethod]
        public void XamlHeightProcessedIsTrue()
        {
            var line = "this.Size = new System.Drawing.Size(75, 23);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlHeight(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlHeightCanProcessedIsFalse()
        {
            var line = "this.Location = new System.Drawing.Point(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlHeight(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlHeightXmlAttriuteHasTheRightValue()
        {
            var line = "this.Size = new System.Drawing.Size(75, 23);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlHeight(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("23", xamlCanvasLeft.XmlAttribute.Value);
        }
    }
}
