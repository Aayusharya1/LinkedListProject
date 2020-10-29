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

            list.AddToBack(56);
            list.AddToBack(30);
            list.AddToBack(70);
            list.Display();

            //list.DeleteFisrtElement();
            list.DeleteLastElement();
            list.Display();
        }
    }
}
