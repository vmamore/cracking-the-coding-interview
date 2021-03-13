using System.Collections.Generic;

namespace _2_linked_lists
{
    public class KthToLast
    {
        public T Find<T>(LinkedList<T> linkedList, int position)
        {
            var length = linkedList.Count;

            var positionWanted = length - position;

            var valueToReturn = default(T);

            int count = 1;

            foreach (var item in linkedList)
            {
                if (count == positionWanted)
                {
                    valueToReturn = item;
                    break;
                }
                count++;
            }

            return valueToReturn;
        }
    }
}