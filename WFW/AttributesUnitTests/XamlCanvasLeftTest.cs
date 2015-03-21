using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Attributes;
using System.Linq;
using System.Collections.Generic;
using System.Xml;
namespace AttributesUnitTests
{
    [TestClass]
    public class XamlCanvasLeftTest
    {
        [TestMethod]
        public void XamlCanvasLeftProcessedIsTrue()
        {
            var line = "this.Location = new System.Drawing.Point(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlCanvasLeft(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlCanvasLeftCanProcessedIsFalse()
        {
            var line = "this.Size = new System.Drawing.Size(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlCanvasLeft(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlCanvasLeftXmlAttriuteHasTheRightValue()
        {
            var line = "this.Location = new System.Drawing.Point(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlCanvasLeft(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("13", xamlCanvasLeft.XmlAttribute.Value);
        }

    }
}
