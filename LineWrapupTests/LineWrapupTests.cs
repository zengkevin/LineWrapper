using Microsoft.VisualStudio.TestTools.UnitTesting;
using LineWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineWrapper.Tests
{
    [TestClass()]
    public class LineWrapupTests
    {
        [TestMethod()]
        public void WrapupTest()
        {
            string inputSting = "The quick brown fox jumped over the lazy dog.";
            string expectedResult = "The quick brown\nfox jumped over\nthe lazy dog.";
            LineWrapup lineWrapup = new LineWrapup();
            string outputString = lineWrapup.Wrapup(inputSting, 15);
            Assert.AreEqual(expectedResult, outputString, true, "Wrapup result is not as expected!");
        }
    }
}