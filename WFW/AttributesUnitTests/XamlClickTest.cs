using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlClickTest
    {
        [TestMethod]
        public void XamlCanvasLeftProcessedIsTrue()
        {
            var line = "this.Click += new System.EventHandler(this.button5_Click);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlClick(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlCanvasLeftCanProcessedIsFalse()
        {
            var line = "this.Focus += new System.EventHandler(this.button5_Focus);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlClick(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlCanvasLeftXmlAttriuteHasTheRightValue()
        {
            var line = "this.Click += new System.EventHandler(this.button5_Click);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlClick(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("button5_Click", xamlCanvasLeft.XmlAttribute.Value);
        }
    }
}
