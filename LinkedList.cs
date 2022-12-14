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

        public void AddMiddle(int data) 
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = this.head;
                Node middle = this.head;
                while (temp.next != null && temp.next.next != null)
                {
                    temp = temp.next.next;
                    middle = temp.next;
                }
                node.next = middle.next;
                middle.next = node;

            }
            Console.WriteLine($"Added {node.data} to the middle");
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
