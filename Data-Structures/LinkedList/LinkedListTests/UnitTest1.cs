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
                nuList.PrintListValues();
                Assert.True(true);
            } catch
            {
                Assert.True(false);
            }
            
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, -1)]
        public void InsertAfterNull(int key, int value)
        {
            LinkedList nuList = new LinkedList();
            Assert.Throws<Exception>(()=> nuList.InsertAfter(key, value));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, -1)]
        public void InsertBeforeNull(int key, int value)
        {

            LinkedList nuList = new LinkedList();
            Assert.Throws<Exception>(() => nuList.InsertBefore(key, value));
        }

        [Fact]
        public void AppendToNullList()
        {
            LinkedList nuList = new LinkedList();
            nuList.Append(1);
            Assert.Equal(1, nuList.Head.IntVal);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 1}, 4)]
        [InlineData(new int[] { 1 }, 2 )]
        [InlineData(new int[] { }, 1)]
        public void Appends(int[] listVals, int val)
        {
            LinkedList nuList = new LinkedList();
            foreach (int item in listVals)
            {
                nuList.Insert(item);
            }
            nuList.Append(val);
            Assert.True(nuList.Includes(val));
        }

        [Theory]
        [InlineData(new int[] { 4, 2, 1 }, 3, 4, 2)]
        [InlineData(new int[] { 4, 3, 1 }, 2, 3, 1)]
        [InlineData(new int[] {2}, 1, 2, 0)]
        public void InsertsBefore(int[] listVals, int val, int key, int expectedIndex)
        {
            LinkedList nuList = new LinkedList();
            foreach (int item in listVals)
            {
                nuList.Insert(item);
            }

            nuList.InsertBefore(key, val);
            nuList.Current = nuList.Head;
            for (int i = 0; i < expectedIndex; i++)
            {
                nuList.Current = nuList.Current.Next;
            }
            Assert.Equal(nuList.Current.IntVal, val);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, 4, 3, 3)]
        [InlineData(new int[] { 4, 2, 1 }, 3, 2, 2)]
        [InlineData(new int[] { 4, 3, 1 }, 2, 1, 1)]
        [InlineData(new int[] { 1 }, 2, 1, 1)]
        public void InsertsAfter(int[] listVals, int val, int key, int expectedIndex)
        {
            LinkedList nuList = new LinkedList();
            foreach (int item in listVals)
            {
                nuList.Insert(item);
            }
            nuList.InsertAfter(key, val);
            nuList.Current = nuList.Head;
            for (int i = 0; i < expectedIndex; i++)
            {
                nuList.Current = nuList.Current.Next;
            }
            Assert.Equal(nuList.Current.IntVal, val);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, 4)]
        [InlineData(new int[] { 3, 1 }, 2)]
        [InlineData(new int[] {2}, 1)]
        public void InsertAfterBadKey(int[] listVals, int key)
        {
            LinkedList nuList = new LinkedList();
            foreach(int item in listVals)
            {
                nuList.Insert(item);
            }
            Assert.Throws<ArgumentOutOfRangeException>(() => nuList.InsertAfter(key, 5));
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, 4)]
        [InlineData(new int[] { 3, 1 }, 2)]
        [InlineData(new int[] {2}, 1)]
        public void InsertBeforeBadKey(int[] listVals, int key)
        {
            LinkedList nuList = new LinkedList();
            foreach (int item in listVals)
            {
                nuList.Insert(item);
            }
            Assert.Throws<ArgumentOutOfRangeException>(() => nuList.InsertBefore(key, 5));
        }
    }
}
