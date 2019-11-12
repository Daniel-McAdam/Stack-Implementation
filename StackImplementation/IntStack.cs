using System;
using System.Collections.Generic;
using System.Text;

namespace week3StacksandQueues
{
    class IntStack

    {

        private const int maxsize = 10;
        private int top = 0;
        private int[] array = new int[maxsize];

        public void Push(int value)

        {
            array[top++] = value;
        }



        public int Pop()

        {
            return array[--top];
        }



        public int Peek()

        {
            //Top is location where next value will be added to queue, so Top -1 shows current 
            return array[(top - 1)];
        }

        public bool IsEmpty()

        {
            
            return top <= 0;// insert code here
        }



        public bool IsFull()

        {
            return top == maxsize;
        }



    }
}
