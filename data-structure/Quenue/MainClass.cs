using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure.Quenue
{
    public class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    DemoGenerateQuence();
        //}

        private static void DemoNumberQuence()
        {
            NumberQueue queue = new NumberQueue(10);
            queue.Enquence(2);
            queue.Enquence(3);
            queue.Enquence(4);
            queue.Enquence(5);
            queue.Enquence(6);

            Console.WriteLine("Quence size: " + queue.Length);
            Console.WriteLine("Quence size: " + queue.Size);
            Console.WriteLine("Quence rear: " + queue.Rear());
            Console.WriteLine("Quence front: " + queue.Front());

            int quenceSize = queue.Size;
            for (int i = 0; i < quenceSize; i++)
            {
                Console.WriteLine(queue.Dequence());
            }
            Console.ReadKey();
        }

        private static void DemoGenerateQuence()
        {
            GenerateQuence<ObjectDemo> quenceObject = new GenerateQuence<ObjectDemo>();
            quenceObject.Enquence(new ObjectDemo { Name = "Pharang", Age = 22 });
            quenceObject.Enquence(new ObjectDemo { Name = "David", Age = 22 });
            quenceObject.Enquence(new ObjectDemo { Name = "Phang", Age = 22 });
            quenceObject.Enquence(new ObjectDemo { Name = "rang", Age = 22 });

            int quenceSize = quenceObject.Size;
            for (int i = 0; i < quenceSize; i++)
            {
                Console.WriteLine(quenceObject.Dequence().ToString());
            }
            Console.ReadKey();
        }
    }

    class ObjectDemo
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ToString()
        {
            return "Name: " + this.Name + " - Age: " + this.Age;
        }
    }
}
