using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        private readonly Tuple<string,int>[] Test =
        {
            new Tuple<string, int>("()",0),
            new Tuple<string, int>("())",3),
            new Tuple<string, int>("([)",3),
            new Tuple<string, int>("(()",-1),
            new Tuple<string, int>("({[])",5),
            new Tuple<string, int>("({)}",3),
            new Tuple<string, int>("({}[])",0),

        };

        [TestMethod]
        public void TestBracketParser()
        {
            var fTask = new FBracketParser();
            foreach (var testData in Test)
            {
                Assert.AreEqual(fTask.CheckBrackets(testData.Item1), testData.Item2);
            }
        }
    }
}
