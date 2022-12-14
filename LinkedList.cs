using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    internal class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node; 
            }
            else
            {
                Node temp = head; 
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"Added {node.data} to the list");
        }
        //public void AddFront(int data) 
        //{
        //    Node node = new Node(data);
        //    if (this.head == null) 
        //        this.head = null;
        //    else
        //    {
        //        node.next = this.head; 
        //        this.head = node;
        //    }
        //    Console.WriteLine($"Added {node.data} to the front");
        //}


        public void RemoveFirst() 
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            this.head = this.head.next;
            Console.WriteLine("removed the last node from the list");
        }
        public void Display()
        {
            Node temp = this.head; 
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null) 
            {
                Console.Write(temp.data + " ");
                temp = temp.next; 
            }
        }
    }
}
