using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a stack
            // Using Stack class
            Stack myStack = new Stack();

            // Adding elements in the Stack Using Push method
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);

            myStack.PrintStack();
            myStack.Peek();          
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();
        }
    }
}
