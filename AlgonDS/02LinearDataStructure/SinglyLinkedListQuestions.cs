using System.Collections.Generic;

namespace AlgonDS
{
    public class SinglyLinkedListQuestions : SinglyLinkedList
    {
        /*
         Given a Singly Linked list, Update the second half of the list such that 
         n-th element becomes sum(1st + nth) element,(n-1)st element becomes sum(2nd + n-1st) element and so on.
        Eg: 2->3->4->5->6 => 2->3->(4+4)->(5+3)->(6+2)
        */
        public void SumMergeOtherHalf()
        {
            //if either null then we cant add 
            if (head == null || head.Next == null) return;

            var slow = head;
            var fast = head;
            var mid = Count() / 2 + Count() % 2;
            var counter = 1;
            var stack =new Stack<int>();
            
            //to get to center location
            while (fast != null && fast.Next != null)
            {
                stack.Push(slow.Data);
                fast = fast.Next;
                slow = slow.Next;
                counter++;
                if (fast != null)
                {
                    fast = fast.Next;
                }
            }

            //mainly for condition when records are odd
            if(counter == mid)
            {
                stack.Push(slow.Data);
            }

            //final work - addition
            var node = head;
            while (slow != null && stack.Count != 0)
            {
                slow.Data = slow.Data + stack.Pop();

                slow = slow.Next;
            } 
        }
    }
}
