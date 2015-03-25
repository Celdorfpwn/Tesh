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
        public void Win2Wpf_CI001()
        {
            var actualPath = "../Debug/Files/001/actual001.txt";
            var expectedPath = "../Debug/Files/001/expected001.txt";
            var contentPath = "../Debug/Files/001/content001.txt";

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
