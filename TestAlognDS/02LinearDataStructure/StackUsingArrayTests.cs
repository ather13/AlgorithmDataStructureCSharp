using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class StackUsingArrayTests
    {
        [TestMethod]
        public void VerifyPushInStack()
        {
            var actual = new StackUsingArray(3);
            actual.Push(12);
            actual.Push(14);
            actual.Push(16);

            Assert.AreEqual(3, actual.Count());
        }

        [TestMethod]
        public void VerifyPopInStack()
        {
            var actual = new StackUsingArray(3);
            actual.Push(12);
            actual.Push(14);
            actual.Push(16);

            Assert.AreEqual(3, actual.Count());

            var value = actual.Pop();
            Assert.AreEqual(16, value);
            Assert.AreEqual(2, actual.Count());

            value = actual.Pop();
            Assert.AreEqual(14, value);
            Assert.AreEqual(1, actual.Count());

            value = actual.Pop();
            Assert.AreEqual(12, value);
            Assert.AreEqual(0, actual.Count());
        }

        [TestMethod]
        public void VerifyPeekInStack()
        {
            var actual = new StackUsingArray(3);
            actual.Push(12);
            actual.Push(14);
            actual.Push(16);

            Assert.AreEqual(3, actual.Count());

            var value = actual.Peek();
            Assert.AreEqual(16, value);
            Assert.AreEqual(3, actual.Count());
        }
    }
}
