using System;
using Trees.Classes;
using Xunit;
using CalcBinaryTreeHeight;

namespace CalcBinaryHeightTests
{



    public class UnitTest1
    {

        [Fact]
        public void NullThrowsHeight()
        {
            Assert.ThrowsAny<NullReferenceException>(() => Program.CalcBinaryTreeHeight(null));
        }

        [Fact]
        public void NullThrowsLevels()
        {
            Assert.ThrowsAny<NullReferenceException>(() => Program.CalcBinaryTreeLevels(null));
        }

        [Fact]
        public void SingleNodeHeight()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(1);
            Assert.Equal(0, Program.CalcBinaryTreeHeight(tree.Root));
        }

        [Fact]
        public void SingleNodeLevels()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(1);
            Assert.Equal(1, Program.CalcBinaryTreeLevels(tree.Root));
        }

        [Fact]
        public void GetsLimbHeight()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            Assert.Equal(3, Program.CalcBinaryTreeHeight(tree.Root));
        }

        [Fact]
        public void GetsLimbLevels()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            Assert.Equal(4, Program.CalcBinaryTreeLevels(tree.Root));
        }

        [Fact]
        public void GetsTreeHeight()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(4);
            tree.Add(2);
            tree.Add(8);
            tree.Add(7);
            tree.Add(6);
            tree.Add(1);
            tree.Add(9);
            Assert.Equal(3, Program.CalcBinaryTreeHeight(tree.Root));
        }

        [Fact]
        public void GetsCorrectLevel()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(4);
            tree.Add(2);
            tree.Add(8);
            tree.Add(7);
            tree.Add(6);
            tree.Add(1);
            tree.Add(9);
            Assert.Equal(4, Program.CalcBinaryTreeLevels(tree.Root));
        }

        
    }
}
