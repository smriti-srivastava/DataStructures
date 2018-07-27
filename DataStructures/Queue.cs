using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue : IDataStructures
    {
        Node _start;
        Node _end;

        public Queue()
        {
            this._start = null;
            this._end = null;
        }

        public bool IsEmpty()
        {
            if (this._start == null && (this._end == null))
                return true;
            return false;
        }

        public int Peak()
        {
            if (IsEmpty())
            {
                Console.WriteLine("QUEUE IS EMPTY");
                return -1;
            }
            return this._start.Data;
        }

        public void Add(int data, int position = -1)
        {
            Node newNode = new Node(data);
            if (this._start == null && this._end == null)
            {
                this._start = newNode;
                this._end = newNode;
            }
            else
            {
                this._end.Next = newNode;
                this._end = newNode;
            }
        }

        public void Display()
        {
            Node temporaryNode = null;
            Console.WriteLine("QUEUE:");
            Console.Write("\nSTART-->");
            for (temporaryNode = this._start; temporaryNode != null; temporaryNode = temporaryNode.Next)
                Console.Write("{0}-->", temporaryNode.Data);
            Console.Write("END");
        }

        public int Remove(int position = -1)
        {
            int data = -1;
            if (IsEmpty())
                Console.WriteLine("\nQUEUE UNDERFLOW!");
            else
            {
                data = this._start.Data;
                if (this._start == this._end)
                {
                    this._start = null;
                    this._end = null;
                }
                else
                {
                    this._start = this._start.Next;
                }
            }
            return data;
        }

        public void Sort()
        {
            Node i, j;
            int temporaryVariable;
            for (i = this._start; i.Next != null; i = i.Next)
                for (j = this._start; j.Next != null; j = j.Next)
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
