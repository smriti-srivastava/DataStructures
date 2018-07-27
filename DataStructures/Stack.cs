using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack : IDataStructures
    {
        Node _top;
        public Stack()
        {
            this._top = null;
        }

        public int GetElement()
        {
            if (this._top == null)
            {
                Console.WriteLine("\nSTACK IS EMPTY.");
                return -1;
            }
            return this._top.Data;
        }

        public void Add(int data, int position = -1)
        {
            Node newNode = new Node(data);
            if (this._top == null)
                this._top = newNode;
            else
            {
                newNode.Next = this._top;
                this._top = newNode;
            }
        }

        public void Display()
        {
            Node temporaryNode = null;
            Console.WriteLine("\nSTACK:");
            Console.Write("TOP-->");
            for (temporaryNode = this._top; temporaryNode != null; temporaryNode = temporaryNode.Next)
                Console.Write("{0}-->", temporaryNode.Data);
            Console.Write("NULL");
        }

        public int Remove(int position = -1)
        {
            int data = -1;
            if (this._top == null)
                Console.WriteLine("\nSTACK OVERFLOW!");
            else
            {
                data = this._top.Data;
                this._top = this._top.Next;
            }
            return data;
        }

        public void Sort()
        {
            Node i, j;
            int temporaryVariable;
            for (i = this._top; i.Next != null; i = i.Next)
            {
                for (j = this._top; j.Next != null; j = j.Next)
                {
                    if (j.Data > j.Next.Data)
                    {
                        temporaryVariable = j.Data;
                        j.Data = j.Next.Data;
                        j.Next.Data = temporaryVariable;
                    }
                }
            }
        }
    }
}
