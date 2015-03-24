using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfParser;
using System.IO;
using System.Linq;

namespace ParserCI
{
    [TestClass]
    public class Parser
    {
        [TestMethod]
        public void Win2Wpf_CI()
        {
            var actualPath = "../Debug/actual.xaml";
            var expectedPath = "../Debug/expected.xaml";
            var contentPath = "../Debug/content.cs";

            Wpf.Win2Wpf(contentPath, actualPath);

            var actual = File.ReadAllLines(actualPath);
            var expected = File.ReadAllLines(expectedPath);


            var count = actual.Count();

            for(int index = 0;index<count;index++)
            {
                Assert.AreEqual(expected[index], actual[index]);
            }
        }
    }
}
