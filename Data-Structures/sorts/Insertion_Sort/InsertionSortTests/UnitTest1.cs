using System;
using Xunit;
using Insertion_Sort;

namespace InsertionSortTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(20)]
        public void SortsRandom(int arrSize)
        {
            int[] randomArr = new int[arrSize];
            Random rand = new Random();
            for (int i = 0; i < arrSize; i++)
            {
                randomArr[i] = rand.Next(100);
            }

            bool sorted = true;
            Program.InsertionSort(randomArr);
            for(int i = 0; i < arrSize - 1; i++)
            {
                if (randomArr[i] > randomArr[i + 1])
                    sorted = false;
            }
            Assert.True(sorted);
        }

        [Fact]
        public void LeavesSortedAlone()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] original = { 1, 2, 3, 4, 5 };
            Assert.Equal(original, Program.InsertionSort(arr));
        }

        [Fact]
        public void SortsBackwardArray()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };
            Assert.Equal(expected, Program.InsertionSort(arr));
        }

        [Fact]
        public void EmptySortedIsEmpty()
        {
            int[] arr = { };
            int[] expected = { };
            Assert.Equal(expected, Program.InsertionSort(arr));
        }

        [Fact]
        public void SortsOneItem()
        {
            int[] arr = { 1 };
            int[] expected = { 1 };
            Assert.Equal(expected, Program.InsertionSort(arr));
        }
    }
}
