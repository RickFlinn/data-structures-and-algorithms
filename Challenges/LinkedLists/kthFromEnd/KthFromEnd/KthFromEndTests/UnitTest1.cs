using System;
using Xunit;
using KthFromEndChallenge;
using LinkedListChallenge.Classes;

namespace KthFromEndTests
{
    public class UnitTest1
    {
        [Fact]
        public void NegKThrows()
        {
            LinkedList nuList = new LinkedList();
            int[] arr1 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            foreach (int val in arr1)
            {
                nuList.Insert(val);
            }

            Assert.ThrowsAny<ArgumentOutOfRangeException>(()=> nuList.KthFromEnd(-1));
        }

        [Fact]
        public void TooBigKThrows()
        {
            LinkedList nuList = new LinkedList();
            int[] arr1 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            foreach (int val in arr1)
            {
                nuList.Insert(val);
            }
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => nuList.KthFromEnd(20));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(8, 8)]
        [InlineData(9, 9)]
        public void CorrectKthValueFromEnd(int k, int correctVal)
        {
            LinkedList nuList = new LinkedList();
            int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int val in arr1)
            {
                nuList.Insert(val);
            }
            Assert.Equal(correctVal, nuList.KthFromEnd(k));
        }

    }
}
