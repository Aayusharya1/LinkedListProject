using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList stack = new LinkedList();
            stack.AddToBack(56);
            stack.AddToBack(30);
            stack.AddToBack(70);
            stack.Display();

        }
    }
}
