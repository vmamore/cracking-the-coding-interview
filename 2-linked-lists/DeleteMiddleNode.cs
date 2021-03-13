using System.Collections.Generic;

namespace _2_linked_lists
{
    public class DeleteMiddleNode
    {
        public static LinkedList<T> Execute<T>(LinkedList<T> list, T nodeToRemove)
        {
            var head = list.First;

            do
            {
                if (head.Next.Value.Equals(nodeToRemove))
                {
                    var nextValue = head.Next.Next;
                    head.ValueRef = nextValue;
                }
            } while (head.Next != null);
        }
    }
}