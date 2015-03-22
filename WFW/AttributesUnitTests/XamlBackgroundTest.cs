using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlBackgroundTest
    {
        [TestMethod]
        public void XamlBackgroundProcessedIsTrue()
        {
            var line = "this.BackColor = System.Drawing.SystemColors.ControlDark;";

            var xamlBackground = new XamlBackground(line, new System.Xml.XmlDocument());

            Assert.IsTrue(xamlBackground.Processed);
            Assert.IsNotNull(xamlBackground.XmlAttribute);
        }

        [TestMethod]
        public void XamlBackgroundProcessedIsFalse()
        {
            var line = "this.Location = new System.Drawing.Point(12,13);";

            var xamlBackground = new XamlBackground(line, new System.Xml.XmlDocument());

            Assert.IsFalse(xamlBackground.Processed);
            Assert.IsNull(xamlBackground.XmlAttribute);
        }

        [TestMethod]
        public void XamlBackgroundColorFromSystemColors()
        {
            var line = "this.BackColor = System.Drawing.SystemColors.ControlDark;";

            var xamlBackground = new XamlBackground(line, new System.Xml.XmlDocument());

            var expected = "#FFA0A0A0";

            Assert.AreEqual(expected, xamlBackground.XmlAttribute.Value);
        }

        [TestMethod]
        public void XamlForegorundColorFromArgb()
        {
            var line = "this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));";
            var xamlBackground = new XamlBackground(line, new System.Xml.XmlDocument());

            var expected = "#FFC04000";
            Assert.AreEqual(expected, xamlBackground.XmlAttribute.Value);
        }

        [TestMethod]
        public void XamlBackgroundColorFromColors()
        {
            var line = "this.BackColor = System.Drawing.Color.Lime;";
            var xamlBackground = new XamlBackground(line, new System.Xml.XmlDocument());
            var expected = "#FF00FF00";
            Assert.AreEqual(expected, xamlBackground.XmlAttribute.Value);
        }
    }
}
