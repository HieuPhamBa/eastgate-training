using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure.DoubleLinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DemoDemoLinked();
        }

        public static void DemoDemoLinked()
        {
            GenericLList<ObjectDemoList> list = new GenericLList<ObjectDemoList>();
            list.Append(new ObjectDemoList { Name = "Pharang", Age = 22 });
            list.Append(new ObjectDemoList { Name = "David", Age = 22 });
            Node<ObjectDemoList> nodeTest = list.Append(new ObjectDemoList { Name = "Phang", Age = 22 });
            list.Append(new ObjectDemoList { Name = "rang", Age = 22 });

            list.InsertBefore(nodeTest, new ObjectDemoList { Name = "Hoa", Age = 22 });
            //list.Pop();
            //list.DeleteNodeAtPos(2);
            list.Shift();
            Node<ObjectDemoList> tempNode = list.Head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Data.OutputData);
                tempNode = tempNode.NextNode;
            }

        }
    }
    class ObjectDemoList
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string OutputData => "Name: " + this.Name + " - Age: " + this.Age;
    }
}
