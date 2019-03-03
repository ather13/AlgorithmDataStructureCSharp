namespace AlgonDS
{
    public class QueueUsingLinkedList
    {
        Node head; //pop here
        Node tail; //push here

        //insert here
        public void Enqueue(int data)
        {
            var node = new Node(data);
            if (IsEmpty())
            {
                head = node;
            }
            else
            {
                tail.Next = node;               
            }

            tail = node;
        }

        //retrieve and remove
        public int? Dequeue()
        {
            if (!IsEmpty())
            {
                int data = head.Data;
                head = head.Next;
                if (head == null) tail = null;
                return data;
            }
            return (int?)null;
        }

        // retrieve not remove 
        public int? Peek()
        {
            if (!IsEmpty())
            {
                return head.Data;
            }
            return (int?)null;
        }

        public bool IsEmpty() => head == null;

        //public bool IsFull(){}

        //number of elements
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
