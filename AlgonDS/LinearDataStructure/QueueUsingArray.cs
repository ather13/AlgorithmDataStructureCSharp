using System;
using System.Collections.Generic;
using System.Text;

namespace AlgonDS.LinearDataStructure
{
    public class QueueUsingArray {

        int[] queue;
        int maxSize = 0;
        int currentSize = 0;

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
            
            queue[currentSize] = data;
            currentSize++;           
        }

        //retrieve and remove
        public int? Dequeue()
        {
            if (!IsEmpty())
            {
                currentSize--;
                return queue[currentSize];
            }
            return (int?)null;
        }

        // retrieve not remove 
        public int? Peek()
        {
            if (!IsEmpty())
            {
                return queue[currentSize-1];
            }
            return (int?)null;
        }

        public bool IsEmpty() => currentSize == 0;

        //number of elements
        public bool IsFull() => currentSize == maxSize;        

        public int Count() => currentSize;

    }
}
