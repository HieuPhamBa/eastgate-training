using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure.DoubleLinkedList
{
    public class Node <T>
    {
        public Node<T> PreviousNode;
        public Node<T> NextNode;
        public T Data;
        public Node(T data)
        {
            Data = data;
        }
    }
}
