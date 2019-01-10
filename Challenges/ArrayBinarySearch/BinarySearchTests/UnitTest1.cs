using System;
using Xunit;
using ArrayBinarySearch;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6}, 2)]
        [InlineData(new int[] { 2, 4, 6, 8, 10 }, 5)]
        [InlineData(new int[] { 3, 6, 9, 12, 15, 18, 21 }, 13)]
        public void KeyNotFound(int[] arr1, int key)
        {
            Assert.Equal(-1, Program.BinarySearch(arr1, key));
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 3, 1)]
        [InlineData(new int[] { 2, 4, 6, 8, 10 }, 8, 3)]
        [InlineData(new int[] { 3, 6, 9, 12, 15, 18, 21 }, 12, 3)]
        [InlineData(new int[] { 3, 6, 9, 12, 15, 18, 21 }, 18, 5)]
        [InlineData(new int[] { 3, 6, 9, 12, 15, 18, 21 }, 6, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 1, 0)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 6, 3)]
        public void CanFindKey(int[] arr1, int key, int index)
        {
            Assert.Equal(index, Program.BinarySearch(arr1, key));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 0)]
        [InlineData(new int[] { 1, 2, 3 }, 4)]
        public void KeyOutsideBounds(int[] arr1, int key)
        {
            Assert.Equal(-1, Program.BinarySearch(arr1, key));
        }
    }
}
