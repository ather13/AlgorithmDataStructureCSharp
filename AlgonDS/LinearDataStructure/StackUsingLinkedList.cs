/// <summary>
/// Problem Statement :  Stacks only allow data to be accessed in a predetermined order.
///             It supports LIFO (Last In First Out)
///             Push -> to insert data
///             Pop -> to remove data    
/// Examples : 
/// </summary>
/// 
namespace AlgonDS
{
    public class StackUsingLinkedList
    {
        private Node top; //pop from here
        public void Push(int data)
        {
            var node = new Node(data);
            if (top != null)
            {
                node.Next = top;
            }
            top = node;
        }
        public int? Pop()
        {
            var data = top.Data;
            top = top.Next;
            return data;
        }

        public int? Peek()
        {
            return top == null ? (int?)null : top.Data;
        }
        public bool IsEmpty()
        {
            return top == null;
        }

        //full is not applicable with linked list
        //if we want to support then add one property to limit 
        //the number of elements
        //public bool IsFull() {}

        public int Count()
        {
            var node = top;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }
    }
}
