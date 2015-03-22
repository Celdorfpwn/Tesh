using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlForegroundTest
    {
        [TestMethod]
        public void XamlForegroundProcessedIsTrue()
        {
            var line = "this.ForeColor = System.Drawing.SystemColors.ControlDark;";

            var xamlForeground = new XamlForeground(line, new System.Xml.XmlDocument());

            Assert.IsTrue(xamlForeground.Processed);
            Assert.IsNotNull(xamlForeground.XmlAttribute);
        }

        [TestMethod]
        public void XamlForegroundProcessedIsFalse()
        {
            var line = "this.Location = new System.Drawing.Point(12,13);";

            var xamlForeground = new XamlForeground(line, new System.Xml.XmlDocument());

            Assert.IsFalse(xamlForeground.Processed);
            Assert.IsNull(xamlForeground.XmlAttribute);
        }

        [TestMethod]
        public void XamlForegroundColorFromSystemColors()
        {
            var line = "this.ForeColor = System.Drawing.SystemColors.ControlDark;";

            var xamlForeground = new XamlForeground(line, new System.Xml.XmlDocument());

            var expected = "#FFA0A0A0";

            Assert.AreEqual(expected, xamlForeground.XmlAttribute.Value);
        }

        [TestMethod]
        public void XamlForegorundColorFromArgb()
        {
            var line = "this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));";
            var xamlForeground = new XamlForeground(line, new System.Xml.XmlDocument());

            var expected = "#FFC04000";
            Assert.AreEqual(expected, xamlForeground.XmlAttribute.Value);
        }

        [TestMethod]
        public void XamlForegroundColorFromColors()
        {
            var line = "this.ForeColor = System.Drawing.Color.Lime;";
            var xamlForeground = new XamlForeground(line, new System.Xml.XmlDocument());
            var expected = "#FF00FF00";
            Assert.AreEqual(expected, xamlForeground.XmlAttribute.Value);
        }
    }
}
