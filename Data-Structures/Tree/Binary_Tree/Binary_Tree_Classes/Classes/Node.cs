using System;

namespace Trees.Classes
{
    public class TreeNode<T>
    {
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public T Value { get; set; }


        public TreeNode()
        {
            Left = null;
            Right = null;
        }

        public TreeNode (T val)
        {
            Value = val;
            Left = null;
            Right = null;
        }

        public TreeNode (TreeNode<T> left, T val)
        {
            Value = val;
            Left = left;
            Right = null;
        }

        public TreeNode(T val, TreeNode<T> right)
        {
            Value = val;
            Right = right;
            Left = null;
        }

        public TreeNode(TreeNode<T> left, T val, TreeNode<T> right)
        {
            Value = val;
            Left = left;
            Right = right;
        }

    }
}
