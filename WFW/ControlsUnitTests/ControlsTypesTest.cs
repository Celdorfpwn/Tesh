using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamlControls;
using System.Linq;
using System.Collections.Generic;
namespace ControlsUnitTests
{
    [TestClass]
    public class ControlsTypesTest
    {
        [TestMethod]
        public void CanGetTypesToCount()
        {

            var expected = 7;

            var actual = ControlsTypes.AssemblyTypes.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanGetAttributesTypesInTheAssembly()
        {
            var expected = new List<Type>
            {
                typeof(XamlButton),typeof(XamlCheckBox),typeof(XamlComboBox),
                typeof(XamlDatePicker),typeof(XamlLabel),typeof(XamlRadioButton),
                typeof(XamlTextBox)
            };

            var actual = ControlsTypes.AssemblyTypes;

            Assert.AreEqual(expected.Count, actual.Count());

            foreach (var type in actual)
            {
                Assert.IsTrue(expected.Contains(type));
            }
        }
    }
}
