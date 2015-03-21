using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Attributes;

namespace AttributesUnitTests
{
    [TestClass]
    public class XamlGridColumnTest
    {
        [TestMethod]
        public void XamlGridColumnProcessedIsTrue()
        {
            var line = "this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);";
            var xmlDocument = new XmlDocument();

            var xamlGridColumn = new XamlGridColumn(line, xmlDocument);

            Assert.IsTrue(xamlGridColumn.Processed);
            Assert.IsNotNull(xamlGridColumn.XmlAttribute);
        }


        [TestMethod]
        public void XamlGridColumnProcessedIsFalse()
        {
            var line = "this.button1.Location = new System.Drawing.Point(3, 3);";
            var xmlDocument = new XmlDocument();

            var xamlGridColumn = new XamlGridColumn(line, xmlDocument);

            Assert.IsFalse(xamlGridColumn.Processed);

            Assert.IsNull(xamlGridColumn.XmlAttribute);
        }

        [TestMethod]
        public void XamlGridColumnHasTheRightValue()
        {
            var line = "this.tableLayoutPanel1.Controls.Add(this.button1, 25, 15);";
            var xmlDocument = new XmlDocument();

            var xamlGridColumn = new XamlGridColumn(line, xmlDocument);

            var actual = xamlGridColumn.XmlAttribute.Value;
            var expected = "25";
            Assert.AreEqual(expected, actual);
        }
    }
}
