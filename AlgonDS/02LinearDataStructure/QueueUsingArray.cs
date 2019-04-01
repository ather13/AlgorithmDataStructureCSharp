using System;

namespace AlgonDS.LinearDataStructure
{
    public class QueueUsingArray {

        int[] queue;
        int maxSize = 0;
        int rear = 0;
        int front = 0;

        public QueueUsingArray(int size)
        {
            queue = new int[size];
            maxSize = size;
        }

        //insert here
        public void Enqueue(int data)
        {
            if (IsFull())
            {
                throw new Exception("queue is full");
            }
            
            queue[rear] = data;
            rear++;           
        }

        //retrieve and remove
        public int? Dequeue()
        {
            if (!IsEmpty())
            {                
                return queue[front++];                
            }
            return (int?)null;
        }

        // retrieve not remove 
        public int? Peek()
        {
            if (!IsEmpty())
            {
                return queue[front];
            }
            return (int?)null;
        }

        public bool IsEmpty() => rear == front;

        //number of elements
        public bool IsFull() => rear == maxSize;        

        public int Count() => rear-front;

    }
}
