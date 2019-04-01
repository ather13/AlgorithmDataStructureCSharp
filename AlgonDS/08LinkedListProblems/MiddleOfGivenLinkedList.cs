namespace AlgonDS
{
    public class MiddleOfGivenLinkedList : SinglyLinkedList
    {

        public int GetMiddleItem_Way1()
        {
            var position = Count() / 2;
            var counter = 0;
            var node = head;

            while (counter < position)
            {
                node = node.Next;
                counter++;
            }

            return node.Data;
        }

        //Tortise n Rabit style 
        public int GetMiddleItem()
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next!=null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;                
            }

            return slow.Data;
        }

    }
}
