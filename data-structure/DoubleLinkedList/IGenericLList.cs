using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure.DoubleLinkedList
{
    public interface IGenericLList<T>
    {
        #region Insert
        //Insert to head
        Node<T> Push(T obj);
        //Insert to tail
        Node<T> Append(T obj);
        //Insert before
        Node<T> InsertBefore(Node<T> nextNode, T data);
        //Insert after
        Node<T> InsertAfter(Node<T> previousNode, T data);
        //Ouput the list
        #endregion

        #region Ouput 
        void OutputTheList();
        #endregion

        #region Delete
        //Delete at last of list
        Node<T> Pop();
        //Delete at head of list
        Node<T> Shift();
        //Delete at head of list
        Node<T> DeleteNode(Node<T> node);
        //Delete at position
        void DeleteNodeAtPos(int pos);
        #endregion

    }
}
