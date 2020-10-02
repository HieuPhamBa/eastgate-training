using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace data_structure.DoubleLinkedList
{
    public class GenericLList<T>: IGenericLList<T>
    {
        #region Fields
        public Node<T> Head { get; set; }
        public Node<T> Last { get; set; }
        public int Size { get; set; }
        #endregion

        #region Construtors
        public GenericLList()
        {
            InitialList(1000);
        }
        public GenericLList(int length)
        {
            InitialList(length);
        }
        private void InitialList(int length)
        {
            Head = null;
            Last = null;
        }
        #endregion

        #region Insert to list
        //Insert to head of list
        public Node<T> Push(T obj)
        {
            Node<T> newNode = new Node<T>(obj);
            newNode.PreviousNode = null;
            newNode.NextNode = Head;
            Head = newNode;
            Size++;
            if (Last == null)
            {
                Last = newNode;
            }
            return newNode;
        }
        //Insert to last of list
        public Node<T> Append(T obj)
        {
            Node<T> newNode = new Node<T>(obj);
            newNode.NextNode = null;
            Size++;
            if (Head == null)
            {
                Push(obj);
            }
            else
            {
                Last.NextNode = newNode;
                newNode.PreviousNode = Last;
                Last = newNode;
            }
            return newNode;
        }
        //Insert to before of node
        public Node<T> InsertBefore(Node<T> nextNode, T data)
        {
            if (nextNode == null)
            {
                throw new Exception("Previous node can not be null");
            }
            Node<T> newNode = new Node<T>(data);
            newNode.PreviousNode = nextNode.PreviousNode;
            newNode.NextNode = nextNode;

            nextNode.PreviousNode.NextNode = newNode;
            nextNode.PreviousNode = newNode;
            Size++;
            return newNode;
        }

        public Node<T> InsertAfter(Node<T> previousNode, T data)
        {
            if (previousNode == null)
            {
                throw new Exception("Previous node can not be null");
            }
            Node<T> newNode = new Node<T>(data);
            newNode.NextNode = previousNode.NextNode;
            newNode.PreviousNode = previousNode;
            previousNode.NextNode = newNode;
            Size++;
            return newNode;
        }
        #endregion

        #region Utilities method
        private Node<T> FindNodeByData(T data)
        {
            Node<T> node;
            Node<T> tempNode = Head;

            while (tempNode.NextNode != null)
            {
                if (tempNode.Data.Equals(data))
                {
                    node = tempNode;
                    return node;
                }
                tempNode = tempNode.NextNode;
            }
            return null;
        }
        #endregion

        #region Output the list
        public void OutputTheList()
        {
            Node<T> tempNode = Head;

            while (tempNode.NextNode != null)
            {
                Console.WriteLine(tempNode.Data.ToString());
                tempNode = tempNode.NextNode;
            }
        }
        #endregion

        #region Delete
        //Delete at last
        public Node<T> Pop()
        {
            Node<T> tempNode = Last;
            Last.PreviousNode.NextNode = null;
            Last = Last.PreviousNode;
            tempNode = null;
            Size--;
            return tempNode;
        }

        //Delete at head
        public Node<T> Shift()
        {
            Node<T> tempNode = Head;
            Head = tempNode.NextNode;
            Head.NextNode = tempNode.NextNode.NextNode;
            tempNode = null;
            Size--;
            return tempNode;
        }

        public Node<T> DeleteNode(Node<T> node)
        {
            if (node == null)
            {
                throw new Exception("Node can not be null");
            }
            else if(Head == null)
            {
                throw new Exception("List cant not be null");
            }

            if(node.PreviousNode == null)
            {
                Shift();
            }
            else if(node.NextNode == null)
            {
                Pop();
            }
            else
            {
                Node<T> tempNode = node;
                node.NextNode.PreviousNode = node.PreviousNode;
                node.PreviousNode.NextNode = node.NextNode;
                tempNode = null;
                Size--;
            }
            return node;
        }

        //Delete at position
        public void DeleteNodeAtPos(int pos)
        {
            if (Head==null)
            {
                throw new Exception("List cant not be null");
            }
            else if (pos > Size)
            {
                throw new Exception("Out of range list");
            }
            else
            {
                Node<T> tempNode = null;
                Node<T> node = Head;
                int index = 1;
                while(node!=null)
                {
                    if (index == pos)
                    {
                        tempNode = node;
                        break;
                    }
                    index++;
                    node = node.NextNode;
                }
                DeleteNode(tempNode);
                Size--;
            }
        }
        #endregion
    }
}
