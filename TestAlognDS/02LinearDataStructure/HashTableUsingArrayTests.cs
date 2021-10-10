using AlgonDS._02LinearDataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class HashTableUsingArrayTests 
    {
        [TestMethod]
        public void SetupHashTable()
        {
            var hashTable = new HashTableUsingArray(5);
            hashTable["one"] = "one value";
            hashTable["two"] = "two value";

            var actual = hashTable["one"];

            Assert.AreEqual("one value",actual);
        }
    }
}
