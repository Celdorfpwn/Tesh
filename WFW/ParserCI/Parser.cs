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

            ParserCI(actualPath, expectedPath, contentPath);
        }

        [TestMethod]
        public void Win2Wpf_CI002()
        {
            var actualPath = "../Debug/Files/002/actual002.txt";
            var expectedPath = "../Debug/Files/002/expected002.txt";
            var contentPath = "../Debug/Files/002/content002.txt";

            ParserCI(actualPath, expectedPath, contentPath);
        }

        [TestMethod]
        public void Win2Wpf_CI003()
        {
            var actualPath = "../Debug/Files/003/actual003.txt";
            var expectedPath = "../Debug/Files/003/expected003.txt";
            var contentPath = "../Debug/Files/003/content003.txt";

            ParserCI(actualPath, expectedPath, contentPath);
        }

        [TestMethod]
        public void Win2Wpf_CI004()
        {
            var actualPath = "../Debug/Files/004/actual004.txt";
            var expectedPath = "../Debug/Files/004/expected004.txt";
            var contentPath = "../Debug/Files/004/content004.txt";

            ParserCI(actualPath, expectedPath, contentPath);
        }


        private void ParserCI(string actualPath, string expectedPath, string contentPath)
        {
            Wpf.Win2Wpf(contentPath, actualPath);

            var actual = File.ReadAllLines(actualPath);
            var expected = File.ReadAllLines(expectedPath);


            var count = actual.Count();

            for (int index = 0; index < count; index++)
            {
                Assert.AreEqual(expected[index], actual[index]);
            }

            File.WriteAllText(actualPath, String.Empty);
        }


    }
}
