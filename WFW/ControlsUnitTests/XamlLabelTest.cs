using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlLabelTest
    {
        [TestMethod]
        public void XamlLabelProcessedIsTrue()
        {
            var controlName = "label4";
            var controlType = "System.Windows.Forms.Label ";

            var xamlLabel = new XamlLabel(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlLabel.Processed);
            Assert.IsNotNull(xamlLabel.XmlNode);
        }

        [TestMethod]
        public void XamlLabelProcessedIsFalse()
        {
            var controlName = "button4";
            var controlType = "System.Windows.Forms.Button ";

            var xamlLabel = new XamlLabel(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlLabel.Processed);
            Assert.IsNull(xamlLabel.XmlNode);
        }


        [TestMethod]
        public void XamlLabelHasAttributes()
        {
            var controlName = "label4";
            var controlType = "System.Windows.Forms.Label ";

            var xamlLabel = new XamlLabel(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            var expected = 8;
            var actual = xamlLabel.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }

    }
}
