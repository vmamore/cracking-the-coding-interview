using System.Collections.Generic;

namespace _2_linked_lists
{
    public class RemoveDumps
    {
        public LinkedList<T> Clear<T>(LinkedList<T> linkedList)
        {
            var set = new HashSet<T>();
            foreach (var node in linkedList)
                set.Add(node);

            var newLinkedList = new LinkedList<T>();
            foreach (var value in set)
                newLinkedList.AddFirst(value);

            return newLinkedList;
        }

        public LinkedList<T> ClearWithoutBuffer<T>(LinkedList<T> linkedList)
        {
                // int jumpSteps = 1;
                // foreach (var item in linkedList)
                // {
                //     int jumps = 0;
                //     var otherLinkedList = linkedList;
                //     do
                //     {

                //     } while (jumps < jumpSteps);
                //     foreach (var otherItem in otherLinkedList.GetEnumerator().MoveNext())
                //     {
                //         if(item.Equals(otherItem))
                //                 return;
                //     }
                // }

                // var newLinkedList = new LinkedList<T>();
                // foreach (var value in set)
                //     newLinkedList.AddFirst(value);

                // return newLinkedList;

                return new LinkedList<T>();
        }
    }
}