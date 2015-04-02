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

            var expected = 18;

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
                typeof(XamlGridRow),typeof(XamlForeground),typeof(XamlBackground),
                typeof(XamlHeader),typeof(XamlFontSize),typeof(XamlFontFamily),
                typeof(XamlFontStyle),typeof(XamlFontWeight),typeof(XamlTextDecorations)
            };

            var actual = AttributesTypes.AssemblyTypes;

            foreach(var type in actual)
            {
                try
                {
                    Assert.IsTrue(expected.Contains(type));
                }
                catch(Exception)
                {
                    Assert.Fail("Xaml Attribute " + type.Name + " not found in expected list!");
                }
            }
        }
    }
}
