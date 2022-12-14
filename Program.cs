using System;

namespace LinkedListDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to data structures program using generics");
            LinkedList list = new LinkedList();
            //list.Add(70);
            //list.AddFront(30);
            //list.AddFront(56);

            //list.Add(56);
            //list.Add(70);
            //list.AddMiddle(30);

            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();
            //list.RemoveFirst();

            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.RemoveLast();

            list.Display();
        }
    }
}