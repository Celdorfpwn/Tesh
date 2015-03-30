using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlTextBoxColumnTest
    {
        [TestMethod]
        public void XamlTextBoxColumnProcessedIsTrue()
        {
            var controlName = "PartNumber";
            var controlType = "System.Windows.Forms.DataGridViewTextBoxColumn ";

            var xamlTextBoxColumn = new XamlTextBoxColumn(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlTextBoxColumn.Processed);

            Assert.IsNotNull(xamlTextBoxColumn.XmlNode);
        }

        [TestMethod]
        public void XamlTextBoxColumnProcessedIsFalse()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var xamlTextBoxColumn = new XamlTextBoxColumn(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlTextBoxColumn.Processed);

            Assert.IsNull(xamlTextBoxColumn.XmlNode);
        }

        [TestMethod]
        public void XamltextBoxColumnHasAttributes()
        {
            var controlName = "PartNumber";
            var controlType = "System.Windows.Forms.DataGridViewTextBoxColumn ";

            var xamlTextBoxColumn = new XamlTextBoxColumn(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsNotNull(xamlTextBoxColumn.XmlNode);
            Assert.AreEqual(2, xamlTextBoxColumn.XmlNode.Attributes.Count);
        }
    }
}
