﻿using System;

namespace LinkedListDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structures program using generics");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}