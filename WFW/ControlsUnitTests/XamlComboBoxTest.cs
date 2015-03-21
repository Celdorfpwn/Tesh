using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlComboBoxTest
    {
        [TestMethod]
        public void XamlComboBoxProcessedIsTrue()
        {
            var controlName = "comboBox1";
            var controlType = "System.Windows.Forms.ComboBox ";

            var xamlComboBox = new XamlComboBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlComboBox.Processed);
            Assert.IsNotNull(xamlComboBox.XmlNode);

        }

        [TestMethod]
        public void XamlComboBoxProcessedIsFalse()
        {
            var controlName = "button1";
            var controlType = "System.Windows.Forms.Button ";

            var xamlComboBox = new XamlComboBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlComboBox.Processed);
            Assert.IsNull(xamlComboBox.XmlNode);
        }


        [TestMethod]
        public void XamlComboBoxHasAttributes()
        {
            var controlName = "comboBox1";
            var controlType = "System.Windows.Forms.ComboBox ";

            var xamlComboBox = new XamlComboBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            var expected = 6;
            var actual = xamlComboBox.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }




    }
}
