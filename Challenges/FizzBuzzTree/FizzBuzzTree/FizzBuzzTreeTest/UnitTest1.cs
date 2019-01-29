using System;
using Xunit;
using Trees.Classes;
using FizzBuzzTree;


namespace FizzBuzzTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void NullTree()
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            Program.FizzBuzzTree(tree);
            Assert.Equal(new object[] { }, tree.PreOrder());
        }

        [Fact]
        public void NoFizzBuzzes()
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            tree.Root = new TreeNode<object>(new TreeNode<object>(16), 4, new TreeNode<object>(8));
            Program.FizzBuzzTree(tree);
            Assert.Equal(new object[] { 4, 16, 8 }, tree.PreOrder());
        }

        [Fact]
        public void FizzBuzzReplaces()
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            TreeNode<object> rightBranch = new TreeNode<object>(3, new TreeNode<object>(5));
            tree.Root = new TreeNode<object>(new TreeNode<object>(15), 4, rightBranch);
            Program.FizzBuzzTree(tree);
            Assert.Equal(new object[] { 4, "FizzBuzz", "Fizz", "Buzz" }, tree.PreOrder());
        }
    }
}
