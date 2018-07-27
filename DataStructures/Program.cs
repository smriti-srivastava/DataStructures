using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("\n\n\n--------DATA STRUCTURES MENU--------");
                    Console.WriteLine("1. Linked List");
                    Console.WriteLine("2. Stack");
                    Console.WriteLine("3. Queue");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter Your Choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                LinkedList myList = new LinkedList();
                                int flag = 0;
                                while (flag == 0)
                                {
                                    Console.WriteLine("\n\n\n------LINKED LIST MENU--------");
                                    Console.WriteLine("1. Add Element");
                                    Console.WriteLine("2. Remove Element");
                                    Console.WriteLine("3. Sort Linked List");
                                    Console.WriteLine("4. Display Linked List");
                                    Console.WriteLine("5. Exit");
                                    Console.WriteLine("\nEnter Your Choice : ");
                                    int linkedListOperationChoice = Convert.ToInt32(Console.ReadLine());

                                    switch (linkedListOperationChoice)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Enter The Position Where You Want to Insert The Data : ");
                                                int position = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Enter the data : ");
                                                int data = Convert.ToInt32(Console.ReadLine());
                                                myList.Add(data, position);
                                                myList.Display();
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Enter The Position Of The Data Which You Want To Delete : ");
                                                int position = Convert.ToInt32(Console.ReadLine());
                                                int data = myList.Remove(position);
                                                myList.Display();
                                                break;
                                            }
                                        case 3:
                                            {
                                                myList.Sort();
                                                Console.WriteLine("\nSorted Linked List");
                                                myList.Display();
                                                break;
                                            }
                                        case 4:
                                            {
                                                myList.Display();
                                                break;
                                            }
                                        case 5:
                                            {
                                                flag = 1;
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid Choice Entered");
                                                break;
                                            }
                                    }
                                }
                                break;
                            }
                        case 2:
                            {
                                Stack myStack = new Stack();
                                int flag = 0;
                                while (flag == 0)
                                {
                                    Console.WriteLine("\n\n\n------STACK MENU------");
                                    Console.WriteLine("1. Push Element");
                                    Console.WriteLine("2. Pop Element");
                                    Console.WriteLine("3. Sort Stack");
                                    Console.WriteLine("4. Get Top Element");
                                    Console.WriteLine("5. Display Stack");
                                    Console.WriteLine("6. Exit");
                                    Console.WriteLine("\nEnter Your Choice : ");
                                    int stackOperationChoice = Convert.ToInt32(Console.ReadLine());

                                    switch (stackOperationChoice)
                                    {
                                        case 1:
                                            {

                                                Console.WriteLine("Enter the data : ");
                                                int data = Convert.ToInt32(Console.ReadLine());
                                                myStack.Add(data);
                                                myStack.Display();
                                                break;
                                            }
                                        case 2:
                                            {
                                                int data = myStack.Remove();
                                                myStack.Display();
                                                break;
                                            }
                                        case 3:
                                            {
                                                myStack.Sort();
                                                Console.WriteLine("\nAfter Sorting");
                                                myStack.Display();
                                                break;
                                            }
                                        case 4:
                                            {
                                                int data = myStack.GetElement();
                                                if (data != -1)
                                                {
                                                    Console.WriteLine("TOP ELEMENT IS : {0}", data);
                                                }
                                                break;
                                            }
                                        case 5:
                                            {
                                                myStack.Display();
                                                break;
                                            }
                                        case 6:
                                            {
                                                flag = 1;
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid Choice Entered");
                                                break;
                                            }
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                Queue myQueue = new Queue();
                                int flag = 0;
                                while (flag == 0)
                                {
                                    Console.WriteLine("\n\n\n------QUEUE MENU------");
                                    Console.WriteLine("1. Enqueue");
                                    Console.WriteLine("2. Dequeue");
                                    Console.WriteLine("3. Sort Queue");
                                    Console.WriteLine("4. Peak");
                                    Console.WriteLine("5. Display Queue");
                                    Console.WriteLine("6. Exit");
                                    Console.WriteLine("\nEnter Your Choice : ");
                                    int queueOperationChoice = Convert.ToInt32(Console.ReadLine());

                                    switch (queueOperationChoice)
                                    {
                                        case 1:
                                            {

                                                Console.WriteLine("\nEnter the data : ");
                                                int data = Convert.ToInt32(Console.ReadLine());
                                                myQueue.Add(data);
                                                myQueue.Display();
                                                break;
                                            }
                                        case 2:
                                            {
                                                int data = myQueue.Remove();
                                                if (data != -1)
                                                {
                                                    Console.WriteLine("\n{0} IS DELETED.", data);
                                                    myQueue.Display();
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                myQueue.Sort();
                                                Console.WriteLine("\nAFTER SORTING:");
                                                myQueue.Display();
                                                break;
                                            }
                                        case 4:
                                            {
                                                int data = myQueue.Peak();
                                                if (data != -1)
                                                {
                                                    Console.WriteLine("The First Element Is : {0} ", data);
                                                }
                                                break;
                                            }
                                        case 5:
                                            {
                                                myQueue.Display();
                                                break;
                                            }
                                        case 6:
                                            {
                                                flag = 1;
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid Choice Entered");
                                                break;
                                            }
                                    }
                                }
                                break;
                            }
                        case 4:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Choice Entered");
                                break;
                            }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Program Terminated Due To The Following Exception : {0}", e.Message);
                Console.ReadKey();
            }
        }
    }
}
