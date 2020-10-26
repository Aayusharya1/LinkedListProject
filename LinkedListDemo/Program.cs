using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList stack = new LinkedList();
            stack.AddToStack(70);
            stack.AddToStack(30);
            stack.AddToStack(56);
            stack.Display();

        }
    }
}
