using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Attributes;
using System.Xml;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlFontFamilyTest
    {
        [TestMethod]
        public void XamlFontFamilyProcessedIsTrue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Gill Sans Ultra Bold\", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";
            var xmlDocument = new XmlDocument();
            var XamlFontFamily = new XamlFontFamily(line, xmlDocument);

            Assert.IsTrue(XamlFontFamily.Processed);

            Assert.IsNotNull(XamlFontFamily.XmlAttribute);
        }

        [TestMethod]
        public void XamlFontFamilyProcessedIsFalse()
        {
            var line = "this.Location = new System.Drawing.Point(232, 41);";
            var xamlDocument = new XmlDocument();
            var XamlFontFamily = new XamlFontFamily(line, xamlDocument);

            Assert.IsFalse(XamlFontFamily.Processed);
            Assert.IsNull(XamlFontFamily.XmlAttribute);
        }


        [TestMethod]
        public void XamlFontFamilyAttributeHasTheRightValue()
        {
            var line = "this.Font = new System.Drawing.Font(\"Gill Sans Ultra Bold\", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));";

            var xmlDocument = new XmlDocument();

            var XamlFontFamily = new XamlFontFamily(line, xmlDocument);

            Assert.IsNotNull(XamlFontFamily.XmlAttribute);

            Assert.AreEqual("Gill Sans Ultra Bold", XamlFontFamily.XmlAttribute.Value);
        }
    }
}
