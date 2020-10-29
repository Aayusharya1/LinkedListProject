using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            //stack.AddToBack(56);
            //stack.AddToBack(30);
            //stack.AddToBack(70);
            //stack.Display();

            //Inserting number at specific position
            //list.AddToBack(56);
            //list.AddToBack(70);
            //list.InsertAtParticularPosition(2, 30);
            //list.Display();

            //list.AddToBack(56);
            //list.AddToBack(30);
            //list.AddToBack(70);
            //list.Display();

            //list.DeleteFisrtElement();
            //list.DeleteLastElement();
            //list.Display();

            list.AddWithSorting(6);
            list.AddWithSorting(2);
            list.AddWithSorting(8);
            list.AddWithSorting(3);
            list.AddWithSorting(7);
            list.AddWithSorting(9);
            list.AddWithSorting(5);
            list.Display();
        }
    }
}
