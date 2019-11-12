using System;

namespace week3StacksandQueues
{
    class Program

    {

        static void Main(string[] args)

        {
            IntStack mystack = new IntStack();
            mystack.Push(10);
            System.Console.WriteLine(mystack.Peek() + " Peek");
            System.Console.WriteLine(mystack.Pop());


            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(40);

            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.IsEmpty());
            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.IsEmpty());
            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.IsEmpty());

            Random rand = new Random();
            while(!mystack.IsFull())
            {
                int i = rand.Next(100);
                mystack.Push(i);
            }

            while(!mystack.IsEmpty())
            {
                System.Console.WriteLine(mystack.Pop());
            }

            System.Console.ReadKey();

        }

    }
}
