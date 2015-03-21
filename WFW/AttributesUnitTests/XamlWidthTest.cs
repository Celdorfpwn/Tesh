using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlWidthTest
    {
        [TestMethod]
        public void XamlWidthProcessedIsTrue()
        {
            var line = "this.Size = new System.Drawing.Size(75, 23);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlWidth(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlWidthCanProcessedIsFalse()
        {
            var line = "this.Location = new System.Drawing.Point(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlWidth(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlWidthXmlAttriuteHasTheRightValue()
        {
            var line = "this.Size = new System.Drawing.Size(75, 23);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlWidth(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("75", xamlCanvasLeft.XmlAttribute.Value);
        }
    }
}
