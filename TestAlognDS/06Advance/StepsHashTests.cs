using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class StepsHashTests
    {
        [TestMethod]
        public void SmallSteps()
        {
            var expected = "#  \n## \n###";
            var actual = (new StepsHash()).GetStepString(3);

            Assert.AreEqual(expected, actual);

        }
    }
}
