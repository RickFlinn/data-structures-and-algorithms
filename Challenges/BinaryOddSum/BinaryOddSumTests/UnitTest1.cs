using BinaryOddSum;
using System;
using Trees.Classes;
using Xunit;

namespace BinaryOddSumTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 4, 2, 3, 1, 5, 6 }, 9)]
        [InlineData(new int[] { 1, 4, 8, 9, 2, 3, 11}, 24)]
        [InlineData(new int[] { 1337 }, 1337)]
        public void GetsSum(int[] values, int expectedSum)
        {
            BinarySearchTree tree = new BinarySearchTree();
            foreach(int val in values)
            {
                tree.Add(val);
            }
            Assert.Equal(expectedSum, Program.BinaryOddSum(tree));
        }

        [Theory]
        [InlineData(new int[] { 6, 8, 4, 2})]
        [InlineData(new int[] { 14 })]
        public void AllEvensReturnsZero(int[] values)
        {
            BinarySearchTree tree = new BinarySearchTree();
            foreach (int val in values)
            {
                tree.Add(val);
            }
            Assert.Equal(0, Program.BinaryOddSum(tree));

        }

        [Fact]
        public void EmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Equal(0, Program.BinaryOddSum(tree));
        }
        [Fact]
        public void NullTree()
        {
            Assert.Throws<NullReferenceException>(() => Program.BinaryOddSum(null));
        }

        [Theory]
        [InlineData(new int[] { 4, 2, 3, 1, 5, 6 }, 9)]
        [InlineData(new int[] { 1, 4, 8, 9, 2, 3, 11 }, 24)]
        [InlineData(new int[] { 1337 }, 1337)]
        public void GetsSumDFS(int[] values, int expectedSum)
        {
            BinarySearchTree tree = new BinarySearchTree();
            foreach (int val in values)
            {
                tree.Add(val);
            }
            Assert.Equal(expectedSum, Program.BinaryOddSumDFS(tree));
        }

        [Theory]
        [InlineData(new int[] { 6, 8, 4, 2 })]
        [InlineData(new int[] { 14 })]
        public void AllEvensReturnsZeroDFS(int[] values)
        {
            BinarySearchTree tree = new BinarySearchTree();
            foreach (int val in values)
            {
                tree.Add(val);
            }
            Assert.Equal(0, Program.BinaryOddSumDFS(tree));

        }

        [Fact]
        public void EmptyTreeDFS()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Equal(0, Program.BinaryOddSumDFS(tree));
        }
        [Fact]
        public void NullTreeDFS()
        {
            Assert.Throws<NullReferenceException>(() => Program.BinaryOddSumDFS(null));
        }

    }
}
