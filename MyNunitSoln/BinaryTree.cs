using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitSoln
{
    /// <summary>
    /// Implementation of the binary tree data structure.
    /// </summary>
    public class BinaryTree
    {
        /// <summary>
        /// Gets or sets the root node of the binary tree
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Adds a new node with a value to the binary tree.
        /// </summary>
        /// <param name="value">The value to be added to the tree.</param>
        /// <returns>If the value is added returns true; else false.</returns>
        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        /// <summary>
        /// Finds the node with the value specified in the parameters.
        /// </summary>
        /// <param name="value">The value to be searched for.</param>
        /// <returns>The node with the specified value, else null.</returns>
        public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }

        /// <summary>
        /// Using the find method to find a node with the specified value in the binary tree.
        /// </summary>
        /// <param name="value">The value to be searched for.</param>
        /// <param name="parent">The starting node for the search.</param>
        /// <returns>The node with the specified value, else false.</returns>
        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }

        /// <summary>
        /// Removes the node with the specified value from the binary tree.
        /// </summary>
        /// <param name="value">The value to be removed.</param>
        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        /// <summary>
        /// Remove a node with a specified key from the binary search tree.
        /// </summary>
        /// <param name="parent">The current parent node being considered</param>
        /// <param name="key">The key value of the node to be removed.</param>
        /// <returns>The modified parent node after the removal operation.</returns>
        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        /// <summary>
        /// Find the minimum value in a subtree.
        /// </summary>
        /// <param name="node">The starting node for finding the minimum value.</param>
        /// <returns>The minimum value in the subtree.</returns>
        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        /// <summary>
        /// Traverses the binary tree in pre-order.
        /// </summary>
        /// <param name="parent">The starting node for traversal.</param>
        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        /// <summary>
        /// Traverses the binary tree in in-order.
        /// </summary>
        /// <param name="parent">The starting node for traversal.</param>
        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        /// <summary>
        /// Traverses the binary tree in post-order.
        /// </summary>
        /// <param name="parent">The starting node for traversal.</param>
        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }

    }
}
