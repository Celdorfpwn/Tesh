using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlTextDecorationsTest
    {
        [TestMethod]
        public void XamlTextDecorationsProcessedIsTrue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Snap ITC\", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));";
            var xmlDocument = new XmlDocument();
            var xamlTextDecorations = new XamlTextDecorations(line,xmlDocument);

            Assert.IsTrue(xamlTextDecorations.Processed);
            Assert.IsNotNull(xamlTextDecorations.XmlAttribute);
            
        }

        [TestMethod]
        public void XamlTextDecorationsProcessedIsFalse()
        {
            var line = "this.Font = new System.Drawing.Font(\"Consolas\", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();
            var xamlTextDecorations = new XamlTextDecorations(line, xmlDocument);

            Assert.IsFalse(xamlTextDecorations.Processed);
            Assert.IsNull(xamlTextDecorations.XmlAttribute);
        }

        [TestMethod]
        public void XamlTextDecorationsXmlAttributeHasUnderlineValue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Snap ITC\", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));";
            var xmlDocument = new XmlDocument();
            var xamlTextDecorations = new XamlTextDecorations(line, xmlDocument);

            Assert.IsNotNull(xamlTextDecorations.XmlAttribute);
            Assert.AreEqual("Underline", xamlTextDecorations.XmlAttribute.Value);
        }

        [TestMethod]
        public void XamlTextDecorationsAttributesHasStrikethroughValue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Gill Sans Ultra Bold\", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();
            var xamlTextDecorations = new XamlTextDecorations(line, xmlDocument);

            Assert.IsNotNull(xamlTextDecorations.XmlAttribute);
            Assert.AreEqual("Strikethrough", xamlTextDecorations.XmlAttribute.Value);
        }

        [TestMethod]
        public void XamlTextDecorationsAttributesHasUnderlineAndStrikethroughValues()
        {
            var line = "this.Font = new System.Drawing.Font(\"Algerian\", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));";
            var xmlDocument = new XmlDocument();
            var xamlTextDecorations = new XamlTextDecorations(line, xmlDocument);

            Assert.IsNotNull(xamlTextDecorations.XmlAttribute);
            Assert.AreEqual("Underline,Strikethrough", xamlTextDecorations.XmlAttribute.Value);
        }
    }
}
