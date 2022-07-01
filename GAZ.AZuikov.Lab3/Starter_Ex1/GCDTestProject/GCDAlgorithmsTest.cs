using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreatestCommonDivisor;

namespace GCDTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindGCDEuclidTest()
        {
            int a = 2806;
            int b = 345;
            int expected = 23;

            int actual = GCDAlgorithms.FindGCDEuclid(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
