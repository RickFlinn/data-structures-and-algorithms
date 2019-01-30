using System;
using Trees.Classes;
using Xunit;
using BreadthFirst;

namespace BreadthFirstTests
{
    public class UnitTest1
    {
        [Fact]
        public void ThrowsNullArg()
        {
            Assert.ThrowsAny<ArgumentNullException>(() => Program.BreadthFirst(null));
        }
        
        [Fact]
        public void ThrowsNoNodes()
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            Assert.ThrowsAny<NullReferenceException>(() => Program.BreadthFirst(tree));
        }

        [Fact]
        public void SingleNode()
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            tree.Root = new TreeNode<object>(1);
            Assert.Equal(new object[] { 1 }, Program.BreadthFirst(tree));
        }
        

        [Fact]
        public void GetsValuesBreadthFirst()
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            TreeNode<object> leftBranch = new TreeNode<object>(new TreeNode<object>(4),
                                                                2,
                                                                new TreeNode<object>(new TreeNode<object>(8),
                                                                                      5,
                                                                                      new TreeNode<object>(9))
                                                               );

            TreeNode<object> rightBranch = new TreeNode<object>(new TreeNode<object>(6),
                                                                 3,
                                                                 new TreeNode<object>(7,
                                                                                       new TreeNode<object>(10))
                                                                );

            tree.Root = new TreeNode<object>(leftBranch, 1, rightBranch);
            object[] vals = Program.BreadthFirst(tree).ToArray();
            Assert.Equal(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, vals);
        }
    }
}
