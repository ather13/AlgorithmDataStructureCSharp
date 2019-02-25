using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class StarPyramidTests
    {
        [TestMethod]
        public void VerifyPyramidOne()
        {
            var expected = "#";
            var actual = (new StarPyramid()).GetPyramid(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyPyramidThree()
        {
            var expected = "  #  \n ### \n#####";
            var actual = (new StarPyramid()).GetPyramid(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyPyramidFive()
        {
            var expected = "    #    \n" +
                            "   ###   \n" +
                            "  #####  \n" +
                            " ####### \n" +
                            "#########";
            var actual = (new StarPyramid()).GetPyramid(5);

            Assert.AreEqual(expected, actual);
        }
    }
}
