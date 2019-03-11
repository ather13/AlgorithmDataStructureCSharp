using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class LCMRelatedTests
    {
        [TestMethod]
        public void LCMForTwoNumber()
        {
            var actual = new LCMRelated().LCMForTwoNumbers(10, 15);

            //10=5X2
            //15=5X3
            //5X3X2=30
            Assert.AreEqual(30, actual);
        }
    }
}
