using System;

/// <summary>
/// Problem Statement :  A linked-list is a sequence of data structures which are connected together via links.
///                 Singly Linked List should Navigate forward only.
/// Examples : 
/// </summary>


namespace AlgonDS
{
    public class SinglyLinkedList { 

        Node head;

        public SinglyLinkedList() { }

        public void Add(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                var node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Node(data);
            }
        }

        public bool Delete(int data)
        {
            var node = head;
            Node prevNode = null;
            while (node != null)
            {
                if (node.Data == data)
                {
                    if (prevNode == null)
                    {
                        head = head.Next;
                    }
                    else
                    {
                        prevNode.Next = node.Next;
                    }                    
                    return true;
                }
                prevNode = node;
                node = node.Next;
            }

            return false;
        }

        public Node Find(int data)
        {
            var node = head;
            while (node != null)
            {
                if (node.Data == data)
                {
                    return node;
                }
                node = node.Next;
            }

            return null;
        }

        public void Display()
        {
            var node = head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public int Count()
        {
            int count = 0;
            var node = head;
            while (node != null)
            {
                node = node.Next;
                count++;
            }

            return count;
        }
    }    
}
