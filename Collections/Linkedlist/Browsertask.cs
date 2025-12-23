using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Linkedlist
{
    public class Browsertask
    {
        private Node head;
        private Node current;

        public void Create(string data)
        {
            head = new Node(data);
            current = head;
        }

        public void Add(string data)
        {
            Node newNode = new Node(data);

            if (current.Next != null)
            {
                current.Next.Prev = null;
                current.Next = null;
            }

      
            current.Next = newNode;
            newNode.Prev = current;
            current = newNode;
        }

        public void Next()
        {
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Next: " + current.data);
            }
            else
            {
                Console.WriteLine("No next node");
            }
        }

        public void Previous()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Previous: " + current.data);
            }
            else
            {
                Console.WriteLine("No previous node");
            }
        }

        public void Current()
        {
            Console.WriteLine("Current: " + current.data);
        }
    }
}