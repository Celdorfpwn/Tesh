using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamlControls;

namespace ControlsUnitTests
{
    [TestClass]
    public class XamlTreeViewTest
    {
        [TestMethod]
        public void XamlTreeViewTestProcessedIsTrue()
        {
            var controlName = "treeView1";
            var controlType = "System.Windows.Forms.TreeView ";

            var xamlTreeView = new XamlTreeView(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsTrue(xamlTreeView.Processed);

            Assert.IsNotNull(xamlTreeView.XmlNode);
        }

        [TestMethod]
        public void XamlTreeViewTestProcessedIsFalse()
        {
            var controlName = "button5";
            var controlType = "System.Windows.Forms.Button ";

            var xamlTreeView = new XamlTreeView(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsFalse(xamlTreeView.Processed);

            Assert.IsNull(xamlTreeView.XmlNode);
        }

        [TestMethod]
        public void XamlTreeViewHasAttributes()
        {
            var controlName = "treeView1";
            var controlType = "System.Windows.Forms.TreeView ";

            var xamlTreeView = new XamlTreeView(Mocker.Lines, Mocker.XmlDocument, controlType, controlName);

            Assert.IsNotNull(xamlTreeView.XmlNode);
            Assert.AreEqual(6, xamlTreeView.XmlNode.Attributes.Count);
        }
    }
}
