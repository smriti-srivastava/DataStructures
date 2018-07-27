using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    interface IDataStructures
    {
        void Add(int data, int position);
        int Remove(int position);
        void Display();
        void Sort();
    }
}
