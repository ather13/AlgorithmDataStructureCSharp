using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlognDS
{
    [TestClass]
    public class SinglyLinkedListTests
    {
        [TestMethod]
        public void CreateLinkedList()
        {
            var actual = new SinglyLinkedList();
            actual.Add(11);
            actual.Add(13);
            actual.Add(15);

            Assert.AreEqual(3,actual.Count());
        }

        [TestMethod]
        public void CountLinkedList()
        {
            var actual = new SinglyLinkedList();
            actual.Add(11);
            actual.Add(13);
            actual.Add(15);

            Assert.AreEqual(3, actual.Count());
        }

        [TestMethod]
        public void FindLinkedList()
        {
            var actual = new SinglyLinkedList();
            actual.Add(11);
            actual.Add(13);
            actual.Add(15);

            Assert.AreEqual(13, actual.Find(13).Data);
        }

        [TestMethod]
        public void DeleteLinkedList()
        {
            var actual = new SinglyLinkedList();
            actual.Add(11);
            actual.Add(13);
            actual.Add(15);

            Assert.AreEqual(13, actual.Find(13).Data);

            var result = actual.Delete(13);

            Assert.IsTrue(result);
            Assert.IsNull(actual.Find(13));
            Assert.AreEqual(11, actual.Find(11).Data);
            Assert.AreEqual(15, actual.Find(15).Data);
        }

        [TestMethod]
        public void DeleteHeadLinkedList()
        {
            var actual = new SinglyLinkedList();
            actual.Add(11);
            actual.Add(13);
            actual.Add(15);

            Assert.AreEqual(11, actual.Find(11).Data);

            var result = actual.Delete(11);

            Assert.IsTrue(result);
            Assert.IsNull(actual.Find(11));
            Assert.AreEqual(13, actual.Find(13).Data);
        }

        [TestMethod]
        public void DeleteLastNodeLinkedList()
        {
            var actual = new SinglyLinkedList();
            actual.Add(11);
            actual.Add(13);
            actual.Add(15);

            Assert.AreEqual(15, actual.Find(15).Data);

            var result = actual.Delete(15);

            Assert.IsTrue(result);
            Assert.IsNull(actual.Find(15));
            Assert.AreEqual(13, actual.Find(13).Data);
        }

        [TestMethod]
        public void NotFondLinkedList()
        {
            var actual = new SinglyLinkedList();
            actual.Add(11);
            actual.Add(13);
            actual.Add(15);

            Assert.IsNull( actual.Find(17));
        }
    }
}
