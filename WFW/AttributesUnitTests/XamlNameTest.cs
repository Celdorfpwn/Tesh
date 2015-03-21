using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlNameTest
    {
        [TestMethod]
        public void XamlNameProcessedIsTrue()
        {
            var line = "this.Name = \"button5\";";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlName(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlNameCanProcessedIsFalse()
        {
            var line = "this.Size = new System.Drawing.Size(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlName(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlNameXmlAttriuteHasTheRightValue()
        {
            var line = "this.Name = \"button5\";";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlName(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("button5", xamlCanvasLeft.XmlAttribute.Value);
        }
    }
}
