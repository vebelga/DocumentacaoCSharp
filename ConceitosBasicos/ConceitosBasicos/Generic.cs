using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.ConceitosBasicos
{
    public class GenericList<T>
    {
        public void Add(T item) { }

        private class Node(T t)
        {
            public T Data { get; set; } = t;
            public Node? Next { get; set; }
        }

        private Node? head;

        public void AddHead(T t)
        {
            Node n = new(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;

            while (current is not null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public class ExampleClass { }

        public class TestGenericList
        {
            public void Test()
            {
                GenericList<int> list1 = new();
                list1.Add(1);

                GenericList<string> list2 = new();
                list2.Add("");

                GenericList<ExampleClass> list3 = new();
                list3.Add(new ExampleClass());

                GenericList<int> list = new();

                for (int x = 0; x < 10; x++)
                {
                    list.AddHead(x);
                }

                foreach (int i in list)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Done");
            }
        }
    }
}
