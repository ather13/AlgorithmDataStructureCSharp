using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class MiddleOfGivenLinkedListTests
    {

        /// <summary>
        /// Given a singly linked list, find middle of the linked list. 
        /// For example, if given linked list is 1->2->3->4->5 then output should be 3.
        /// If there are even nodes, then there would be two middle nodes, we need to print second middle element.
        /// For example, if given linked list is 1->2->3->4->5->6 then output should be 4.
        /// </summary>
        [TestMethod]
        public void VerifyInEvenElements()
        {
            var list = new MiddleOfGivenLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            var actual = list.GetMiddleItem();

            Assert.AreEqual(4,actual);
        }

        [TestMethod]
        public void VerifyInOddElements()
        {
            var list = new MiddleOfGivenLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            var actual = list.GetMiddleItem();

            Assert.AreEqual(3, actual);
        }
    }
}
