using System;
using System.Collections;
using System.Xml.Linq;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList list = new ArrayList()
            {
             "asadsad",
             "dakwdnad",
             2e2,

            };
            list.Add("salam");
            list.Add(123);

            Queue sira = new Queue();
            sira.Enqueue('d');
            sira.Enqueue("d");
            sira.Dequeue();
            sira.Peek();


        }
    }
}
