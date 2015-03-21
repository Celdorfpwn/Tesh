using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlRadioButtonTest
    {
        [TestMethod]
        public void XamlRadioButtonProcessedIsTrue()
        {
            var controlName = "radioButton2";
            var controlType = "System.Windows.Forms.RadioButton ";

            var xamlRadioButton = new XamlRadioButton(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlRadioButton.Processed);
            Assert.IsNotNull(xamlRadioButton.XmlNode);
        }

        [TestMethod]
        public void XamlRadioButtonProcessedIsFalse()
        {
            var controlName = "button1";
            var controlType = "System.Windows.Forms.Button ";

            var xamlRadioButton = new XamlRadioButton(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);
        }

        [TestMethod]
        public void XamlRadioButtonHasAttributes()
        {
            var controlName = "radioButton2";
            var controlType = "System.Windows.Forms.RadioButton ";

            var xamlRadioButton = new XamlRadioButton(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            var expected = 7;
            var actual = xamlRadioButton.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
