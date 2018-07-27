using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList : IDataStructures
    {
        private Node _head;
        private int _size;

        public LinkedList()
        {
            _head = null;
            _size = 0;
        }

        public void Add(int data, int position)
        {
            if (position >= 0 && position <= (this._size + 1))
            {

                Node newNode = new Node(data);
                if (this._head == null)
                {
                    _head = newNode;
                    this._size = 1;
                }
                else
                {

                    if (position == 1)
                    {
                        newNode.Next = this._head;
                        this._head = newNode;
                    }
                    else
                    {
                        Node previousNode = null, currentNode = null;

                        int positionCount = 1;



                        currentNode = _head;
                        while (positionCount != position && currentNode != null)
                        {
                            previousNode = currentNode;
                            currentNode = currentNode.Next;
                            positionCount++;
                        }
                        newNode.Next = currentNode;
                        previousNode.Next = newNode;
                    }
                }
                this._size = this._size + 1;
            }
            else
            {
                Console.WriteLine("Invalid Position Entered.");
            }
        }

        public void Display()
        {
            Node currentNode = this._head;
            Console.WriteLine("Linked List:");
            Console.Write("\nHEAD-->");
            while (currentNode != null)
            {
                Console.Write("{0}-->", currentNode.Data);
                currentNode = currentNode.Next;
            }
            Console.Write("NULL");

        }

        public int Remove(int position = -1)
        {
            int data = -1;
            if (this._head == null)
                Console.WriteLine("LIST IS EMPTY");

            else
            {
                if (position >= 1 && position <= this._size)
                {
                    if (position == 1)
                    {
                        data = this._head.Data;
                        this._head = this._head.Next;
                    }
                    else
                    {
                        Node currentNode = this._head;
                        Node previousNode = null;
                        int positionCount = 1;
                        while (position != positionCount)
                        {
                            previousNode = currentNode;
                            currentNode = currentNode.Next;
                            positionCount++;
                        }
                    data = currentNode.Data;
                    previousNode.Next = currentNode.Next;
                    }
                    this._size = this._size - 1;
                 }
                 else
                 {
                        Console.WriteLine("Invalid Position Entered");
                 }
               
            }
            
            return data;
        }

        public void Sort()
        {
            Node i, j;
            int temporaryVariable;
            for (i = this._head; i.Next != null; i = i.Next)
                for (j = this._head; j.Next != null; j = j.Next)
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
