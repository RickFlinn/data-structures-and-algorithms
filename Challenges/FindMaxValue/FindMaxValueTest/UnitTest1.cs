using System;
using Trees.Classes;
using Xunit;
using FindMaxValueOfTree;

namespace FindMaxValueTest
{
    public class UnitTest1
    {
        [Fact]
        public void NullTree()
        {
            Assert.ThrowsAny<ArgumentNullException>(() => Program.FindMaxValue(null));
        }

        [Fact]
        public void NullRoot()
        {
            BinaryTree<decimal> tree = new BinaryTree<decimal>();
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => Program.FindMaxValue(tree));
        }
        
        [Fact]
        public void GetsMax()
        {
            BinaryTree<decimal> tree = new BinaryTree<decimal>();
            TreeNode<decimal> leftBranch = new TreeNode<decimal>(new TreeNode<decimal>(0.0001m),
                                                                50m,
                                                                new TreeNode<decimal>(new TreeNode<decimal>(-1m),
                                                                                      5m,
                                                                                      new TreeNode<decimal>(9001m))
                                                               );

            TreeNode<decimal> rightBranch = new TreeNode<decimal>(new TreeNode<decimal>(1m),
                                                                 910m,
                                                                 new TreeNode<decimal>(7m,
                                                                                       new TreeNode<decimal>(1337m))
                                                                );
            tree.Root = new TreeNode<decimal>(leftBranch, 884, rightBranch);
            Assert.Equal(9001, Program.FindMaxValue(tree));

        }

        [Fact]
        public void AllEqual()
        {
            BinaryTree<decimal> tree = new BinaryTree<decimal>();
            TreeNode<decimal> leftBranch = new TreeNode<decimal>(new TreeNode<decimal>(-0.09009m),
                                                                -0.09009m,
                                                                new TreeNode<decimal>(new TreeNode<decimal>(-0.09009m),
                                                                                      -0.09009m,
                                                                                      new TreeNode<decimal>(-0.09009m))
                                                               );

            TreeNode<decimal> rightBranch = new TreeNode<decimal>(new TreeNode<decimal>(-0.09009m),
                                                                 -0.09009m,
                                                                 new TreeNode<decimal>(-0.09009m,
                                                                                       new TreeNode<decimal>(-0.09009m))
                                                                );
            tree.Root = new TreeNode<decimal>(leftBranch, -0.09009m, rightBranch);
            Assert.Equal(-0.09009m, Program.FindMaxValue(tree));
        }
        

    }
}
