﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public TreeNode Root { get; set; }

        /// <summary>
        ///   Builds and returns an array of values in the tree.
        ///      Values are added by recursively traversing each node, adding its value to the list of values, and then 
        ///      adding the values of its children.
        /// </summary>
        /// <returns> Array of values in the Tree, with each node's value appearing before its children's values. </returns>
        public int[] Preorder()
        {
            List<int> list = new List<int>();
            PreorderHelper(list, Root);
            return list.ToArray();
        }

        /// <summary>
        ///     Recursive helper function for Preorder. Accepts the list that values are to be added to and a Node.
        ///      Adds the value of the Node to the given list, and then calls itself on the Node's non-null children. 
        /// </summary>
        /// <param name="list">List of values in the BinaryTree</param>
        /// <param name="node">Current Node</param>
        private void PreorderHelper(List<int> list, TreeNode node) 
        {
            list.Add(node.Value);

            if (node.Left != null)
            {
                PreorderHelper(list, node.Left);
            }

            if (node.Right != null)
            {
                PreorderHelper(list, node.Right);
            }
        }

        /// <summary>
        ///     Builds and returns an array of the values within the Tree.
        ///       Values are added recursively on each Node; each recursive call first adds the value of the Node's Left child,
        ///       adds the Node itself's value, and then the value of its Right child.
        /// </summary>
        /// <returns> Array of values within the tree, with each Node's values in between its children's values. </returns>
        public int[] InOrder()
        {
            List<int> list = new List<int>();
            InOrderHelper(list, Root);
            return list.ToArray();
        }

        /// <summary>
        ///     Recursive helper function for InOrder. Accepts the list that values are to be added to and a Node.
        ///         Calls itself on the Node's Left child, adds the Node's value to the list, and then calls itself on the Node's Right child.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="node"></param>
        private void InOrderHelper(List<int> list, TreeNode node)
        {
            if (node.Left != null)
            {
                InOrderHelper(list, node.Left);
            }

            list.Add(node.Value);

            if (node.Right != null)
            {
                InOrderHelper(list, node.Right);
            }
        }

        /// <summary>
        ///     Builds and returns an array of the values within the Tree.
        ///         Values are added by recursively traversing each Node; the Node's non-null children's values are added first, and
        ///         then the value of the Node itself.
        /// </summary>
        /// <returns> Array of the values within the tree, with each Node's values after its children. </returns>
        public int[] PostOrder()
        {
            List<int> list = new List<int>();
            PostOrderHelper(list, Root);
            return list.ToArray();
        }

        /// <summary>
        ///     Recursive helper function for PostOrder. Accepts a list to which values will be added and a Node.
        ///         Calls itself on the Node's children, then adds the Node's value to the list. 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="node"></param>
        private void PostOrderHelper(List<int> list, TreeNode node)
        {
            if (node.Left != null)
            {
                PostOrderHelper(list, node.Left);
            }
            
            if (node.Right != null)
            {
                PostOrderHelper(list, node.Right);
            }

            list.Add(node.Value);
        }
    }
}
