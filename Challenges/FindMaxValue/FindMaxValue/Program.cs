using System;
using Trees.Classes;
using StacksAndQueues.Classes;

namespace FindMaxValueOfTree
{
    public class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine(FindMaxValue(tree));
        }


        public static decimal FindMaxValue(BinaryTree<decimal> tree)
        {
            if (tree == null)
            {
                throw new ArgumentNullException();
            } else if (tree.Root == null)
            {
                throw new ArgumentOutOfRangeException("Given tree must contain values");
            }

            decimal max = tree.Root.Value;
            Queue q = new Queue();
            q.Enqueue(new Node(tree.Root));

            while (q.Peek() != null)
            {
                TreeNode<decimal> tNode = (TreeNode<decimal>)q.Peek().Value;
                if (tNode.Left != null)
                {
                    q.Enqueue(new Node(tNode.Left));
                }
                if (tNode.Right != null)
                {
                    q.Enqueue(new Node(tNode.Right));
                }
                if (tNode.Value > max)
                {
                    max = tNode.Value;
                }
                q.Dequeue();
            }

            return max;
        }
    }
}
