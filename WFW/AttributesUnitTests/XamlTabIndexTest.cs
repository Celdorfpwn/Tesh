using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Attributes;
using System.Xml;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlTabIndexTest
    {
        [TestMethod]
        public void XamlTabIndexProcessedIsTrue()
        {
            var line = "this.TabIndex = 4;";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlTabIndex(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlTabIndexCanProcessedIsFalse()
        {
            var line = "this.Size = new System.Drawing.Size(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlTabIndex(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlTabIndexXmlAttriuteHasTheRightValue()
        {
            var line = "this.TabIndex = 4;";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlTabIndex(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("4", xamlCanvasLeft.XmlAttribute.Value);
        }
    }
}
