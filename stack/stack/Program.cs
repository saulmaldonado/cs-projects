using System;
using System.Collections.Generic;

namespace stack
{

    public class Stack
    {
        public List<Object> stack { get; private set; }

        public Stack()
        {
            stack = new List<Object>();
        }

        public object Pop()
        {
            try
            {
                if(stack.Count < 1)
                {
                    throw new InvalidOperationException("There are no items in the stack to remove.");
                }
                object lastItem = stack[stack.Count - 1];

                stack.RemoveAt(stack.Count - 1);

                return lastItem;
            }
            catch (InvalidOperationException e)
            {

                return e;
            }

        }

        public void Push(Object item)
        {
            try
            {
                if (item == null)
                {
                    throw new InvalidOperationException("Cannot insert null into the stack.");
                }

                stack.Add(item);
            }
            catch (InvalidOperationException e)
            {

                Console.WriteLine(e);
            }
        }

        public void Clear()
        {
            try
            {
                stack.Clear();
            }
            catch (InvalidOperationException e)
            {

                throw e;
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(null); 
            stack.Push(2); 
            stack.Push(3); 
            
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());
        }
    }
}
