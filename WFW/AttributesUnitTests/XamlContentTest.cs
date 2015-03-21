using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlContentTest
    {
        [TestMethod]
        public void XamlContentProcessedIsTrue()
        {
            var line = "this.Text = \"button5\";";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlContent(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
        }

        [TestMethod]
        public void XamlContentCanProcessedIsFalse()
        {
            var line = "this.Size = new System.Drawing.Size(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlContent(line, xmlDocument);

            Assert.IsFalse(xamlCanvasLeft.Processed);
            Assert.IsTrue(xamlCanvasLeft.XmlAttribute == null);
        }


        [TestMethod]
        public void XamlContentXmlAttriuteHasTheRightValue()
        {
            var line = "this.Text = \"button5\";";
            var xmlDocument = new XmlDocument();

            var xamlCanvasLeft = new XamlContent(line, xmlDocument);

            Assert.IsTrue(xamlCanvasLeft.XmlAttribute != null);
            Assert.AreEqual("button5", xamlCanvasLeft.XmlAttribute.Value);
        }
    }
}
