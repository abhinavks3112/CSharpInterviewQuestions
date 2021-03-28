using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Data_Structures
{
    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class DNode
    {
        internal int data;
        internal DNode next;
        internal DNode previous;
        public DNode(int d)
        {
            data = d;
            previous = null;
            next = null;
        }
    }
    class LinkedList
    {
        internal Node head;

        public void InsertFront(LinkedList linkedList, int data)
        {
            // Create a new node and initialize with the data
            Node newNode = new Node(data);

            if (linkedList.head != null)
            {
                // Make the new node point to the current head of the linked list
                newNode.next = linkedList.head;
            }

            // Make the new node as head or set it as starting point of the linked list
            linkedList.head = newNode;
        }

        public void InsertEnd(LinkedList linkedList, int data)
        {
            // Create a new node and initialize with the data
            Node newNode = new Node(data);

            if (linkedList.head != null)
            {
                // Set a temp node to the first node or head of the linked list
                var node = linkedList.head;

                // Traverse the linked list till we get to the last node(identified by node whose next pointer is null)
                while (node.next != null)
                {
                    node = node.next;
                }

                // Set the last node's next pointer to the new node
                node.next = newNode;

                // Set the new node's next pointer to null(indicating that it is now the last node)
                newNode.next = null;
            }
            else
            {
                // If there is no head that means it is now the only node or head
                // Make the new node point as the current head of the linked list
               linkedList.head = newNode;
            }  
        }
    
        public void InsertAfter(Node prevNode, int data)
        {
            // Create a new node and initialize with the data
            Node newNode = new Node(data);
            
            // If the given node is not the last node
            if (prevNode.next != null)
            {
                // Get the next node
                Node nextNode = prevNode.next;

                // Set the new node to point to the next node
                newNode.next = nextNode;
                
            }
            else
            {
                // If the previous node is the last node or the only node or head
                newNode.next = null;
            }

            // Set the previous node to point to the new node
            prevNode.next = newNode;
        }
    
        public void DeleteNodeByKey(LinkedList linkedList, int key)
        {
            Node temp = linkedList.head;
            Node prev = null;

            if(temp != null && temp.data == key)
            {
                // Head node is the node we have to delete so, we have to make the head pointer point to next node
                linkedList.head = temp.next;
                return;
            }
            while(temp !=null && temp.data != key)
            {
                // Traverse till we get the matching node
                prev = temp;
                temp = temp.next;
            }
            if(temp == null)
            {
                return;
            }
            if(temp != null && temp.data == key)
            {
                // If the matching node has no node after it that is this is the last node then delete it and make
                // the previous node as last node by setting the previous node's next pointer to null
                if(temp.next == null)
                {
                    prev.next = null;
                }
                // If the matching node has node(s) after it then connect the previous node to them
                prev.next = temp.next;
            }
        }
    
        public void ReverseLinkedList(LinkedList linkedList)
        {
            if (linkedList.head == null)
                return;
            
            // Let's take 2nd node as our current node
            Node currentNode = linkedList.head.next;

            // Let's take 1st node as our previous node
            Node previousNode = linkedList.head;

            // Let's take 3rd node as our next node
            Node nextNode = currentNode.next;

            // Starting reversing of linked list so current head node should become last node and should
            // point to null
            linkedList.head.next = null;

            while (currentNode != null)
            {
                // Current node should point to previous node
                currentNode.next = previousNode;

                // Advancing the previous node to current node
                previousNode = currentNode;

                if(nextNode == null)
                {
                    // If the current node is last node
                    // Making the last node as head of linked list
                    linkedList.head = currentNode;
                }

                // Advancing the current node to next node
                currentNode = nextNode;

                if (nextNode != null)
                // Advancing the next node 
                {
                    nextNode = nextNode.next;
                }
            }
        }
    
        public void PrintAllNodes(LinkedList linkedList)
        {
            if(linkedList == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if(linkedList.head == null)
            {
                Console.WriteLine("Error!! List starting node is not set");
                return;
            }

            var tempNode = linkedList.head;
            Console.WriteLine("The list values of single linked list are as follows");
            while(tempNode != null)
            {
                Console.WriteLine(tempNode.data);
                tempNode = tempNode.next;
            }
        }
    }

    class DoubleLinkedList
    {
        internal DNode head;

        public void InsertFront(DoubleLinkedList linkedList, int data)
        { 
            // Create a new node and initialize with the data
            DNode newNode = new DNode(data);

            // Make the new node point to the current head of the linked list
            newNode.next = linkedList.head;

            // Set the previous pointer of new node point as null since it will be set as the current head of the linked list
            newNode.previous = null;

            if (linkedList.head != null)
            {
                // Point the previous pointer of the current head to point to new node because after insertion of new
                // node from front, the current head will no longer be first node, it will be second node and
                // hence will also need to point to first node since this is a double link list node
                linkedList.head.previous = newNode;
            }

            // Make the new node as head or set it as starting point of the linked list
            linkedList.head = newNode;
        }
        
        public void InsertEnd(DoubleLinkedList linkedList, int data)
        {
            // Create a new node and initialize with the data
            DNode newNode = new DNode(data);

            if (linkedList.head != null)
            {
                // Set a temp node to the first node or head of the linked list
                var node = linkedList.head;

                // Traverse the linked list till we get to the last node(identified by node whose next pointer is null)
                while (node.next != null)
                {
                    node = node.next;
                }

                // Set the last node's next pointer to the new node
                node.next = newNode;

                // Set the last node's previous pointer to the new node
                newNode.previous = node;
            }
            else
            {
                // If there is no head that means it is now the only node or head
                // Make the new node as head or set it as starting point of the linked list
                newNode.previous = null;
                linkedList.head = newNode;
            }
        }

        public void InsertAfter(DNode prevNode, int data)
        {
            // Create a new node and initialize with the data
            DNode newNode = new DNode(data);

            // If the given node is not the last node
            if (prevNode.next != null)
            {
                // Get the next node
                DNode nextNode = prevNode.next;

                // Set the next node's previous pointer to the new node
                nextNode.previous = newNode;

                // Set the new node to point to thes next node
                newNode.next = nextNode;                
            }
            else
            {
                // If the previous node is the last node or the only node or head
                newNode.next = null;
            }

            // Set the new node's previous pointer to the previous node
            newNode.previous = prevNode;

            // Set the previous node to point to the new node
            prevNode.next = newNode;
        }

        public void DeleteNodeByKey(DoubleLinkedList linkedList, int key)
        {
            DNode temp = linkedList.head;

            if (temp != null && temp.data == key)
            {

                // Head node is the node we have to delete so, we have to make the head pointer point to next node
                linkedList.head = temp.next;
                if(linkedList.head != null)
                    linkedList.head.previous = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                // Traverse till we get the matching node
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp != null && temp.data == key)
            {
                // If the matching node has no node after it that is this is the last node then delete it and make
                // the previous node as last node by setting the previous node's next pointer to null
                if (temp.next == null)
                {
                    temp.previous.next = null;
                }
                else
                {
                    // If the matching node has node(s) after it then connect the previous node to them
                    temp.previous.next = temp.next;
                    temp.next.previous = temp.previous;
                }
            }
        }

        public void ReverseLinkedList(DoubleLinkedList linkedList)
        {
            if (linkedList.head == null)
                return;

            // Let's take 2nd node as our current node
            DNode currentNode = linkedList.head.next;

            // Let's take 1st node as our previous node
            DNode previousNode = linkedList.head;

            // Let's take 3rd node as our next node
            DNode nextNode = currentNode.next;

            // Starting reversing of linked list so current head node should become last node and should
            // point to null
            linkedList.head.next = null;

            while (currentNode != null)
            {
                // Previous node's previous pointer should point to current node
                previousNode.previous = currentNode;

                // Current node's next pointer should point to previous node
                currentNode.next = previousNode;

                // Current node's previous pointer should point to next node
                currentNode.previous = nextNode;

                // Advancing the previous node to current node
                previousNode = currentNode;

                if (nextNode == null)
                {
                    // If the current node is last node
                    // Making the last node as head of linked list
                    linkedList.head = currentNode;
                }

                // Advancing the current node to next node
                currentNode = nextNode;

                if (nextNode != null)
                // Advancing the next node 
                {
                    nextNode = nextNode.next;
                }
            }
        }
        public void PrintAllNodes(DoubleLinkedList linkedList)
        {
            if (linkedList == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (linkedList.head == null)
            {
                Console.WriteLine("Error!! List starting node is not set");
                return;
            }

            var tempNode = linkedList.head;
            Console.WriteLine("The list values of double linked list are as follows");
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.data);
                tempNode = tempNode.next;
            }
        }
    }
}
