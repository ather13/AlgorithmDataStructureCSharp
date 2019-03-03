using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class FizzBuzzTests
    {

        [TestMethod]
        public void TestFizzBuzzZequentialTill5()
        {
            int[] fizzBuzz = new int[] { 1, 2, 3, 4, 5};
            string[] expected = new string[] { "1", "2", "Fizz", "4", "Buzz" };

            var actual = (new FizzBuzz()).GetFizzBuzz(fizzBuzz);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFizzBuzzZequentialTill15()
        {
            int[] fizzBuzz = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string[] expected = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8"
                , "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            var actual = (new FizzBuzz()).GetFizzBuzz(fizzBuzz);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestFizzBuzzZequentialTill30()
        {
            int[] fizzBuzz = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
                , 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            string[] expected = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8"
                , "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz","16", "17", "Fizz", "19"
                , "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz" };

            var actual = (new FizzBuzz()).GetFizzBuzz(fizzBuzz);

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
