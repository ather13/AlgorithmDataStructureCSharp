using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class RunLengthEncodingDecodingTests
    {
        [TestMethod]
        public void EncodeTest0()
        {
            var actual = new RunLengthEncodingDecoding().Encode("w");

            Assert.AreEqual("w1", actual);
        }

        [TestMethod]
        public void EncodeTest1()
        {
            var actual = new RunLengthEncodingDecoding().Encode("wwwwaaadexxxxxx");

            Assert.AreEqual("w4a3d1e1x6", actual);
        }

        [TestMethod]
        public void EncodeTest2()
        {
            var actual = new RunLengthEncodingDecoding().Encode("wwwwaaadexxxxxxywww");

            Assert.AreEqual("w4a3d1e1x6y1w3", actual);
        }

        [TestMethod]
        public void DecodeTest0()
        {
            var actual = new RunLengthEncodingDecoding().Decode("w1");

            Assert.AreEqual("w", actual);
        }

        [TestMethod]
        public void DecodeTest1()
        {
            var actual = new RunLengthEncodingDecoding().Decode("w4a3d1e1x6");

            Assert.AreEqual("wwwwaaadexxxxxx", actual);
        }
    }
}
