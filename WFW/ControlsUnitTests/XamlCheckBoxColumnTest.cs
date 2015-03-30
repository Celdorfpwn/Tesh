using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlCheckBoxColumnTest
    {
        [TestMethod]
        public void XamlCheckBoxColumnProcessedIsTrue()
        {
            var controlName = "TaxExempt";
            var controlType = "System.Windows.Forms.DataGridViewCheckBoxColumn ";

            var XamlCheckBoxColumn = new XamlCheckBoxColumn(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(XamlCheckBoxColumn.Processed);

            Assert.IsNotNull(XamlCheckBoxColumn.XmlNode);
        }

        [TestMethod]
        public void XamlCheckBoxColumnProcessedIsFalse()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var XamlCheckBoxColumn = new XamlCheckBoxColumn(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(XamlCheckBoxColumn.Processed);

            Assert.IsNull(XamlCheckBoxColumn.XmlNode);
        }

        [TestMethod]
        public void XamlCheckBoxColumnHasAttributes()
        {
            var controlName = "TaxExempt";
            var controlType = "System.Windows.Forms.DataGridViewCheckBoxColumn ";

            var XamlCheckBoxColumn = new XamlCheckBoxColumn(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsNotNull(XamlCheckBoxColumn.XmlNode);
            Assert.AreEqual(2, XamlCheckBoxColumn.XmlNode.Attributes.Count);
        }
    }
}
