/// <summary>
/// Problem Statement :  Stacks only allow data to be accessed in a predetermined order.
///             It supports LIFO (Last In First Out)
///             Push -> to insert data
///             Pop -> to remove data    
/// Examples : 
/// </summary>

namespace AlgonDS
{
    public class StackUsingArray
    {
        int maxSize = 0;
        int currentSize = 0;
        int[] stack;

        public StackUsingArray(int size)
        {
            stack = new int[size];
            maxSize = size;
        }

        public void Push(int data)
        {
            if (!IsFull())
            {
                stack[currentSize] = data;
                currentSize++;
            }
        }

        public int? Pop()
        {

            if (!IsEmpty())
            {
                currentSize--;
                return stack[currentSize];
            }

            return (int?)null;
        }

        public int? Peek()
        {
            if (!IsEmpty())
                return stack[currentSize - 1];

            return (int?)null;
        }
        public bool IsEmpty() => currentSize == 0;

        public bool IsFull() => maxSize == currentSize;

        public int Count() => currentSize;
    }
}
