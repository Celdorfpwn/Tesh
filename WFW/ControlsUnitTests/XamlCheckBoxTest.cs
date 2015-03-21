using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Collections.Generic;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlCheckBoxTest
    {
        [TestMethod]
        public void XamlCheckBoxProcessedIsTrue()
        {
            var controlName = "checkBox2";
            var controlType = "System.Windows.Forms.CheckBox ";

            var xamlCheckBox = new XamlCheckBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlCheckBox.Processed);

            Assert.IsNotNull(xamlCheckBox.XmlNode);
        }


        [TestMethod]
        public void XamlCheckBoxProcessedIsFalse()
        {
            var controlName = "button5";        
            var controlType = "System.Windows.Forms.Button ";

            var xamlCheckBox = new XamlCheckBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlCheckBox.Processed);

            Assert.IsNull(xamlCheckBox.XmlNode);
        }

        [TestMethod]
        public void XamlCheckBoxHasAttributes()
        {
            var controlName = "checkBox2";
            var controlType = "System.Windows.Forms.CheckBox ";

            var xamlCheckBox = new XamlCheckBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            var expected = 7;

            var actual = xamlCheckBox.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
