using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlButtonTest
    {
        [TestMethod]
        public void XamlButtonProcessedIsTrue()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var xamlButton = new XamlButton(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlButton.Processed);

            Assert.IsNotNull(xamlButton.XmlNode);
        }

        [TestMethod]
        public void XamlButtonProcessedIsFalse()
        {
            var controlName = "textBox5";
            var controlType = "System.Windows.Forms.TextBox ";

            var xamlButton = new XamlButton(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlButton.Processed);

            Assert.IsNull(xamlButton.XmlNode);
        }

        [TestMethod]
        public void XamlButtonHasAttributes()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var xamlButton = new XamlButton(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            var expected = 8;

            var actual = xamlButton.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }

    }
}
