using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Data_Structures
{
    internal class BNode
    {
        public int Data { get; set; }
        public BNode Left { get; set; }
        public BNode Right { get; set; }
        public BNode(int d)
        {
            this.Data = d;
            this.Left = null;
            this.Right = null;
        }
    }
    class BinaryTree
    {
        internal BNode root;

        public BinaryTree()
        {
            root = null;
        }

        // Iterative
        public void Iterative_Insert(BinaryTree tree, int data)
        {
            // Create and initialize a new binary tree node
            BNode new_Node = new BNode(data);
            if (tree.root == null)
            {
                // If there is no root that means the new node will now serve as the root node
                tree.root = new_Node;
            }
            else
            {
                BNode current = tree.root;
                BNode tempParent = null;
                // Iterative way
                while (true)
                {
                    tempParent = current;
                    // If there is already a root node present then traverse down the binary tree and insert the node
                    if (new_Node.Data < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            tempParent.Left = new_Node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            tempParent.Right = new_Node;
                            return;
                        }
                    }
                }
            }
        }
        
        //Recursive
        public void Recursive_Insert(BNode root, int data)
        {
            BNode new_Node = new BNode(data);
            if(root == null)
            {
                root = new_Node;
            }
            else
            {
                if(new_Node.Data < root.Data)
                {
                    if (root.Left == null)
                        root.Left = new_Node;
                    else
                        Recursive_Insert(root.Left, data);
                }
                else
                {
                    if (root.Right == null)
                        root.Right = new_Node;
                    else
                        Recursive_Insert(root.Right, data);
                }
            }
        }

        // Iterative
        public void Iterative_DisplayInPreOrder(BinaryTree tree)
        {
            Console.WriteLine("\n****************Display in Pre Order*****************");
            if (tree.root != null)
            {
                BNode current = null;
                Stack<BNode> preOrderStack = new Stack<BNode>();
                preOrderStack.Push(tree.root);
                Console.WriteLine("\nThe elements of binary tree in preorder are as follows");
                while (preOrderStack.Count > 0)
                {
                    current = preOrderStack.Peek();
                    Console.WriteLine(current.Data);
                    preOrderStack.Pop();

                    if (current.Right != null)
                        preOrderStack.Push(current.Right);
                    if (current.Left != null)
                        preOrderStack.Push(current.Left);
                }
            }
        }

        public void Iterative_DisplayInPostOrder(BinaryTree tree)
        {
            Console.WriteLine("\n****************Display in Post Order*****************");
            if (tree.root != null)
            {
                BNode current = null;
                Stack<BNode> postOrderInputStack = new Stack<BNode>();
                Stack<BNode> postOrderOutputStack = new Stack<BNode>();
                postOrderInputStack.Push(tree.root);

                while (postOrderInputStack.Count > 0)
                {
                    current = postOrderInputStack.Peek();
                    postOrderOutputStack.Push(current);
                    postOrderInputStack.Pop();

                    if (current.Left != null)
                        postOrderInputStack.Push(current.Left);
                    if (current.Right != null)
                        postOrderInputStack.Push(current.Right);    
                }
                Console.WriteLine("\nThe elements of binary tree in post order are as follows");
                while(postOrderOutputStack.Count > 0)
                {
                    BNode output = postOrderOutputStack.Pop();
                    Console.WriteLine(output.Data);
                }
            }
        }

        public void Iterative_DisplayInOrder(BinaryTree tree)
        {
            Console.WriteLine("\n****************Display in InOrder*****************");
            Console.WriteLine("\nThe elements of binary tree inorder are as follows");
            if (tree.root != null)
            {
                BNode current = tree.root;
                Stack<BNode> InOrderStack = new Stack<BNode>();

                while (current != null || InOrderStack.Count > 0)
                {
                    while(current != null)
                    {
                        InOrderStack.Push(current);
                        current = current.Left;
                    }
                    current = InOrderStack.Peek();
                    Console.WriteLine(current.Data);
                    InOrderStack.Pop();
                    current = current.Right;
                }
            }
        }

        public void Recursive_DisplayInPreOrder(BNode root)
        {
            if(root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(root.Data);
                Recursive_DisplayInPreOrder(root.Left);
                Recursive_DisplayInPreOrder(root.Right);
            }
        }

        public void Recursive_DisplayInOrder(BNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {   
                Recursive_DisplayInOrder(root.Left);
                Console.WriteLine(root.Data);
                Recursive_DisplayInOrder(root.Right);
            }
        }

        public void Recursive_DisplayInPostOrder(BNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {               
                Recursive_DisplayInPostOrder(root.Left);               
                Recursive_DisplayInPostOrder(root.Right);
                Console.WriteLine(root.Data);
            }
        }
    }
}
