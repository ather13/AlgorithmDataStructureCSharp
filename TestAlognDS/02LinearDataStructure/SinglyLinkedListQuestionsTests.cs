using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlognDS
{
    [TestClass]
    public class SinglyLinkedListQuestionsTests
    {
        [TestMethod]
        public void VerifySumMergeOtherHalf()
        {
            var actual = new SinglyLinkedListQuestions();
            actual.Add(2);
            actual.Add(3);
            actual.Add(4);
            actual.Add(5);
            actual.Add(6);
            //actual.Add(7);

            actual.SumMergeOtherHalf();
            
            Assert.AreEqual(7, actual.GetData(0) + actual.GetData(4)); 
        }
    }
}
