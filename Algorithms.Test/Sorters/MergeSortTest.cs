using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sorters;
using Xunit;

namespace Algorithms.Test.Sorters
{
    public class MergeSortTest
    {
        [Fact]
        public static void IntTest()
        {
            var list = new List<int>() { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            int[] sortedList = { 0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 46, 55 };
            List<int> result = list.MergeSort();
            Assert.True(result.SequenceEqual(sortedList));
        }
        [Fact]
        public static void StringTest()
        {
            var list = new List<char>() { 'c', 'b', 'a', 'd' };
            char[] sortedList = { 'a', 'b', 'c', 'd' };
            List<char> result = list.MergeSort();
            Assert.True(result.SequenceEqual(sortedList));
        }
        [Fact]
        public static void TwoElementTest()
        {
            var list = new List<int>() { 1, 0 };
            int[] sortedList = { 0, 1 };
            List<int> result = list.MergeSort();
            Assert.True(result.SequenceEqual(sortedList));
        }
        [Fact]
        public static void OneElementTest()
        {
            var list = new List<int>() { 23 };
            int[] sortedList = { 23 };
            List<int> result = list.MergeSort();
            Assert.True(result.SequenceEqual(sortedList));
        }
    }
}
