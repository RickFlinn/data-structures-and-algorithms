using System;
using Xunit;
using Trees.Classes;

namespace Binary_Tree
{
    public class UnitTest1
    {
        [Fact]
        public void InOrderEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.Equal(new int[] { }, tree.InOrder());
        }

        [Fact]
        public void InOrderShallow()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new TreeNode<int>(new TreeNode<int>(1), 2, new TreeNode<int>(3));
            Assert.Equal(new int[] { 1, 2, 3 }, tree.InOrder());
        }

        [Fact]
        public void InOrderDeep()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            TreeNode<int> branch1 = new TreeNode<int>(new TreeNode<int>(1), 2, new TreeNode<int>(3));
            TreeNode<int> branch2 = new TreeNode<int>(new TreeNode<int>(5), 6, new TreeNode<int>(7));
            tree.Root = new TreeNode<int>(branch1, 4, branch2);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, tree.InOrder());
        }

        [Fact]
        public void PreOrderEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.Equal(new int[] { }, tree.PreOrder());
        }

        [Fact]
        public void PreOrderShallow()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new TreeNode<int>(new TreeNode<int>(2), 1, new TreeNode<int>(3));
            Assert.Equal(new int[] { 1, 2, 3 }, tree.PreOrder());
        }

        [Fact]
        public void PreOrderDeep()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            TreeNode<int> branch1 = new TreeNode<int>(new TreeNode<int>(3), 2, new TreeNode<int>(4));
            TreeNode<int> branch2 = new TreeNode<int>(new TreeNode<int>(6), 5, new TreeNode<int>(7));
            tree.Root = new TreeNode<int>(branch1, 1, branch2);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, tree.PreOrder());
        }

        [Fact]
        public void PostOrderEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.Equal(new int[] { }, tree.PostOrder());
        }

        [Fact]
        public void PostOrderShallow()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new TreeNode<int>(new TreeNode<int>(1), 3, new TreeNode<int>(2));
            Assert.Equal(new int[] { 1, 2, 3 }, tree.PostOrder());
        }

        [Fact]
        public void PostOrderDeep()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            TreeNode<int> branch1 = new TreeNode<int>(new TreeNode<int>(1), 3, new TreeNode<int>(2));
            TreeNode<int> branch2 = new TreeNode<int>(new TreeNode<int>(4), 6, new TreeNode<int>(5));
            tree.Root = new TreeNode<int>(branch1, 7, branch2);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, tree.PostOrder());
        }

        [Fact]
        public void AddToNull()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(1);
            Assert.Equal(1, tree.Root.Value);
        }

        [Fact]
        public void AddToEnd()
        {
            BinarySearchTree tree = new BinarySearchTree();
            TreeNode<int> branch1 = new TreeNode<int>(new TreeNode<int>(3), 2, new TreeNode<int>(4));
            TreeNode<int> branch2 = new TreeNode<int>(new TreeNode<int>(6), 5, new TreeNode<int>(7));
            tree.Root = new TreeNode<int>(branch1, 1, branch2);
            tree.Add(8);
            Assert.Equal(8, tree.Root.Right.Right.Right.Value);
        }

        [Fact]
        public void AddToMiddle()
        {
            BinarySearchTree tree = new BinarySearchTree();
            TreeNode<int> branch1 = new TreeNode<int>(new TreeNode<int>(1), 2, new TreeNode<int>(4));
            TreeNode<int> branch2 = new TreeNode<int>(new TreeNode<int>(7), 8, new TreeNode<int>(9));
            tree.Root = new TreeNode<int>(branch1, 5, branch2);
            tree.Add(3);
            Assert.Equal(3, tree.Root.Left.Right.Left.Value);
        }

        [Fact]
        public void DoesntContain()
        {
            BinarySearchTree tree = new BinarySearchTree();
            TreeNode<int> branch1 = new TreeNode<int>(new TreeNode<int>(1), 2, new TreeNode<int>(4));
            TreeNode<int> branch2 = new TreeNode<int>(new TreeNode<int>(7), 8, new TreeNode<int>(9));
            tree.Root = new TreeNode<int>(branch1, 5, branch2);
            Assert.False(tree.Contains(3));
        }

        [Fact]
        public void NullContain()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.False(tree.Contains(1));
        }

        [Fact]
        public void DoesContain()
        {
            BinarySearchTree tree = new BinarySearchTree();
            TreeNode<int> branch1 = new TreeNode<int>(new TreeNode<int>(1), 2, new TreeNode<int>(4));
            TreeNode<int> branch2 = new TreeNode<int>(new TreeNode<int>(7), 8, new TreeNode<int>(9));
            tree.Root = new TreeNode<int>(branch1, 5, branch2);
            Assert.True(tree.Contains(7));
        }
    }

}
