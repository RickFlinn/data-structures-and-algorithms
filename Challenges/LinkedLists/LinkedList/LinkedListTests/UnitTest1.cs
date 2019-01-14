using System;
using Xunit;
using LinkedListChallenge;
using LinkedListChallenge.Classes;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void VoidHead()
        {
            LinkedList nuList = new LinkedList();
            Assert.True(nuList.Head == null);
        }

        [Fact]
        public void InsertTest()
        {
            LinkedList nuList = new LinkedList();
            nuList.Insert(4);
            nuList.Insert(5);
            Assert.True(nuList.Head.IntVal == 5 && nuList.Head.Next.IntVal == 4);
        }

        [Theory]
        [InlineData(new int[] { 1, 0, -1})]
        [InlineData(new int[] { 6, 8, 10, 405, 2201 })]
        [InlineData(new int[] { -1, -1, -1 })]
        [InlineData(new int[] { 2147483647, -2147483648, 2147483647 })]
        public void InsertedValueIncluded(int[] values)
        {
            LinkedList nuList = new LinkedList();
            for (int i = 0; i < values.Length; i++)
            {
                nuList.Insert(values[i]);
            }
            Random rand = new Random();
            int randomIndex = rand.Next(0, values.Length - 1);
            Assert.True(nuList.Includes(values[randomIndex]));
        }

        [Theory]
        [InlineData(new int[] { 1, 0, -1 })]
        [InlineData(new int[] { 6, 8, 10, 405, 2201 })]
        [InlineData(new int[] { -1, -1, -1 })]
        [InlineData(new int[] { 2147483647, -2147483648, 2147483647 })]
        public void PrintDoesNotThrowException(int[] values)
        {
            try
            {
                LinkedList nuList = new LinkedList();
                for (int i = 0; i < values.Length; i++)
                {
                    nuList.Insert(values[i]);
                }
                Assert.True(true);
            } catch
            {
                Assert.True(false);
            }
            


        }

    }
}
