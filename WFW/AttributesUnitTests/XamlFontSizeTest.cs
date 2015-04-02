using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Attributes;
using System.Xml;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlFontSizeTest
    {
        [TestMethod]
        public void XamlFontSizeProcessedIsTrue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Gill Sans Ultra Bold\", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();
            var xamlFontSize = new XamlFontSize(line,xmlDocument);

            Assert.IsTrue(xamlFontSize.Processed);

            Assert.IsNotNull(xamlFontSize.XmlAttribute);
        }

        [TestMethod]
        public void XamlFontSizeProcessedIsFalse()
        {
            var line = "this.Location = new System.Drawing.Point(232, 41);";
            var xamlDocument = new XmlDocument();
            var xamlFontSize = new XamlFontSize(line, xamlDocument);

            Assert.IsFalse(xamlFontSize.Processed);
            Assert.IsNull(xamlFontSize.XmlAttribute);
        }


        [TestMethod]
        public void XamlFontSizeAttributeHasTheRightValue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Gill Sans Ultra Bold\", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";

            var xmlDocument = new XmlDocument();

            var xamlFontSize = new XamlFontSize(line, xmlDocument);

            Assert.IsNotNull(xamlFontSize.XmlAttribute);

            Assert.AreEqual("11", xamlFontSize.XmlAttribute.Value);
        }
    }
}
