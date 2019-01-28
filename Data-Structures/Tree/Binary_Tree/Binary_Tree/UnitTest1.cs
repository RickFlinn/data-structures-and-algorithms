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
            BinaryTree tree = new BinaryTree();
            Assert.Equal(new int[] { }, tree.InOrder());
        }

        [Fact]
        public void InOrderShallow()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new TreeNode(new TreeNode(1), 2, new TreeNode(3));
            Assert.Equal(new int[] { 1, 2, 3 }, tree.InOrder());
        }

        [Fact]
        public void InOrderDeep()
        {
            BinaryTree tree = new BinaryTree();
            TreeNode branch1 = new TreeNode(new TreeNode(1), 2, new TreeNode(3));
            TreeNode branch2 = new TreeNode(new TreeNode(5), 6, new TreeNode(7));
            tree.Root = new TreeNode(branch1, 4, branch2);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, tree.InOrder());
        }

        [Fact]
        public void PreOrderEmpty()
        {
            BinaryTree tree = new BinaryTree();
            Assert.Equal(new int[] { }, tree.PreOrder());
        }

        [Fact]
        public void PreOrderShallow()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new TreeNode(new TreeNode(2), 1, new TreeNode(3));
            Assert.Equal(new int[] { 1, 2, 3 }, tree.PreOrder());
        }

        [Fact]
        public void PreOrderDeep()
        {
            BinaryTree tree = new BinaryTree();
            TreeNode branch1 = new TreeNode(new TreeNode(3), 2, new TreeNode(4));
            TreeNode branch2 = new TreeNode(new TreeNode(6), 5, new TreeNode(7));
            tree.Root = new TreeNode(branch1, 1, branch2);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, tree.PreOrder());
        }

        [Fact]
        public void PostOrderEmpty()
        {
            BinaryTree tree = new BinaryTree();
            Assert.Equal(new int[] { }, tree.PostOrder());
        }

        [Fact]
        public void PostOrderShallow()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new TreeNode(new TreeNode(1), 3, new TreeNode(2));
            Assert.Equal(new int[] { 1, 2, 3 }, tree.PostOrder());
        }

        [Fact]
        public void PostOrderDeep()
        {
            BinaryTree tree = new BinaryTree();
            TreeNode branch1 = new TreeNode(new TreeNode(1), 3, new TreeNode(2));
            TreeNode branch2 = new TreeNode(new TreeNode(4), 6, new TreeNode(5));
            tree.Root = new TreeNode(branch1, 7, branch2);
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
            TreeNode branch1 = new TreeNode(new TreeNode(3), 2, new TreeNode(4));
            TreeNode branch2 = new TreeNode(new TreeNode(6), 5, new TreeNode(7));
            tree.Root = new TreeNode(branch1, 1, branch2);
            tree.Add(8);
            Assert.Equal(8, tree.Root.Right.Right.Right.Value);
        }

        [Fact]
        public void AddToMiddle()
        {
            BinarySearchTree tree = new BinarySearchTree();
            TreeNode branch1 = new TreeNode(new TreeNode(1), 2, new TreeNode(4));
            TreeNode branch2 = new TreeNode(new TreeNode(7), 8, new TreeNode(9));
            tree.Root = new TreeNode(branch1, 5, branch2);
            tree.Add(3);
            Assert.Equal(3, tree.Root.Left.Right.Left.Value);
        }

        [Fact]
        public void DoesntContain()
        {
            BinarySearchTree tree = new BinarySearchTree();
            TreeNode branch1 = new TreeNode(new TreeNode(1), 2, new TreeNode(4));
            TreeNode branch2 = new TreeNode(new TreeNode(7), 8, new TreeNode(9));
            tree.Root = new TreeNode(branch1, 5, branch2);
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
            TreeNode branch1 = new TreeNode(new TreeNode(1), 2, new TreeNode(4));
            TreeNode branch2 = new TreeNode(new TreeNode(7), 8, new TreeNode(9));
            tree.Root = new TreeNode(branch1, 5, branch2);
            Assert.True(tree.Contains(7));
        }
    }

}
