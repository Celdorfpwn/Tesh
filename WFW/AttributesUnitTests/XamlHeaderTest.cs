using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlHeaderTest
    {
        [TestMethod]
        public void XamlHeaderProcessedIsTrue()
        {
            var line = "this.HeaderText = \"Discount\";";
            var xmlDocument = new XmlDocument();

            var xamlHeader = new XamlHeader(line, xmlDocument);

            Assert.IsTrue(xamlHeader.Processed);
            Assert.IsNotNull(xamlHeader.XmlAttribute);
        }

        [TestMethod]
        public void XamlHeaderProcessedIsFalse()
        {
            var line = "this.Location = new System.Drawing.Point(13, 117);";
            var xmlDocument = new XmlDocument();

            var xamlHeader = new XamlHeader(line, xmlDocument);

            Assert.IsFalse(xamlHeader.Processed);
            Assert.IsNull(xamlHeader.XmlAttribute);
        }

        [TestMethod]
        public void XamlHeaderAttributeHasTheRightValue()
        {
            var line = "this.HeaderText = \"Discount\";"; 
            var xmlDocument = new XmlDocument();

            var xamlHeader = new XamlHeader(line, xmlDocument);

            Assert.IsNotNull(xamlHeader.XmlAttribute);
            Assert.AreEqual("Discount", xamlHeader.XmlAttribute.Value);
        }
    }
}
