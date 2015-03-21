using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlGridRowTest
    {
        [TestMethod]
        public void XamlGridRowProcessedIsTrue()
        {
            var line = "this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);";
            var xmlDocument = new XmlDocument();

            var xamlGridRow = new XamlGridRow(line, xmlDocument);

            Assert.IsTrue(xamlGridRow.Processed);
            Assert.IsNotNull(xamlGridRow.XmlAttribute);
        }


        [TestMethod]
        public void XamlGridRowProcessedIsFalse()
        {
            var line = "this.button1.Location = new System.Drawing.Point(3, 3);";
            var xmlDocument = new XmlDocument();

            var xamlGridRow = new XamlGridRow(line,xmlDocument);

            Assert.IsFalse(xamlGridRow.Processed);

            Assert.IsNull(xamlGridRow.XmlAttribute);
        }

        [TestMethod]
        public void XamlGridRowHasTheRightValue()
        {
            var line = "this.tableLayoutPanel1.Controls.Add(this.button1, 0, 15);";
            var xmlDocument = new XmlDocument();

            var xamlGridRow = new XamlGridRow(line, xmlDocument);

            var actual = xamlGridRow.XmlAttribute.Value;
            var expected = "15";
            Assert.AreEqual(expected, actual);
        }
    }
}
