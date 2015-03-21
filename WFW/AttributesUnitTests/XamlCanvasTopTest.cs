using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlCanvasTopTest
    {
        [TestMethod]
        public void XamlCanvasTopProcessedIsTrue()
        {
            var line = "this.Location = new System.Drawing.Point(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlCanvasTop(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlCanvasTopCanProcessedIsFalse()
        {
            var line = "this.Size = new System.Drawing.Size(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlCanvasTop(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlCanvasTopXmlAttriuteHasTheRightValue()
        {
            var line = "this.Location = new System.Drawing.Point(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlCanvasTop(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("117", xamlCanvasLeft.XmlAttribute.Value);
        }
    }
}
