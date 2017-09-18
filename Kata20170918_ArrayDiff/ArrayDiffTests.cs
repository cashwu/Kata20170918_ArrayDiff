using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170918_ArrayDiff
{
    [TestClass]
    public class ArrayDiffTests
    {
        [TestMethod]
        public void Input_array_1_and_empty_array_should_return_array_1()
        {
            ArrayDiffShouldBe(new[] { 1 }, new[] { 1 }, new int[] { });
        }

        private static void ArrayDiffShouldBe(int[] expected, int[] a, int[] b)
        {
            var kata = new Kata();
            var actual = kata.ArrayDiff(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int[] ArrayDiff(int[] a, int[] b)
        {
            return a;
        }
    }
}
