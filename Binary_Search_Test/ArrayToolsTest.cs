using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Binary_Search;

namespace Binary_Search_Test
{
    [TestClass]
    public class ArrayToolsTest
    {
        [TestMethod]
        public void TestBinarySearchR()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }
            int idx = ArrayTools.BinarySearchR(arr, 78,0,arr.Length);

            Assert.AreEqual(77,idx);
        }
        [TestMethod]
        public void TestBinarySearchI()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }
            int idx = ArrayTools.BinarySearchI(arr, 78);

            Assert.AreEqual(77,idx);
        }
        [TestMethod]
        public void TestLinearSearchR()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }
            int idx = ArrayTools.LinearSearchR(arr, 78,0);

            Assert.AreEqual(77,idx);
        }
        [TestMethod]
        public void TestLinearSearchI()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }
            int idx = ArrayTools.LinearSearchI(arr, 78);

            Assert.AreEqual(77,idx);
        }
    }
}
