using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class ConversionsTests
    {
        [TestMethod]
        public void DecimalToBinaryTests()
        {
            var expected = new Conversions().BCL_DecimalToBinary(5);
            var actual = new Conversions().DecimalToBinary(5);

            Assert.AreEqual(expected, actual);
        }
    }
}
