using AlgonDS.LinearDataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class QueueUsingArrayTests
    {
        [TestMethod]
        public void VerifyPushInQueue()
        {
            var actual = new QueueUsingArray(3);
            actual.Enqueue(12);
            actual.Enqueue(14);
            actual.Enqueue(16);

            Assert.AreEqual(3, actual.Count());
        }

        [TestMethod]
        public void VerifyPopInQueue()
        {
            var actual = new QueueUsingArray(3);
            actual.Enqueue(12);
            actual.Enqueue(14);
            actual.Enqueue(16);

            Assert.AreEqual(3, actual.Count());

            var value = actual.Dequeue();
            Assert.AreEqual(12, value);
            Assert.AreEqual(2, actual.Count());

            value = actual.Dequeue();
            Assert.AreEqual(14, value);
            Assert.AreEqual(1, actual.Count());

            value = actual.Dequeue();
            Assert.AreEqual(16, value);
            Assert.AreEqual(0, actual.Count());
        }

        [TestMethod]
        public void VerifyPeekInQueue()
        {
            var actual = new QueueUsingArray(3);
            actual.Enqueue(12);
            actual.Enqueue(14);
            actual.Enqueue(16);

            Assert.AreEqual(3, actual.Count());

            var value = actual.Peek();
            Assert.AreEqual(12, value);
            Assert.AreEqual(3, actual.Count());
        }
    }
}
