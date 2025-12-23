using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Linkedlist
{
    public class Node
    {
        public string data;
        public Node Next;
        public Node Prev;

        public Node(string data)
        {
            this.data = data;
            Next = null;
            Prev = null;
        }
    }
}
