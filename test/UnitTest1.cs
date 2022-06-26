using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("testing work")]
        public void test_work()
        {
            Assert.AreEqual(true, true);
        }

    }
}