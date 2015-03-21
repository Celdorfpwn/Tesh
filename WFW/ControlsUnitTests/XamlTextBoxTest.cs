using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamlControls;
using System.Xml.Linq;
using System.Xml;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlTextBoxTest
    {
        [TestMethod]
        public void XamlTextBoxProcessedIsTrue()
        {
            var controlName = "textBox6";
            var controlType = "System.Windows.Forms.TextBox ";

            var xamlTextBox = new XamlTextBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlTextBox.Processed);
            Assert.IsNotNull(xamlTextBox.XmlNode);
        }


        [TestMethod]
        public void XamlTextBoxProcessedIsFalse()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var xamlTextBox = new XamlTextBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlTextBox.Processed);
            Assert.IsNull(xamlTextBox.XmlNode);
        }

        [TestMethod]
        public void XamlTextBoxHasAttributes()
        {
            var controlName = "textBox6";
            var controlType = "System.Windows.Forms.TextBox ";

            var xamlTextBox = new XamlTextBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            var expected = 6;
            var actual = xamlTextBox.XmlNode.Attributes.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XamlTextBoxChangesContentInText()
        {
            var controlName = "textBox2";
            var controlType = "System.Windows.Forms.TextBox ";

            var xamlTextBox = new XamlTextBox(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            object textAttribute = null;
            foreach(XmlAttribute attribute in xamlTextBox.XmlNode.Attributes)
            {
                if(attribute.Name.Equals("Text"))
                {
                    textAttribute = attribute;
                    break;
                }
            }

            Assert.IsNotNull(textAttribute);

        }
    }
}
