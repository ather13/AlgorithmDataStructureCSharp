using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class StreamProcessingTests
    {
        [TestMethod]
        public void StreamProcessTests1()
        {
            var actual = new StreamProcessing().FindTotalScore("{}");

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void StreamProcessTests2()
        {
            var actual = new StreamProcessing().FindTotalScore("{{{}}}");

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void StreamProcessTests3()
        {
            var actual = new StreamProcessing().FindTotalScore("{{},{}}");

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void StreamProcessTests4()
        {
            var actual = new StreamProcessing().FindTotalScore("{{{},{},{{}}}}");

            Assert.AreEqual(16, actual);
        }

        [TestMethod]
        public void StreamProcessTests5()
        {
            var actual = new StreamProcessing().FindTotalScore("{<a>,<a>,<a>,<a>}");

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void StreamProcessTests6()
        {
            var actual = new StreamProcessing().FindTotalScore("{{<ab>},{<ab>},{<ab>},{<ab>}}");

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void StreamProcessTests7()
        {
            var actual = new StreamProcessing().FindTotalScore("{{<!!>},{<!!>},{<!!>},{<!!>}}");

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void StreamProcessTests8()
        {
            var actual = new StreamProcessing().FindTotalScore("{{<a!>},{<a!>},{<a!>},{<ab>}}");

            Assert.AreEqual(3, actual);
        }
    }
}
