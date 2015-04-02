using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlFontWeightTest
    {
        [TestMethod]
        public void XamlFontWeightProcessedIsTrue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Consolas\", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();
            var xamlFontWeight = new XamlFontWeight(line, xmlDocument);

            Assert.IsTrue(xamlFontWeight.Processed);
            Assert.IsNotNull(xamlFontWeight.XmlAttribute);
        }

        [TestMethod]
        public void XamlFontWeightProcessedIsFalse()
        {
            var line = "this.Font = new System.Drawing.Font(\"Snap ITC\", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));";
            var xmlDocument = new XmlDocument();
            var xamlFontWeight = new XamlFontWeight(line, xmlDocument);

            Assert.IsFalse(xamlFontWeight.Processed);
            Assert.IsNull(xamlFontWeight.XmlAttribute);
        }

        [TestMethod]
        public void XamlFontWeightAttributeHasBoldValue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Consolas\", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();
            var xamlFontWeight = new XamlFontWeight(line, xmlDocument);

            Assert.IsNotNull(xamlFontWeight.XmlAttribute);

            Assert.AreEqual("Bold", xamlFontWeight.XmlAttribute.Value);
        }
    }
}
