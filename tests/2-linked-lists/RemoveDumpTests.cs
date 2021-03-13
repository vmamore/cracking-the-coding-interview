using System.Collections.Generic;
using Xunit;

namespace tests._2_linked_lists
{
    public class RemoveDumpTests
    {
        [Fact]
        public void Remove_Duplicated_Items_From_Linked_List()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(3);

            var set = new HashSet<int>();
            foreach(var node in linkedList)
                set.Add(node);

            var newLinkedList = new LinkedList<int>();
            foreach(var value in set)
                newLinkedList.AddFirst(value);
        }
    }
}