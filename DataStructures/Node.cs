using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

    }
}
