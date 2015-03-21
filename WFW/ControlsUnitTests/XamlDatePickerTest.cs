using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlDatePickerTest
    {
        [TestMethod]
        public void XamlDatePickerProcessedIsTrue()
        {
            var controlName = "dateTimePicker3";
            var controlType = "System.Windows.Forms.DateTimePicker ";

            var xamlDatePicker = new XamlDatePicker(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);


            Assert.IsTrue(xamlDatePicker.Processed);
            Assert.IsNotNull(xamlDatePicker.XmlNode);
        }

        [TestMethod]
        public void XamlDatePickerProcessedIsFalse()
        {
            var controlName = "button1";
            var controlType = "System.Windows.Forms.Button ";

            var xamlDatePicker = new XamlDatePicker(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlDatePicker.Processed);
            Assert.IsNull(xamlDatePicker.XmlNode);
        }

        [TestMethod]
        public void XamlDatePickerHasAttributes()
        {
            var controlName = "dateTimePicker3";
            var controlType = "System.Windows.Forms.DateTimePicker ";

            var xamlDatePicker = new XamlDatePicker(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            var expected = 7;
            var actual = xamlDatePicker.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }



    }
}
