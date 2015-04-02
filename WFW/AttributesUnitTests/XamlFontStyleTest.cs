using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlFontStyleTest
    {
        [TestMethod]
        public void XamlFontStyleProcessedIsTrue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Mistral\", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();

            var xamlFontStyle = new XamlFontStyle(line, xmlDocument);

            Assert.IsTrue(xamlFontStyle.Processed);
            Assert.IsNotNull(xamlFontStyle.XmlAttribute);
        }

        [TestMethod]
        public void XamlFontStyleProcessedIsFalse()
        {
            var line = "this.Font = new System.Drawing.Font(\"Gill Sans Ultra Bold\", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();

            var xamlFontStyle = new XamlFontStyle(line, xmlDocument);

            Assert.IsFalse(xamlFontStyle.Processed);
            Assert.IsNull(xamlFontStyle.XmlAttribute);
        }

        [TestMethod]
        public void XamlFontStyleAttributeValueIsNormal()
        {
            var line = "this.Font = new System.Drawing.Font(\"Mistral\", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();

            var xamlFontStyle = new XamlFontStyle(line, xmlDocument);

            Assert.IsNotNull(xamlFontStyle.XmlAttribute);
            Assert.AreEqual("Normal", xamlFontStyle.XmlAttribute.Value);
        }

        [TestMethod]
        public void XamlFontStyleAttributeValueIsItalic()
        {
            var line = "this.Font = new System.Drawing.Font(\"Monotype Corsiva\", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();

            var xamlFontStyle = new XamlFontStyle(line, xmlDocument);

            Assert.IsNotNull(xamlFontStyle.XmlAttribute);
            Assert.AreEqual("Italic", xamlFontStyle.XmlAttribute.Value);
        }
    }
}
