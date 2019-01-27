using System;

namespace Trees.Classes
{
    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Value { get; set; }


        public TreeNode()
        {
            Left = null;
            Right = null;
        }

        public TreeNode (int val)
        {
            Value = val;
            Left = null;
            Right = null;
        }

        public TreeNode (TreeNode left, int val)
        {
            Value = val;
            Left = left;
            Right = null;
        }

        public TreeNode(int val, TreeNode right)
        {
            Value = val;
            Right = right;
            Left = null;
        }

        public TreeNode(TreeNode left, int val, TreeNode right)
        {
            Value = val;
            Left = left;
            Right = right;
        }

    }
}
