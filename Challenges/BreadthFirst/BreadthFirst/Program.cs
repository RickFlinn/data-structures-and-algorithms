using System;
using Trees.Classes;
using StacksAndQueues.Classes;
using System.Collections.Generic;

namespace BreadthFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            TreeNode<object> leftBranch = new TreeNode<object>( new TreeNode<object>(4),
                                                                2,
                                                                new TreeNode<object>( new TreeNode<object>(8),
                                                                                      5, 
                                                                                      new TreeNode<object>(9))
                                                               );

            TreeNode<object> rightBranch = new TreeNode<object>( new TreeNode<object>(6),
                                                                 3,
                                                                 new TreeNode<object>( 7,
                                                                                       new TreeNode<object>(10))
                                                                );

            tree.Root = new TreeNode<object>(leftBranch, 1, rightBranch);
            BreadthFirst(tree);

        }


        /// <summary>
        ///     Performs a breadth-first traversal of a BinaryTree, printing each value to Console and adding them to a List.
        ///         Return the List after all values have been printed to Console.
        /// </summary>
        /// <param name="tree"> Binary Tree typed to objects </param>
        /// <returns> List of the Binary Tree's values, "breadth-first" </returns>
        public static List<object> BreadthFirst(BinaryTree<object> tree)
        {
            List<object> list = null;
            try
            {
                list = new List<object>();

                if (tree == null)
                {
                    throw new ArgumentNullException("Given Tree is null.");
                }


                if (tree.Root == null)
                {
                    throw new NullReferenceException("Given Tree contains no Nodes.");
                }

                Queue q = new Queue();
                q.Enqueue(new Node(tree.Root));

                while (q.Peek() != null)
                {
                    TreeNode<object> node = (TreeNode<object>)q.Peek().Value;
                    if (node.Left != null)
                    {
                        q.Enqueue(new Node(node.Left));
                    }
                    if (node.Right != null)
                    {
                        q.Enqueue(new Node(node.Right));
                    }
                    Console.Write(node.Value + " ");
                    list.Add(node.Value);
                    q.Dequeue();
                }
                return list;

            } catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
                throw;
            }catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                throw;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}
