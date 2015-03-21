using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Attributes;
using System.Linq;
using System.Collections.Generic;

namespace AttributesUnitTests
{
    [TestClass]
    public class AttributesTypesTest
    {
        [TestMethod]
        public void CanGetTypesToCount()
        {

            var expected = 10;

            var actual = AttributesTypes.AssemblyTypes.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanGetAttributesTypesInTheAssembly()
        {
            var expected = new List<Type>
            {
                typeof(XamlCanvasLeft),typeof(XamlCanvasTop),typeof(XamlClick),
                typeof(XamlContent),typeof(XamlHeight),typeof(XamlName),
                typeof(XamlTabIndex),typeof(XamlWidth),typeof(XamlGridColumn),
                typeof(XamlGridRow)
            };

            var actual = AttributesTypes.AssemblyTypes;

            Assert.AreEqual(expected.Count, actual.Count());

            foreach(var type in actual)
            {
                Assert.IsTrue(expected.Contains(type));
            }
        }
    }
}
